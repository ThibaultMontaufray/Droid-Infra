using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Droid.Infra.UI
{
    public partial class ComponentVPN : Component
    {
        #region Attributes
        private OpenVpnAdapterUI _adapter;
        #endregion

        #region Properties
        public OpenVpnAdapterUI Adapter
        {
            get { return _adapter; }
            set { _adapter = value; }
        }
        #endregion

        #region Constructor
        public ComponentVPN(OpenVpnAdapterUI adapter)
        {
            _adapter = adapter;
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public override void RefreshData()
        {
            labelProxy.Text = "Proxy : " + _adapter.Proxy;
            labelCurrent.Text = "Current : none";
            labelState.Text = "State : N/A";
        }
        #endregion

        #region Methods private
        private void Init()
        {

        }
        #endregion

        #region Event
        #endregion
    }
}
