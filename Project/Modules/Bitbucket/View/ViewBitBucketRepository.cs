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
using SharpBucket.V1.EndPoints;

namespace Droid_Infra
{
    public partial class ViewBitBucketRepository : UserControl
    {
        #region Attributes
        private BitbucketAdapter _bitbucketAdapter;
        private Repository _repo;
        private RepositoriesEndPoint _endPoint;
        private Dictionary<string, BranchInfo> _branches;
        #endregion

        #region Properties
        public BitbucketAdapter Adapter
        {
            get { return _bitbucketAdapter; }
            set { _bitbucketAdapter = value; }
        }
        #endregion

        #region Constructor
        public ViewBitBucketRepository()
        {
            InitializeComponent();
            Init();
        }
        public ViewBitBucketRepository(BitbucketAdapter adapter)
        {
            _bitbucketAdapter = adapter;
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public void LoadRepository(Repository repo)
        {
            _repo = repo;
            if (_repo != null)
            {
                _endPoint = _bitbucketAdapter.SharpBucket.RepositoriesEndPoint(_bitbucketAdapter.CurrentUser.username, _repo.name);
                object o = _endPoint.ListBranches();

                _branches = _endPoint.ListBranches();
                LoadBranches();
                LoadData();
            }
        }
        #endregion

        #region Methods private
        private void Init()
        {
            _branches = new Dictionary<string, BranchInfo>();
        }
        private void LoadData()
        {
            labelTitle.Text = _repo.name;
            labelDescription.Text = _repo.description;
            labelCreatedOn.Text = _repo.created_on;
            labelUpdated.Text = _repo.last_updated;
            labelLogo.Text = _repo.logo;
            labelName.Text = _repo.name;
            labelOwner.Text = _repo.owner;
            labelReadOnly.Text = _repo.read_only.ToString();
            labelSize.Text = _repo.size.ToString();
            labelState.Text = _repo.state;
            labelWebsite.Text = _repo.website;
        }
        private void LoadBranches()
        {
            dataGridViewBranchs.Rows.Clear();
            foreach (var branch in _branches)
            {
                dataGridViewBranchs.Rows.Add();
                dataGridViewBranchs.Rows[dataGridViewBranchs.Rows.Count - 1].Tag = branch;
                dataGridViewBranchs.Rows[dataGridViewBranchs.Rows.Count - 1].Cells[ColumnName.Index].Value = branch.Key;
                dataGridViewBranchs.Rows[dataGridViewBranchs.Rows.Count - 1].Cells[ColumnAuthor.Index].Value = branch.Value.author;
                dataGridViewBranchs.Rows[dataGridViewBranchs.Rows.Count - 1].Cells[ColumnMessage.Index].Value = branch.Value.message;
                dataGridViewBranchs.Rows[dataGridViewBranchs.Rows.Count - 1].Cells[ColumnFilesCount.Index].Value = branch.Value.files.Count;
                dataGridViewBranchs.Rows[dataGridViewBranchs.Rows.Count - 1].Cells[ColumnNode.Index].Value = branch.Value.node;
            }
        }
        #endregion

        #region Event
        #endregion
    }
}
