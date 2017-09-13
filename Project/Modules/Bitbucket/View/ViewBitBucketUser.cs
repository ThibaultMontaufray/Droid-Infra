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

namespace Droid_Infra
{
    public delegate void ViewBitBucketUserEventHandler(object o);
    public partial class ViewBitBucketUser : UserControl
    {
        #region Attributes
        public event ViewBitBucketLoginEventHandler RepoSelected;

        private BitbucketAdapter _bitbucketAdapter;
        private User _user;
        #endregion

        #region Properties
        public BitbucketAdapter Adapter
        {
            get { return _bitbucketAdapter; }
            set { _bitbucketAdapter = value; }
        }
        #endregion

        #region Constructor
        public ViewBitBucketUser()
        {
            InitializeComponent();
        }
        public ViewBitBucketUser(BitbucketAdapter adapter)
        {
            _bitbucketAdapter = adapter;
            InitializeComponent();
        }
        #endregion

        #region Methods public
        public void LoadUser(User user)
        {
            _user = user;
            LoadData();
        }
        #endregion

        #region Methods private
        private void LoadData()
        {
            if (_user != null)
            {
                labelName.Text = _user.display_name;
                pictureBox1.Load(_user.avatar);
            }
            LoadRepo();
        }
        private void LoadRepo()
        {
            dataGridViewRepo.Rows.Clear();
            if (_bitbucketAdapter.Repositories != null)
            { 
                foreach (Repository repo in _bitbucketAdapter.Repositories)
                {
                    dataGridViewRepo.Rows.Add();
                    dataGridViewRepo.Rows[dataGridViewRepo.Rows.Count - 1].Tag = repo;
                    dataGridViewRepo.Rows[dataGridViewRepo.Rows.Count - 1].Cells[ColumnName.Index].Value = repo.name;
                    dataGridViewRepo.Rows[dataGridViewRepo.Rows.Count - 1].Cells[ColumnOwner.Index].Value = repo.owner;
                    dataGridViewRepo.Rows[dataGridViewRepo.Rows.Count - 1].Cells[ColumnCreation.Index].Value = repo.created_on;
                }
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
