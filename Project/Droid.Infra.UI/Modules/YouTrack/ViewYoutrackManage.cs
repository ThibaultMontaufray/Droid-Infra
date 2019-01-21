using System;
using Tools.Utilities;
using YouTrackSharp.Projects;
using YouTrackSharp.Issues;
using Droid.Infra.Modules.YouTrack.Controler;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Globalization;
using System.Data;
using System.Windows.Forms;

namespace Droid.Infra.UI.Modules.YouTrack.View
{
    public partial class ViewYoutrackManage : UserControlCustom
    {
        #region Attributes
        private const int COLPRIORITY = 0;
        private const int COLID = 1;
        private const int COLTITLE = 2;
        private const int COLTAG = 3;
        private const int COLASSIGNEE = 4;
        private const int COLINSPECT = 5;
        private const int COLOBJECT = 6;
        private YoutrackAdapter _adapter;
        #endregion

        #region Properties
        public YoutrackAdapter Adapter
        {
            get { return _adapter; }
            set
            {
                _adapter = value;
                Init();
            }
        }
        #endregion

        #region Constructor
        public ViewYoutrackManage()
        {
            InitializeComponent();
        }
        #endregion

        #region Mehtods public
        public override void RefreshData()
        {
            _adapter.RefreshDataAsync();

            RefreshProject(_adapter.Projects);
            if (_adapter.Projects.Count > 0)
            { 
                RefreshIssues(_adapter.Issues, _adapter.Projects[0].Name);
            }
        }
        #endregion

        #region Methods private
        private void Init()
        {
            if (_adapter != null)
            {
                InvokeRefreshData();
            }
        }
        private void RefreshProject(List<Project> projects)
        {
            _dataGridViewProjects.Rows.Clear();
            foreach (var item in projects)
            {
                _dataGridViewProjects.Rows.Add();
                _dataGridViewProjects.Rows[_dataGridViewProjects.Rows.Count - 1].Cells[ColumnName.Index].Value = item.Name;
                _dataGridViewProjects.Rows[_dataGridViewProjects.Rows.Count - 1].Tag = item;
            }
        }
        DataTable datatable;
        private void RefreshIssues(List<Issue> issues, string project)
        {
            if (issues.Count == 0) return;

            string prio;
            string tagStr;
            //_superGridViewIssues.Rows.Clear();
            datatable = new DataTable();
            //if (datatable != null) { datatable.Clear(); }
            //else { datatable = new DataTable(); }
            //datatable.TableName = project;
            datatable.Columns.Clear();
            DataColumn dc = new DataColumn();
            dc.DataType = typeof(string);

            datatable.Columns.Add("Priority", typeof(string));
            datatable.Columns.Add("Id", typeof(string));
            datatable.Columns.Add("Title", typeof(string));
            datatable.Columns.Add("Tags", typeof(string));
            datatable.Columns.Add("Assignee", typeof(string));
            datatable.Columns.Add("Inspect", typeof(System.Drawing.Image));
            datatable.Columns.Add("Object", typeof(Issue));
            foreach (var item in issues)
            {
                //_superGridViewIssues.Rows.Add();

                tagStr = string.Empty;

                foreach (var tag in item.Tags)
                {
                    tagStr += string.Format("[{0}]", tag.Value);
                }
                prio = "Normal";
                try
                {
                    prio = ((List<string>)((Issue)item).GetField("Priority").Value)[0];
                }
                catch (Exception)
                {
                }
                string assignees = string.Empty;
                if (item.GetField("Assignee")?.Value != null)
                {
                    foreach (var ass in ((List<Assignee>)item.GetField("Assignee").Value))
                    {
                        assignees += string.Format("{0} ", ass.FullName);
                    }
                }

                datatable.Rows.Add(prio, item.Id, item.Summary, tagStr, assignees, Tools4Libraries.Resources.ResourceIconSet16Default.eye, item);
                //_superGridViewIssues.Rows[_superGridViewIssues.Rows.Count - 1].Cells[ColumnPriority.Index].Style.ForeColor = ColorTranslator.FromHtml(((Issue)item).GetField("Priority").Color.Foreground ?? "#000000");
                //_superGridViewIssues.Rows[_superGridViewIssues.Rows.Count - 1].Cells[ColumnPriority.Index].Style.BackColor = ColorTranslator.FromHtml(((Issue)item).GetField("Priority").Color.Background ?? "#FFFFFF");
                //_superGridViewIssues.Rows[_superGridViewIssues.Rows.Count - 1].Cells[ColumnPriority.Index].Value = prio;
                //_superGridViewIssues.Rows[_superGridViewIssues.Rows.Count - 1].Cells[ColumnId.Index].Value = item.Id;
                //_superGridViewIssues.Rows[_superGridViewIssues.Rows.Count - 1].Cells[ColumnTags.Index].Value = tagStr;
                //_superGridViewIssues.Rows[_superGridViewIssues.Rows.Count - 1].Cells[ColumnTitle.Index].Value = item.Summary;
                //_superGridViewIssues.Rows[_superGridViewIssues.Rows.Count - 1].Cells[ColumnInspect.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.eye;
                //_superGridViewIssues.Rows[_superGridViewIssues.Rows.Count - 1].Tag = item;
            }
            //_superGridViewIssues.Sort(ColumnPriority, System.ComponentModel.ListSortDirection.Ascending);
            _superGridViewIssues.PageSize = 5;

            if (ds == null) { ds = new DataSet(); }
            if (!ds.Tables.Contains(datatable.TableName)) { ds.Tables.Add(datatable); }
            customersBindingSource = new BindingSource();
            this.customersBindingSource.DataSource = ds.Tables["Table4"];
            customersBindingNavigator = new BindingNavigator(true);

            this.customersBindingNavigator.BindingSource = this.customersBindingSource;
            this.customersBindingNavigator.Dock = DockStyle.Top;
            panelFooter.Controls.Clear();
            panelFooter.Controls.Add(this.customersBindingNavigator);
            
            _superGridViewIssues.SetPagedDataSource(datatable, customersBindingNavigator);
            //_superGridViewIssues.Columns[COLPRIORITY].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //_superGridViewIssues.Columns[COLID].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //_superGridViewIssues.Columns[COLTITLE].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //_superGridViewIssues.Columns[COLTAG].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //_superGridViewIssues.Columns[COLASSIGNEE].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //_superGridViewIssues.Columns[COLINSPECT].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //_superGridViewIssues.Columns[COLOBJECT].Visible = false;
        }
        DataSet ds;
        BindingSource customersBindingSource;
        BindingNavigator customersBindingNavigator;
        private async void UpdateIssues(Project project)
        {
            if (project != null)
            { 
                var issues = await _adapter.GetProjectIssues(project);
                RefreshIssues(issues, project.Name);
            }
        }
        #endregion

        #region Event
        private void _dataGridViewProjects_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            Project project = (Project)_dataGridViewProjects.Rows[e.RowIndex].Tag;
            UpdateIssues(project);
        }
        private void _dataGridViewIssues_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == COLINSPECT)
            {
                _adapter.CurrentIssue = (Issue)_superGridViewIssues.Rows[e.RowIndex].Tag;
                _adapter.GoAction("inspect");
            }
        }
        #endregion
    }
}
