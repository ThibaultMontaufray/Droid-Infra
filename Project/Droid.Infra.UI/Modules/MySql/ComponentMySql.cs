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
    public partial class ComponentMySql : Component
    {
        #region Attributes
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public ComponentMySql()
        {
            InitializeComponent();
            SetData();
        }
        #endregion

        #region Methods public
        public void SetData()
        {
            labelHost.Text = "Host : " + MysqlAdapter.Host;
            labelLogin.Text = "Login : " + MysqlAdapter.Login;
            labelConnected.Text = "Disconnected" + MysqlAdapter.IsConnected;
        }
        #endregion

        #region Methods private
        #endregion

        #region Event
        #endregion
    }
}
