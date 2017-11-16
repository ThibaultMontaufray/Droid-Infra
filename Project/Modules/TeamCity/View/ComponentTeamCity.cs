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
    public partial class ComponentTeamCity : Component
    {
        #region Attributes
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public ComponentTeamCity()
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
            labelAgents.Text = "Actives agents : 0/0";
            labelQueue.Text = "Pending : 0";
            labelProjects.Text = "Projects : 0";
        }
        #endregion

        #region Event
        #endregion
    }
}
