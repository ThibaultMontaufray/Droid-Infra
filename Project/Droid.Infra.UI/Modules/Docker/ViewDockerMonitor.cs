using System.Collections.Generic;
using System.Windows.Forms;
using Tools.Utilities;
using Droid.Infra.Modules.Docker.Model;
using Droid.Infra.Modules.Docker.Controler;
using Droid.Infra.Modules.Docker.View;
using System.Threading.Tasks;
using System.Linq;
using System.Drawing;
using System;

namespace Droid.Infra.UI
{
    public partial class ViewDockerMonitor : UserControlCustom
    {
        #region Attributes
        private DockerAdapter _adapter;
        #endregion

        #region Properties
        public DockerAdapter Adapter
        {
            get { return _adapter; }
            set
            {
                _adapter = value;
                _adapter.Engine.DataRefreshed += Engine_DataRefreshed;
            }
        }
        #endregion

        #region Constructor
        public ViewDockerMonitor()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods public
        public override void RefreshData()
        {
            BuildAll();
        }
        #endregion

        #region Methods private
        private void BuildAll()
        {
            this.SuspendLayout();
            ComponentDockerMachine panelMachine;
            int left = 1;
            int top = 1;

            this.Width = 2;
            this.Height = 2;
            this.Controls.Clear();

            if (_adapter.Engine.Machines == null || _adapter.Engine.Machines.Count == 0)
            {
                this.Width = 500;
                this.Height = 200;
                this.BackColor = Color.Transparent;
                this.BackgroundImage = Properties.Resources.docker_dead;
                Label lbl = new Label()
                {
                    Text = "NO DATA",
                    BackColor = Color.Transparent,
                    ForeColor = Color.WhiteSmoke,
                    Top = 3,
                    Left = 215
                };
                this.Controls.Add(lbl);
            }
            else
            {
                this.BackColor = Color.Black;
                this.BackgroundImage = null;
                try
                {
                    foreach (var item in _adapter.Engine.Machines)
                    {
                        panelMachine = DrawMachine(item);
                        panelMachine.Top = top;
                        panelMachine.Left = left;
                        panelMachine.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top));

                        this.Controls.Add(panelMachine);
                        top += panelMachine.Height + 4;
                        this.Height = top;
                        if (this.Width < panelMachine.Width + 2) { this.Width = panelMachine.Width + 2; }
                    }
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            this.ResumeLayout();
        }
        private ComponentDockerMachine DrawMachine(Machine machine)
        {
            ComponentDockerMachine panelMachine = new ComponentDockerMachine();
            panelMachine.Machine = machine;
            return panelMachine;
        }
        #endregion

        #region Event
        private void Engine_DataRefreshed(object o)
        {
            InvokeRefreshData();
        }
        #endregion
    }
}
