using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools.Utilities;
using YouTrackSharp.Issues;

namespace Droid.Infra.UI.Modules.YouTrack.View
{
    public partial class ViewYoutrackTicket : UserControlCustom
    {
        #region Attributes
        private Issue _currentIssue;
        #endregion

        #region Properties
        public Issue CurrentIssue
        {
            get { return _currentIssue; }
            set { _currentIssue = value; }
        }
        #endregion

        #region Constructor
        public ViewYoutrackTicket()
        {
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public override void RefreshData()
        {
            Panel p;
            if (_currentIssue != null)
            {
                //labelCreatedBy.Text = string.Format("Created by {0} {1}", _currentIssue.GetField("reporterFullName").Value, ((DateTime)_currentIssue.GetField("created").Value).ToString());
                //labelUpdatedBy.Text = string.Format("Updated by {0} {1}", "", "");
                labelCreatedBy.Text = string.Format("Created by {0}", _currentIssue.GetField("reporterFullName")?.Value);
                labelUpdatedBy.Text = string.Format("Updated by {0}", _currentIssue.GetField("updaterFullName")?.Value);
                labelUpdatedBy.Left = labelCreatedBy.Left + labelCreatedBy.Width + 10;
                labelTitle.Text = _currentIssue.Summary;
                textBoxDescription.Text = _currentIssue.Description;

                labelProjectValue.Text = _currentIssue.GetField("projectShortName")?.Value.ToString();
                comboBoxPriority = CreateCBPriority(((List<string>)((Issue)_currentIssue).GetField("Priority")?.Value)?[0]);
                comboBoxType = CreateCBType(((List<string>)((Issue)_currentIssue).GetField("Type")?.Value)?[0]);
                comboBoxState = CreateCBState(((List<string>)((Issue)_currentIssue).GetField("State")?.Value)?[0]);

                var assignees = (List<YouTrackSharp.Issues.Assignee>)((Issue)_currentIssue).GetField("Assignee")?.Value;
                labelAssigneeValue.Text = assignees?.Count > 0 ? (assignees)[0].FullName : string.Empty;
                var affectedVersion = (List<string>)((Issue)_currentIssue).GetField("Affected version")?.Value;
                string strAffectedVersion = string.Empty;
                if (affectedVersion != null)
                {
                    foreach (var item in affectedVersion)
                    {
                        strAffectedVersion += string.Format("[{0}]", item.ToString());
                    }
                }
                labelAffectedVersionValue.Text = strAffectedVersion;
            }
            else
            {
                labelCreatedBy.Text = "Created by ---";
                labelUpdatedBy.Text = "Updated by ---";
                labelTitle.Text = "NO DATA";
                textBoxDescription.Text = string.Empty;
            }
            RefreshDetails();
            if (_currentIssue?.Comments != null)
            { 
                foreach (var item in _currentIssue?.Comments)
                {
                    p = CreateComment(item);
                    panelMessages.Controls.Add(p);
                    panelMessages.Height += p.Height;
                    this.Height += p.Height;
                }
            }
        }
        #endregion

        #region Methods private
        private void Init()
        {
            RefreshData();
        }
        private void RefreshDetails()
        {
        }
        private Panel CreateComment(Comment comment)
        {
            Panel p = new Panel();

            p.Width = 891;
            p.Height = 50 + (25 * comment.Text.Split('\n').Count());
            p.Dock = DockStyle.Top;

            Label l1 = new Label();
            l1.BackColor = Color.Transparent;
            l1.Text = comment.AuthorFullName;
            l1.Top = 4;
            l1.Left = 4;
            p.Controls.Add(l1);

            Label l3 = new Label();
            l3.BackColor = Color.Transparent;
            l3.Text = comment.Created?.ToString();
            l3.Top = 4;
            l3.Left = 150;
            p.Controls.Add(l3);

            TextBox tb = new TextBox();
            tb.Text = comment.Text;
            tb.Top = 30;
            tb.Left = 4;
            tb.Multiline = true;
            tb.Width = p.Width - 15;
            tb.Height = 25 * comment.Text.Split('\n').Count();
            p.Controls.Add(tb);

            return p;
        }
        private ComboBox CreateCBPriority(object o)
        {
            ComboBox cb = new ComboBox();
            //cb.Items.Add(o.ToString());
            cb.Items.Add("a");
            cb.Items.Add("b");
            cb.Items.Add("c");
            cb.SelectedIndex = 0;
            return cb;
        }
        private ComboBox CreateCBType(object o)
        {
            ComboBox cb = new ComboBox();
            //cb.Items.Add(o.ToString());
            cb.Items.Add("a");
            cb.Items.Add("b");
            cb.Items.Add("c");
            cb.SelectedIndex = 0;
            return cb;
        }
        private ComboBox CreateCBState(object o)
        {
            ComboBox cb = new ComboBox();
            //cb.Items.Add(o.ToString());
            cb.Items.Add("a");
            cb.Items.Add("b");
            cb.Items.Add("c");
            cb.SelectedIndex = 0;
            return cb;
        }
        #endregion

        #region Event
        #endregion
    }
}
