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
    public partial class ComponentSonar : Component
    {
        #region Attributes
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public ComponentSonar()
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
            labelProjects.Text = "Projects : 0";
        }
        #endregion

        #region Event
        #endregion
    }
}
