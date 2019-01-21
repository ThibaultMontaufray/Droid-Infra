using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpBucket.V1.Pocos;
using Tools.Utilities;

namespace Droid.Infra.UI
{
    public delegate void ViewBitBucketSettingEventHandler(object o);
    public partial class ViewBitBucketSetting : UserControlCustom
    {
        #region Attributes
        public event ViewBitBucketLoginEventHandler RepoSelected;
        private BitbucketAdapter _bitbucketAdapter;
        #endregion

        #region Properties
        public BitbucketAdapter Adapter
        {
            get { return _bitbucketAdapter; }
            set { _bitbucketAdapter = value; }
        }
        #endregion

        #region Constructor
        public ViewBitBucketSetting()
        {
            InitializeComponent();
        }
        public ViewBitBucketSetting(BitbucketAdapter adapter)
        {
            _bitbucketAdapter = adapter;
            InitializeComponent();
        }
        #endregion

        #region Methods public
        public override void RefreshData()
        {
            if (_bitbucketAdapter.CurrentUser != null)
            {
                labelName.Text = _bitbucketAdapter.CurrentUser.Username;
                //pictureBox1.Load(_bitbucketAdapter.CurrentUser.avatar);
            }
            LoadRepo();
        }
        #endregion

        #region Methods private
        private void LoadRepo()
        {
            dataGridViewRepo.Rows.Clear();
            if (_bitbucketAdapter.Repositories != null)
            {
                var v = _bitbucketAdapter.Repositories;
                //foreach (Repository repo in _bitbucketAdapter.Repositories[0])
                //{
                //    dataGridViewRepo.Rows.Add();
                //    dataGridViewRepo.Rows[dataGridViewRepo.Rows.Count - 1].Tag = repo;
                //    dataGridViewRepo.Rows[dataGridViewRepo.Rows.Count - 1].Cells[ColumnName.Index].Value = repo.name;
                //    dataGridViewRepo.Rows[dataGridViewRepo.Rows.Count - 1].Cells[ColumnOwner.Index].Value = repo.owner;
                //    dataGridViewRepo.Rows[dataGridViewRepo.Rows.Count - 1].Cells[ColumnCreation.Index].Value = repo.created_on;
                //}
            }
            dataGridViewRepo.ClearSelection();
        }
        #endregion

        #region Event
        private void dataGridViewRepo_SelectionChanged(object sender, EventArgs e)
        {
            if (RepoSelected != null && dataGridViewRepo.SelectedRows.Count > 0)
            {
                RepoSelected(dataGridViewRepo.SelectedRows[0].Tag);
            }
        }
        #endregion
    }
}
