using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using CodeBucket.Client;
using Tools.Utilities;
using CodeBucket.Client.V1;
using System.Management;

namespace Droid.Infra.UI
{
    public partial class ViewBitBucketRepository : UserControlCustom
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
        public ViewBitBucketRepository()
        {
            InitializeComponent();
            Init();
        }
        public ViewBitBucketRepository(BitbucketAdapter adapter)
        {
            _adapter = adapter;
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public override void RefreshData()
        {
            if (_adapter.CurrentRepo != null)
            {
                try
                {   
                    LoadBranches();
                    LoadData();
                }
                catch (TargetInvocationException exp)
                {
                    Console.WriteLine(exp.Message + " : " + exp.InnerException);
                }
            }
        }
        #endregion

        #region Methods private
        private void Init()
        {
        }
        private void LoadData()
        {
            labelTitle.Text = _adapter.CurrentRepo.Name;
            labelDescription.Text = _adapter.CurrentRepo.Description;
            labelCreatedOn.Text = _adapter.CurrentRepo.CreatedOn.ToString();
            labelUpdated.Text = _adapter.CurrentRepo.UpdatedOn.ToString();
            //labelLogo.Text = _adapter.CurrentRepo.logo;
            labelName.Text = _adapter.CurrentRepo.FullName;
            labelOwner.Text = _adapter.CurrentRepo.Owner.ToString();
            //labelReadOnly.Text = _adapter.CurrentRepo.read_only.ToString();
            labelSize.Text = _adapter.CurrentRepo.Size.ToString();
            labelState.Text = _adapter.CurrentRepo.HasIssues.ToString();
            labelWebsite.Text = _adapter.CurrentRepo.Website;
        }
        private void LoadBranches()
        {
            dataGridViewBranchs.Rows.Clear();
            
            if (_adapter.Branches != null)
            {
                foreach (var branch in _adapter.Branches)
                {
                    dataGridViewBranchs.Rows.Add();
                    dataGridViewBranchs.Rows[dataGridViewBranchs.Rows.Count - 1].Tag = branch;
                    dataGridViewBranchs.Rows[dataGridViewBranchs.Rows.Count - 1].Cells[ColumnName.Index].Value = branch.Name;
                    dataGridViewBranchs.Rows[dataGridViewBranchs.Rows.Count - 1].Cells[ColumnAuthor.Index].Value = branch.RawAuthor;
                    dataGridViewBranchs.Rows[dataGridViewBranchs.Rows.Count - 1].Cells[ColumnMessage.Index].Value = branch.Message;
                    dataGridViewBranchs.Rows[dataGridViewBranchs.Rows.Count - 1].Cells[ColumnFilesCount.Index].Value = branch.Files.Count;
                    dataGridViewBranchs.Rows[dataGridViewBranchs.Rows.Count - 1].Cells[ColumnNode.Index].Value = branch.RawNode;
                }
            }
        }
        #endregion

        #region Event
        #endregion
    }
}
