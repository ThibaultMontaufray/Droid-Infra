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
    public delegate void ViewBitBucketRepositoryAddEventHandler();
    public partial class ViewBitBucketRepositoryAdd : UserControlCustom
    {
        #region Attributes
        public event ViewBitBucketRepositoryAddEventHandler CreationRequested;
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
        public ViewBitBucketRepositoryAdd()
        {
            InitializeComponent();
        }
        public ViewBitBucketRepositoryAdd(BitbucketAdapter adapter)
        {
            InitializeComponent();
            _adapter = adapter;
        }
        #endregion

        #region Methods public
        public new void RefreshData()
        {
            buttonAdd.Enabled = true;
            buttonTest.Enabled = true;
        }
        #endregion

        #region Methods private
        private void Test()
        {
            if (_adapter != null && _adapter.Client != null)
            {
                try
                {
                    var repo = _adapter.Client.Repositories.Get(textBoxName.Text, textBoxRepo.Text).Result;
                    labelStatus.Text = (repo != null) ? "Success" : "Failled";
                }
                catch (Exception)
                {
                    labelStatus.Text = "Failled";
                }
            }
        }
        private void Add()
        {
            if (_adapter != null && _adapter.Client != null)
            {
                try
                {
                    buttonAdd.Enabled = false;
                    buttonTest.Enabled = false;
                    Repository repo = _adapter.Client.Repositories.Get(textBoxName.Text, textBoxRepo.Text).Result;
                    _adapter.Repositories.Add(repo);
                    CreationRequested?.Invoke();
                }
                catch (Exception)
                {
                    labelStatus.Text = "Failled";
                    buttonAdd.Enabled = true;
                    buttonTest.Enabled = true;
                }
            }
        }
        #endregion

        #region Event
        private void buttonTest_Click(object sender, EventArgs e)
        {
            Test();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Add();
        }
        #endregion
    }
}
