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
using Droid.Infra.Modules.YouTrack.Controler;

namespace Droid.Infra.UI.Modules.YouTrack.View
{
    public partial class ViewYoutrackConnect : UserControlCustom
    {
        #region Attributes
        private YoutrackAdapter _adapter;
        #endregion

        #region Properties
        public YoutrackAdapter Adapter
        {
            get { return _adapter; }
            set { _adapter = value; }
        }
        #endregion

        #region Constructor
        public ViewYoutrackConnect(YoutrackAdapter adapter)
        {
            _adapter = adapter;
            InitializeComponent();
            Init();
        }
        #endregion

        #region Mehtods public
        public override void RefreshData()
        {
            if (_adapter != null)
            {
                labelStatus.Text = "Status : checking ..";
                textBoxLogin.Text = _adapter.Login;
                textBoxPassword.Text = _adapter.Password;
                textBoxUrl.Text = _adapter.Url;
                bool b = _adapter.Online;
                labelStatus.Text = "Status : " + (b ? "connected" : "no connection");
            }
            else
            {
                textBoxLogin.Text = string.Empty;
                textBoxPassword.Text = string.Empty;
                textBoxUrl.Text = string.Empty;
                labelStatus.Text = "Status : unknow";
            }
        }
        #endregion

        #region Methods private
        private void Init()
        {
            RefreshData();
        }
        private async void Connect()
        {
            bool fieldsOk = true;

            if (string.IsNullOrEmpty(textBoxUrl.Text)) { textBoxUrl.BackColor = Color.LightYellow; fieldsOk = false; }
            else { textBoxUrl.BackColor = Color.White; }

            if (string.IsNullOrEmpty(textBoxPassword.Text)) { textBoxPassword.BackColor = Color.LightYellow; fieldsOk = false; }
            else { textBoxPassword.BackColor = Color.White; }

            if (string.IsNullOrEmpty(textBoxLogin.Text)) { textBoxLogin.BackColor = Color.LightYellow; fieldsOk = false; }
            else { textBoxLogin.BackColor = Color.White; }

            if (fieldsOk)
            {
                labelStatus.Text = "Status : checking ..";
                await Task.Run(() => {
                    _adapter.ACTION_connection(textBoxLogin.Text, textBoxPassword.Text, textBoxUrl.Text);
                    InvokeRefreshData();
                });
            }
            else { labelStatus.Text = "Status : N/A"; }
        }
        #endregion

        #region Event
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }
        #endregion
    }
}
