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
    public partial class ComponentComputer : Component
    {
        #region Attributes
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public ComponentComputer()
        {
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        private void Init()
        {
            labelDisk.Text = "Disk : 30% free";
            labelOs.Text = "OS : WS 2012 R2";
            labelRam.Text = "RAM : 4Go";
        }
        #endregion

        #region Event
        #endregion
    }
}
