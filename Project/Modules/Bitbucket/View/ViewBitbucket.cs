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
using SharpBucket.V1;
using SharpBucket.V1.Pocos;

namespace Droid_Infra
{
    public partial class ViewBitbucket : UserControlCustom
    {
        #region Attributes
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
        public ViewBitbucket(BitbucketAdapter adapter)
        {
            _bitbucketAdapter = adapter;
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        private void Init()
        {
            viewBitBucketLogin1.ConnectionRequest += ViewBitBucketLogin1_ConnectionRequest;
            viewBitBucketLogin1.CancelRequest += ViewBitBucketLogin1_CancelRequest;

            viewBitBucketUser1.RepoSelected += ViewBitBucketUser1_RepoSelected;

            viewBitBucketLogin1.Adapter = _bitbucketAdapter;
            viewBitBucketUser1.Adapter = _bitbucketAdapter;
            viewBitBucketRepository1.Adapter = _bitbucketAdapter;
        }
        private void LoadUser()
        {
            viewBitBucketUser1.LoadUser(_bitbucketAdapter.CurrentUser);
        }
        private void LoadRepo(Repository repo)
        {
            viewBitBucketRepository1.LoadRepository(repo);
        }
        #endregion

        #region Event
        private void ViewBitBucketLogin1_CancelRequest(object o)
        {
        }
        private void ViewBitBucketLogin1_ConnectionRequest(object o)
        {
            string[] connectionTab = o as string[];
            _bitbucketAdapter.Connect(connectionTab[0], connectionTab[1]);
            LoadUser();
        }
        private void ViewBitBucketUser1_RepoSelected(object o)
        {
            LoadRepo(o as Repository);
        }
        #endregion
    }
}
