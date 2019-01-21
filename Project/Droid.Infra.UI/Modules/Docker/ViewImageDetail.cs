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
    public partial class ViewImageDetail : UserControlCustom
    {
        #region Attributes
        private DockerAdapter _adapter;
        private Model.Image _image;
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
        public Model.Image CurrentImage
        {
            get { return _image; }
            set { _image = value; }
        }
        #endregion

        #region Constructor
        public ViewImageDetail()
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
                    string result = _adapter.Engine.CurrentMachine.InspectImage(_image);
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
