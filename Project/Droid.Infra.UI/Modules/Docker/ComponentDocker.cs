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
    public partial class ComponentDocker : Component
    {
        #region Attributes
        private DockerAdapter _adapter;
        #endregion

        #region Properties
        public DockerAdapter Adapter
        {
            get { return _adapter; }
            set { _adapter = value; }
        }
        #endregion

        #region Constructor
        public ComponentDocker(DockerAdapter adapter)
        {
            _adapter = adapter;
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public override void RefreshData()
        {
            labelMachines.Text = "Machines : " + _adapter.Engine.Machines.Count();
            labelCurrent.Text = "Current : " + (_adapter.Engine.CurrentMachine != null ? _adapter.Engine.CurrentMachine.Name : "None");
            labelState.Text = "State : " + (_adapter.Engine.CurrentMachine != null ? _adapter.Engine.CurrentMachine.State : "N/A");
            labelIp.Text = (_adapter.Engine.CurrentMachine != null ? _adapter.Engine.CurrentMachine.URL.Replace("tcp://", string.Empty).Split(':')[0] : "IP : N/A");
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
