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

namespace Droid.Infra.UI
{
    public delegate void ViewBitBucketLoginEventHandler(object o);
    public partial class ViewBitBucketLogin : UserControlCustom
    {
        #region Attributes
        public event ViewBitBucketLoginEventHandler ConnectionRequest;
        public event ViewBitBucketLoginEventHandler CancelRequest;
        private BitbucketAdapter _adapter;
        #endregion

        #region Properties
        public BitbucketAdapter Adapter
        {
            get { return _adapter; }
            set
            {
                _adapter = value;
                _adapter.ConnectionChanged += _adapter_ConnectionChanged;
                InvokeRefreshData();
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
            this._adapter = adapter;
            InitializeComponent();
        }
        #endregion

        #region Methods public
        public override void RefreshData()
        {
            try
            {
                if (_adapter != null)
                {
                    textBoxLogin.Text = _adapter.Login;
                    textBoxPassword.Text = _adapter.Password;
                }
                if (_adapter != null && _adapter.Online)
                {
                    labelStatus.Text = "Connected";
                    labelStatus.ForeColor = Color.DarkGreen;
                }
                else
                {
                    labelStatus.Text = "No connection";
                    labelStatus.ForeColor = Color.Maroon;
                }
                labelStatus.Visible = true;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
        #endregion

        #region Methods private
        private void Init()
        {
            if (_adapter != null)
            {
                textBoxLogin.Text = _adapter.Login;
                textBoxPassword.Text = _adapter.Password;
            }
        }
        #endregion

        #region Event
        private void _adapter_ConnectionChanged(object o)
        {
            InvokeRefreshData();
        }
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            ConnectionRequest?.Invoke(new string[2] { textBoxLogin.Text, textBoxPassword.Text });
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (CancelRequest != null) { CancelRequest(null); }
            labelStatus.Visible = false;
        }
        #endregion
    }
}
