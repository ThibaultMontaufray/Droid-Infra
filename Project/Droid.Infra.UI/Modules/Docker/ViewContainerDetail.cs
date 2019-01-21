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

namespace Droid.Infra.UI.Modules.Docker.View
{
    public partial class ViewContainerDetail : UserControlCustom
    {
        #region Attributes
        private DockerAdapter _adapter;
        private Model.Container _container;
        #endregion

        #region Properties
        public DockerAdapter Adapter
        {
            get { return _adapter; }
            set
            {
                _adapter = value;
                RefreshData();
            }
        }
        public Model.Container CurrentContainer
        {
            get { return _container; }
            set { _container = value; }
        }
        #endregion

        #region Constructor
        public ViewContainerDetail()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        public override void RefreshData()
        {
            if (_adapter != null && _adapter.Engine != null)
            {
                _adapter.Engine.RefreshDataAsync();

                if (_adapter.Engine.CurrentMachine != null)
                {
                    string result = _adapter.Engine.CurrentMachine.InspectContainer(_container);
                    textBox1.Text = result;
                }
                else
                {
                    textBox1.Clear();
                }
            }
            else
            {
                textBox1.Clear();
            }
        }
        #endregion

        #region Event
        #endregion
    }
}
