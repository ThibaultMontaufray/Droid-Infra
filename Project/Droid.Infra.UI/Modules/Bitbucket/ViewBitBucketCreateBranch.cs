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
using CodeBucket.Client;

namespace Droid.Infra.UI.Modules.Bitbucket.View
{
    public partial class ViewBitBucketCreateBranch : UserControlCustom
    {
        #region Struct
        private struct CommitItem
        {
            public Commit value; 
            public override string ToString()
            {
                string s = string.Format("[{0}]\t\t", value.Date.ToString());
                s += " " + value.Message;
                return s;
            }
        }
        #endregion
        
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
        public ViewBitBucketCreateBranch()
        {
            InitializeComponent();
            Init();
        }
        public ViewBitBucketCreateBranch(BitbucketAdapter adapter)
        {
            _adapter = adapter;
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public override void RefreshData()
        {
            buttonGo.Enabled = true;
            comboBoxRevision.Items.Clear();
            comboBoxBranch.Items.Clear();

            if (_adapter != null && _adapter.Branches?.Count > 0)
            {
                foreach (var item in _adapter.Branches)
                {
                    comboBoxBranch.Items.Add(item.Name);
                }
                if (comboBoxBranch.Items.Count > 0) { comboBoxBranch.SelectedItem = comboBoxBranch.Items[0]; }
            }
        }
        #endregion

        #region Methods private
        private void Init()
        {
            RefreshData();
        }
        private void ReloadCommits()
        {
            comboBoxRevision.Items.Clear();
            if (comboBoxBranch.SelectedItem != null)
            { 
                var commits = _adapter.GetCommits(_adapter.CurrentRepo, comboBoxBranch.SelectedItem.ToString());
                foreach (var item in commits)
                {
                    CommitItem ci = new CommitItem() { value = item };
                    comboBoxRevision.Items.Add(ci);
                }
                comboBoxRevision.SelectedIndex = 1;
            }
        }
        #endregion

        #region Event
        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                textBoxName.BackColor = Color.LightYellow;
            }
            else
            {
                textBoxName.BackColor = Color.White;
                buttonGo.Enabled = false;
                Commit commit = ((CommitItem)comboBoxRevision.SelectedItem).value;
                _adapter?.CreateBranch(comboBoxBranch.SelectedText, commit, textBoxName.Text);
            }
        }
        private void comboBoxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadCommits();
        }
        #endregion
    }
}
