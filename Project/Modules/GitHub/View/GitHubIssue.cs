using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Tools4Libraries;

namespace Droid_Infra
{
    public class GitHubIssue : PanelCustom
    {
        #region Attribute
        private System.ComponentModel.IContainer components = null;
        private const string OFFLINE_ISSUES_FILE = "IssueToPost.xml";

        private Label _labelTitle;
        private TextBox _textBoxTitle;
        private ComboBox _comboBoxType;
        private Label _labelType;
        private TextBox _textBoxDescription;
        private Button _buttonReport;
        private Label _labelModule;
        private ComboBox _comboboxRepo;
        private string _user;
        private string _password;
        private GitHubAdapter _gha;
        private List<string> _repositories;
        #endregion

        #region Properties
        public List<string> Repositories
        {
            get { return _repositories; }
            set
            {
                _repositories = value;
            LoadRepo();
            }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string User
        {
            get { return _user; }
            set { _user = value; }
        }
        #endregion

        #region Constructor
        public GitHubIssue()
        {
            _repositories = new List<string>();
            InitializeComponent();
            InitializeComponentCustom();
        }
        #endregion

        #region Methods public
        public void ShowDialog(string user, string password, List<string> repositories = null)
        {
            _user = user;
            _password = password;
            _repositories = repositories;
            LoadRepo();
        }
        public void Dispose()
        {
            if (components != null)
            {
                components.Dispose();
            }
        }
        #endregion

        #region Methods private
        private void InitializeComponent()
        {
            this._labelModule = new System.Windows.Forms.Label();
            this._comboboxRepo = new System.Windows.Forms.ComboBox();
            this._buttonReport = new System.Windows.Forms.Button();
            this._textBoxDescription = new System.Windows.Forms.TextBox();
            this._labelType = new System.Windows.Forms.Label();
            this._comboBoxType = new System.Windows.Forms.ComboBox();
            this._textBoxTitle = new System.Windows.Forms.TextBox();
            this._labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _labelModule
            // 
            this._labelModule.AutoSize = true;
            this._labelModule.ForeColor = System.Drawing.Color.White;
            this._labelModule.Location = new System.Drawing.Point(12, 68);
            this._labelModule.Name = "_labelModule";
            this._labelModule.Size = new System.Drawing.Size(42, 13);
            this._labelModule.TabIndex = 8;
            this._labelModule.Text = "Module";
            // 
            // _comboboxRepo
            // 
            this._comboboxRepo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._comboboxRepo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboboxRepo.FormattingEnabled = true;
            this._comboboxRepo.Location = new System.Drawing.Point(139, 65);
            this._comboboxRepo.Name = "_comboboxRepo";
            this._comboboxRepo.Size = new System.Drawing.Size(323, 21);
            this._comboboxRepo.TabIndex = 3;
            // 
            // _buttonReport
            // 
            this._buttonReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonReport.Location = new System.Drawing.Point(387, 245);
            this._buttonReport.Name = "_buttonReport";
            this._buttonReport.Size = new System.Drawing.Size(75, 23);
            this._buttonReport.TabIndex = 6;
            this._buttonReport.Text = "Create issue";
            this._buttonReport.UseVisualStyleBackColor = true;
            this._buttonReport.Click += new System.EventHandler(this._buttonReport_Click);
            // 
            // _textBoxDescription
            // 
            this._textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxDescription.ForeColor = System.Drawing.Color.Gray;
            this._textBoxDescription.Location = new System.Drawing.Point(15, 92);
            this._textBoxDescription.Multiline = true;
            this._textBoxDescription.Name = "_textBoxDescription";
            this._textBoxDescription.Size = new System.Drawing.Size(447, 147);
            this._textBoxDescription.TabIndex = 5;
            this._textBoxDescription.Text = "Description";
            this._textBoxDescription.Enter += new System.EventHandler(this._textBoxDescription_Enter);
            // 
            // _labelType
            // 
            this._labelType.AutoSize = true;
            this._labelType.ForeColor = System.Drawing.Color.White;
            this._labelType.Location = new System.Drawing.Point(12, 41);
            this._labelType.Name = "_labelType";
            this._labelType.Size = new System.Drawing.Size(76, 13);
            this._labelType.TabIndex = 4;
            this._labelType.Text = "Kind of repport";
            // 
            // _comboBoxType
            // 
            this._comboBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxType.FormattingEnabled = true;
            this._comboBoxType.Items.AddRange(new object[] {
            "Improvment",
            "Critical issue (the application crash)",
            "Error issue (restart application to have a correct working)",
            "Warning issue (disfunctionment of an option)",
            "Info issue (about design, labels, user ergonomy)"});
            this._comboBoxType.Location = new System.Drawing.Point(139, 38);
            this._comboBoxType.Name = "_comboBoxType";
            this._comboBoxType.Size = new System.Drawing.Size(323, 21);
            this._comboBoxType.TabIndex = 2;
            // 
            // _textBoxTitle
            // 
            this._textBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBoxTitle.Location = new System.Drawing.Point(74, 12);
            this._textBoxTitle.Name = "_textBoxTitle";
            this._textBoxTitle.Size = new System.Drawing.Size(388, 20);
            this._textBoxTitle.TabIndex = 1;
            // 
            // _labelTitle
            // 
            this._labelTitle.AutoSize = true;
            this._labelTitle.ForeColor = System.Drawing.Color.White;
            this._labelTitle.Location = new System.Drawing.Point(12, 15);
            this._labelTitle.Name = "_labelTitle";
            this._labelTitle.Size = new System.Drawing.Size(27, 13);
            this._labelTitle.TabIndex = 0;
            this._labelTitle.Text = "Title";
            // 
            // GitHubIssue
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Location = new System.Drawing.Point(78, 78);
            this.Name = "GitHubIssue";
            this.Size = new System.Drawing.Size(515, 321);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void InitializeComponentCustom()
        {
            this.panelMiddle.Controls.Add(this._labelModule);
            this.panelMiddle.Controls.Add(this._comboboxRepo);
            this.panelMiddle.Controls.Add(this._buttonReport);
            this.panelMiddle.Controls.Add(this._textBoxDescription);
            this.panelMiddle.Controls.Add(this._labelType);
            this.panelMiddle.Controls.Add(this._comboBoxType);
            this.panelMiddle.Controls.Add(this._textBoxTitle);
            this.panelMiddle.Controls.Add(this._labelTitle);
        }
        private void LoadRepo()
        {
            _gha = new GitHubAdapter(_user, _password);
            _gha.RepoUser = "ThibaultMontaufray";
            var repos = _gha.GetRepos("Droid-");
            _comboboxRepo.Items.Add("Autre");
            foreach (var item in repos.OrderBy(r => r.Name).ToList())
            {
                _comboboxRepo.Items.Add(item.Name.Replace("Droid-", string.Empty));
            }
            if (_comboboxRepo.Items.Count <= 1 && _repositories != null)
            {
                _repositories.Sort();
                foreach (var item in _repositories)
                {
                    _comboboxRepo.Items.Add(item.Replace("Droid-", string.Empty));
                }
            }
            _comboboxRepo.SelectedIndex = 0;
            _comboBoxType.SelectedIndex = 0;
        }
        private void SaveIssue()
        {
            string text = string.Format("<issue title=\"{0}\" type=\"{1}\" repository=\"{2}\" description=\"{3}\" />", _textBoxTitle.Text, _comboBoxType.Text, _comboboxRepo.Text, _textBoxDescription.Text);
            Tools4Libraries.Log.Happen(OFFLINE_ISSUES_FILE, text);
        }
        private void ProcessOldIssues()
        {
            string title;
            string description;
            string type;
            string repository;
            string text = Tools4Libraries.Log.GetFile(OFFLINE_ISSUES_FILE);
            foreach (string row in text.Split('\n'))
            {
                try
                {
                    if (!string.IsNullOrEmpty(row))
                    { 
                        title = Regex.Split(row, "title=\"")[1].Split('"')[0];
                        description = Regex.Split(row, "description=\"")[1].Split('"')[0];
                        type = Regex.Split(row, "type=\"")[1].Split('"')[0];
                        repository = Regex.Split(row, "repository=\"")[1].Split('"')[0];

                        if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(repository)) continue;

                        title = string.Format("[{0}] {1}", type, title);
                        _gha.PublishIssue(string.Format("Droid-{0}", repository), title, description);
                    }
                }
                finally
                {

                }
            }
            Tools4Libraries.Log.Clean(OFFLINE_ISSUES_FILE);
        }
        #endregion

        #region Event
        private void _buttonReport_Click(object sender, EventArgs e)
        {
            string title = string.Format("[{0}] {1}", _comboBoxType.Text, _textBoxTitle.Text);

            _gha.RepoUser = "ThibaultMontaufray";
            bool published = _gha.PublishIssue(string.Format("Droid-{0}", _comboboxRepo.Text), title, _textBoxDescription.Text);
            if (!published)
            {
                SaveIssue();
            }
            else
            {
                ProcessOldIssues();
            }
        }
        private void _textBoxDescription_Enter(object sender, EventArgs e)
        {
            if (_textBoxDescription.Text == "Description")
            {
                _textBoxDescription.Text = string.Empty;
                _textBoxDescription.ForeColor = Color.Black;
            }
        }
        #endregion
    }
}