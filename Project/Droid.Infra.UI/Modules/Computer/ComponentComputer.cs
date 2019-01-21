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
    public partial class ComponentComputer : Component
    {
        #region Attributes
        private ComputerAdapter _adapter;
        #endregion

        #region Properties
        public ComputerAdapter Adapter
        {
            get { return _adapter; }
            set { _adapter = value; }
        }
        #endregion

        #region Constructor
        public ComponentComputer(ComputerAdapter adapter)
        {
            _adapter = adapter;
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        private void Init()
        {
            if(labelDisk != null)
            { 
                labelDisk.Text = "Disk : " + _adapter.GetDiskOccupancyPercent(_adapter.GetDisks()[0].Name);
                labelOs.Text = "OS : " + _adapter.Os;
                labelRam.Text = "RAM : " + _adapter.RAM;
            }
        }
        #endregion

        #region Event
        #endregion
    }
}
