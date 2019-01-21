using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Droid.Communication;
using Tools.Utilities;
using CodeBucket.Client;
using CodeBucket.Client.V1;

namespace Droid.Infra.UI.Modules.Bitbucket.View
{
    public partial class RepoPanel : UserControlCustom
    {
        #region Attributes
        private BitbucketAdapter _adapter;
        #endregion

        #region Properties
        public BitbucketAdapter Adapter
        {
            get { return _adapter; }
            set { _adapter = value; }
        }
        #endregion

        #region Constructor
        public RepoPanel()
        {
            InitializeComponent();
            Init();
        }
        public RepoPanel(BitbucketAdapter adapter)
        {
            _adapter = adapter;
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public override void RefreshData()
        {
            if (_adapter != null & _adapter.CurrentRepo != null)
            {
                try
                {
                    if (_adapter.Branches != null)
                    {
                        LoadCommits(_adapter.Commits);
                    }
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
        }
        #endregion

        #region Methods private
        private void Init()
        {

        }
        private void LoadCommits(List<Commit> commits)
        {
            dataGridViewCommit.Rows.Clear();
            if (commits != null)
            { 
                foreach (var commit in commits)
                {
                    // hash 6a3e190a27e77f009ba4b166d3944447a3fe8cb9
                    // parent.hash ae6bf3b32a3c9d0e699c579998256c1000b9319c
                
                    Changeset cs = _adapter.GetCommitDetail(commit);
                
                    dataGridViewCommit.Rows.Add();
                    dataGridViewCommit.Rows[dataGridViewCommit.Rows.Count - 1].Cells[ColumnAge.Index].Value = GetAge(cs.Utctimestamp);
                    dataGridViewCommit.Rows[dataGridViewCommit.Rows.Count - 1].Cells[ColumnAuthor.Index].Value = cs.Author?.Split('<')[0];
                    dataGridViewCommit.Rows[dataGridViewCommit.Rows.Count - 1].Cells[ColumnDescription.Index].Value = cs.Message;
                    dataGridViewCommit.Rows[dataGridViewCommit.Rows.Count - 1].Cells[ColumnRevision.Index].Value = cs.Revision;
                    dataGridViewCommit.Rows[dataGridViewCommit.Rows.Count - 1].Cells[ColumnBranch.Index].Value = cs.Branch;
                    dataGridViewCommit.Rows[dataGridViewCommit.Rows.Count - 1].Tag = cs;
                }
            }
        }
        private string GetAge(DateTimeOffset date)
        {
            TimeSpan delay = DateTime.Now - date.DateTime;
            if (delay.TotalSeconds < 60) return delay.Seconds + " seconds";
            else if (delay.TotalMinutes < 60) return delay.Minutes + " minutes";
            else if (delay.TotalHours < 24) return delay.Hours + " hours";
            else if (delay.TotalDays < 7) return delay.Days + " days";
            else if (delay.TotalDays < 30) return delay.Days / 7 + " weeks";
            else return delay.Days / 30 + " month";
        }
        #endregion

        #region Event
        #endregion
    }
}
