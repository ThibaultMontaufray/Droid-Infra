using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Droid_Infra
{
    public delegate void ViewBitBucketLoginEventHandler(object o);
    public partial class ViewBitBucketLogin : UserControl
    {
        #region Attributes
        public event ViewBitBucketLoginEventHandler ConnectionRequest;
        public event ViewBitBucketLoginEventHandler CancelRequest;
        private BitbucketAdapter _bitbucketAdapter;
        #endregion

        #region Properties
        public BitbucketAdapter Adapter
        {
            get { return _bitbucketAdapter; }
            set
            {
                _bitbucketAdapter = value;
                Init();
            }
        }
        #endregion

        #region Constructor
        [Obsolete]
        public ViewBitBucketLogin()
        {
            InitializeComponent();
        }
        public ViewBitBucketLogin(BitbucketAdapter adapter)
        {
            _bitbucketAdapter = adapter;
            InitializeComponent();
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        private void Init()
        {
            if (_bitbucketAdapter != null)
            {
                _bitbucketAdapter.ConnectionChanged += _bitbucketAdapter_ConnectionChanged;
                textBoxLogin.Text = _bitbucketAdapter.Login;
                textBoxPassword.Text = _bitbucketAdapter.Password;
            }
        }
        private void UpdateStatus()
        {
            if (_bitbucketAdapter != null && _bitbucketAdapter.Connected)
            {
                labelStatus.Text = "Connected";
                labelStatus.ForeColor = Color.GreenYellow;
            }
            else
            { 
                labelStatus.Text = "No connection";
                labelStatus.ForeColor = Color.Yellow;
            }
            labelStatus.Visible = true;
        }
        #endregion

        #region Event
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (ConnectionRequest != null)
            { 
                string[] s = new string[2] { textBoxLogin.Text, textBoxPassword.Text };
                ConnectionRequest(s);
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (CancelRequest != null) { CancelRequest(null); }
            labelStatus.Visible = false;
        }
        private void _bitbucketAdapter_ConnectionChanged(object o)
        {
            UpdateStatus();
        }
        #endregion
    }
}
