using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools4Libraries;

namespace Droid_Infra
{
    public partial class GithubManage : UserControlCustom
    {
        #region Attribute
        #endregion

        #region Properties
        #endregion

        #region Constructor
        private Interface_infra _intInf;
        #endregion

        #region Methods public
        public GithubManage()
        {
            InitializeComponent();
            Init();
        }
        public GithubManage(Interface_infra intInf)
        {
            _intInf = intInf;

            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods private
        private void Init()
        {
            var v1 = _intInf.GitHubAdapter.GetUserRepo();
            LoadIssues();
        }
        private void LoadIssues()
        {
            DataGridViewRow row;

            var issues = _intInf.GitHubAdapter.GetUserIssues();
            dataGridViewIssues.Rows.Clear();
            if (issues != null)
            { 
                foreach (var issue in issues)
                {
                    dataGridViewIssues.Rows.Add();
                    row = dataGridViewIssues.Rows[dataGridViewIssues.Rows.Count - 1];
                    row.Cells[ColumnId.Index].Value = issue.Id;
                    row.Cells[ColumnTitle.Index].Value = issue.Title;
                    row.Cells[ColumnMilestone.Index].Value = issue.Milestone;
                    row.Cells[ColumnRepository.Index].Value = issue.Repository;
                    row.Cells[ColumnDescription.Index].Value = issue.Body;
                }
            }

            this.Height = 48 + (dataGridViewIssues.Rows.Count * 24);
        }
        #endregion

        #region Event
        #endregion
    }
}
