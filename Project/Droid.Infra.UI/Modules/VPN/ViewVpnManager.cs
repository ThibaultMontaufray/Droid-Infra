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

namespace Droid.Infra.UI.Modules.VPN.View
{
    public partial class ViewVpnManager : UserControlCustom
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
        public ViewVpnManager()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods public
        public override void ChangeLanguage()
        {
            base.ChangeLanguage();
        }
        public override void RefreshData()
        {
            base.RefreshData();
        }
        #endregion

        #region Methods private
        #endregion

        #region Event
        #endregion
    }
}
