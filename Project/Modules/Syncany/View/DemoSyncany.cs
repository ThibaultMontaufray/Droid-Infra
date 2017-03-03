using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools4Libraries;

namespace Droid_Infra
{
    public partial class DemoSyncany : Form
    {
        #region Attribute
        private Interface_syncany _intSyn;
        #endregion

        #region Properties
        #endregion

        #region Constuctor
        public DemoSyncany()
        {
            InitializeComponent();

            _intSyn = new Interface_syncany();
            cloudView1.InterficeSyncany = _intSyn;
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        #endregion

        #region Event
        #endregion
    }
}
