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
    public partial class ComponentPostGre : Component
    {
        #region Attributes
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public ComponentPostGre()
        {
            InitializeComponent();
            SetData();
        }
        #endregion

        #region Methods public
        public void SetData()
        {
            //labelHost.Text = "Host : " + PostGreAdapter.Host;
            //labelLogin.Text = "Login : " + PostGreAdapter.Login;
            //labelConnected.Text = "Status : " + PostGreAdapter.IsConnected;
        }
        #endregion

        #region Methods private
        #endregion

        #region Event
        #endregion
    }
}
