using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Droid_Infra
{
    public static class CreateGitHubIssue
    {
        #region Attribute
        private static System.ComponentModel.IContainer components = null;
        private const string OFFLINE_ISSUES_FILE = "IssueToPost.xml";

        private static Form _form;
        private static Label _labelTitle;
        private static TextBox _textBoxTitle;
        private static ComboBox _comboBoxType;
        private static Label _labelType;
        private static TextBox _textBoxDescription;
        private static Button _buttonReport;
        private static Label _labelModule;
        private static ComboBox _comboboxRepo;
        private static Button _buttonCancel;

        private static string _user;
        private static string _password;
        private static GitHubAdapter _gha;
        private static List<string> _repositories;
        #endregion

        #region Properties
        #endregion

        #region Constructor
        static CreateGitHubIssue()
        {
            Tools4Libraries.Log.ApplicationAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Servodroid\Droid-Deployer";
            InitializeComponent();
        }
        #endregion

        #region Methods public
        public static void ShowDialog(string user, string password, List<string> repositories = null)
        {
            _user = user;
            _password = password;
            _repositories = repositories;
            LoadRepo();
            _form.ShowDialog();
        }
        public static void Dispose()
        {
            if (components != null)
            {
                components.Dispose();
            }
            _form.Dispose();
        }
        #endregion

        #region Methods private
        private static void InitializeComponent()
        {
            _form = new System.Windows.Forms.Form();
            _labelTitle = new System.Windows.Forms.Label();
            _textBoxTitle = new System.Windows.Forms.TextBox();
            _comboBoxType = new System.Windows.Forms.ComboBox();
            _labelType = new System.Windows.Forms.Label();
            _textBoxDescription = new System.Windows.Forms.TextBox();
            _buttonReport = new System.Windows.Forms.Button();
            _buttonCancel = new System.Windows.Forms.Button();
            _labelModule = new System.Windows.Forms.Label();
            _comboboxRepo = new System.Windows.Forms.ComboBox();
            _form.SuspendLayout();
            // 
            // _labelTitle
            // 
            _labelTitle.AutoSize = true;
            _labelTitle.Location = new System.Drawing.Point(12, 15);
            _labelTitle.Name = "_labelTitle";
            _labelTitle.Size = new System.Drawing.Size(27, 13);
            _labelTitle.TabIndex = 0;
            _labelTitle.Text = "Title";
            // 
            // _textBoxTitle
            // 
            _textBoxTitle.Location = new System.Drawing.Point(74, 12);
            _textBoxTitle.Name = "_textBoxTitle";
            _textBoxTitle.Size = new System.Drawing.Size(352, 20);
            _textBoxTitle.TabIndex = 1;
            _textBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // _comboBoxType
            // 
            _comboBoxType.FormattingEnabled = true;
            _comboBoxType.Items.AddRange(new object[] {
            "Improvment",
            "Critical issue (the application crash)",
            "Error issue (restart application to have a correct working)",
            "Warning issue (disfunctionment of an option)",
            "Info issue (about design, labels, user ergonomy)"});
            _comboBoxType.Location = new System.Drawing.Point(139, 38);
            _comboBoxType.Name = "_comboBoxType";
            _comboBoxType.Size = new System.Drawing.Size(287, 21);
            _comboBoxType.TabIndex = 2;
            _comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            _comboBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // comboBox1
            // 
            _comboboxRepo.FormattingEnabled = true;
            _comboboxRepo.Location = new System.Drawing.Point(139, 65);
            _comboboxRepo.Name = "comboBox1";
            _comboboxRepo.Size = new System.Drawing.Size(287, 21);
            _comboboxRepo.TabIndex = 3;
            _comboboxRepo.DropDownStyle = ComboBoxStyle.DropDownList;
            _comboboxRepo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top |System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // _labelType
            // 
            _labelType.AutoSize = true;
            _labelType.Location = new System.Drawing.Point(12, 41);
            _labelType.Name = "_labelType";
            _labelType.Size = new System.Drawing.Size(76, 13);
            _labelType.TabIndex = 4;
            _labelType.Text = "Kind of repport";
            // 
            // _textBoxDescription
            // 
            _textBoxDescription.ForeColor = System.Drawing.Color.Gray;
            _textBoxDescription.Location = new System.Drawing.Point(15, 92);
            _textBoxDescription.Multiline = true;
            _textBoxDescription.Name = "_textBoxDescription";
            _textBoxDescription.Size = new System.Drawing.Size(411, 179);
            _textBoxDescription.TabIndex = 5;
            _textBoxDescription.Text = "Description";
            _textBoxDescription.Enter += new System.EventHandler(_textBoxDescription_Enter);
            _textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // _buttonReport
            // 
            _buttonReport.Location = new System.Drawing.Point(351, 283);
            _buttonReport.Name = "_buttonReport";
            _buttonReport.Size = new System.Drawing.Size(75, 23);
            _buttonReport.TabIndex = 6;
            _buttonReport.Text = "Send report";
            _buttonReport.UseVisualStyleBackColor = true;
            _buttonReport.Click += new System.EventHandler(_buttonReport_Click);
            _buttonReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // _buttonCancel
            // 
            _buttonCancel.Location = new System.Drawing.Point(270, 283);
            _buttonCancel.Name = "_buttonCancel";
            _buttonCancel.Size = new System.Drawing.Size(75, 23);
            _buttonCancel.TabIndex = 7;
            _buttonCancel.Text = "Cancel";
            _buttonCancel.UseVisualStyleBackColor = true;
            _buttonCancel.Click += new System.EventHandler(_buttonCancel_Click);
            _buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // _labelModule
            // 
            _labelModule.AutoSize = true;
            _labelModule.Location = new System.Drawing.Point(12, 68);
            _labelModule.Name = "_labelModule";
            _labelModule.Size = new System.Drawing.Size(42, 13);
            _labelModule.TabIndex = 8;
            _labelModule.Text = "Module";
            // 
            // CreateGitHubIssue
            // 
            _form.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            _form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            _form.ClientSize = new System.Drawing.Size(434, 314);
            _form.Controls.Add(_labelModule);
            _form.Controls.Add(_comboboxRepo);
            _form.Controls.Add(_buttonCancel);
            _form.Controls.Add(_buttonReport);
            _form.Controls.Add(_textBoxDescription);
            _form.Controls.Add(_labelType);
            _form.Controls.Add(_comboBoxType);
            _form.Controls.Add(_textBoxTitle);
            _form.Controls.Add(_labelTitle);
            _form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            _form.Name = "CreateGitHubIssue";
            _form.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            _form.Text = "Report an issue";
            _form.ResumeLayout(false);
            _form.PerformLayout();

        }
        private static void LoadRepo()
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
        private static void SaveIssue()
        {
            string text = string.Format("<issue title=\"{0}\" type=\"{1}\" repository=\"{2}\" description=\"{3}\" />", _textBoxTitle.Text, _comboBoxType.Text, _comboboxRepo.Text, _textBoxDescription.Text);
            Tools4Libraries.Log.Happen(OFFLINE_ISSUES_FILE, text);
        }
        private static void ProcessOldIssues()
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
        private static void _buttonCancel_Click(object sender, EventArgs e)
        {
            _form.Close();
        }
        private static void _buttonReport_Click(object sender, EventArgs e)
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
            _form.Close();
        }
        private static void _textBoxDescription_Enter(object sender, EventArgs e)
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