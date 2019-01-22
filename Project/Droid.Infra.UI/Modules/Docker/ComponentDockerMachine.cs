using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Droid.Infra.UI.Modules.Docker.View
{
    public partial class ComponentDockerMachine : Component
    {
        #region Attributes
        private Machine _machine;
        private delegate void RefreshDataDelegate();
        #endregion

        #region Properties
        public Machine Machine
        {
            get { return _machine; }
            set
            {
                if (_machine != null) { _machine.MachineUpdated -= _machine_MachineUpdated; }
                _machine = value;
                _machine.MachineUpdated += _machine_MachineUpdated;
                RefreshData();
            }
        }
        #endregion

        #region Constructor
        public ComponentDockerMachine()
        {
            InitializeComponent();
        }
        public ComponentDockerMachine(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        #endregion

        #region Methods public
        public new void RefreshData()
        {
            buttonStartStop.Enabled = true;
            string address = (!string.IsNullOrEmpty(_machine.URL) && _machine.URL.Split('/').Length > 1) ? _machine.URL.Split('/')[1] : _machine.URL;
            labelMachineName.Text = _machine.Name;
            labelDetail.Text = _machine.State + (!string.IsNullOrEmpty(address) ? (Environment.NewLine + address) : string.Empty);
            buttonStartStop.BackgroundImage = _machine.State.Equals("Running") ? Tools.Utilities.UI.Resources.ResourceIconSet32Default.control_stop : Tools.Utilities.UI.Resources.ResourceIconSet32Default.control_play;

            BuildMachinePreview();
        }
        #endregion

        #region Methods private
        private async void StartStop()
        {
            buttonStartStop.Enabled = false;
            buttonStartStop.BackgroundImage = Tools.Utilities.UI.Resources.ResourceIconSet32Default.time;
            if (_machine.State.Equals("Running")) { _machine.Stop(); }
            else { _machine.Start(); }
            await Task.Run(() => _machine.RefreshData());
        }
        private void BuildMachinePreview()
        {
            int objectPerRow = 5;
            int objectRowCount = 0;
            ToolTip toolTip1;
            ComponentDockerImage panelImage;
            int left = 4;
            int top = 36;
            int addHeight = 0;

            if (_machine != null)
            {
                foreach (var item in _machine.Images)
                {
                    panelImage = DrawImage(_machine, item);
                    panelImage.Top = top;
                    panelImage.Left = left;
                    this.Controls.RemoveByKey(item.Id);

                    this.Controls.Add(panelImage);

                    toolTip1 = new ToolTip();
                    toolTip1.AutoPopDelay = 5000;
                    toolTip1.InitialDelay = 1000;
                    toolTip1.ReshowDelay = 500;
                    toolTip1.ShowAlways = true;
                    toolTip1.SetToolTip(panelImage, item.Repository);
                    objectRowCount++;
                    //if (panelImage.Width + 4 > maxWidth) { maxWidth = panelImage.Width + panelMachine.Width; }
                    if (objectRowCount >= objectPerRow)
                    {
                        objectRowCount = 0;
                        top += panelImage.Height + 2;
                        left = 4;
                        addHeight = 0;
                    }
                    else
                    {
                        addHeight = panelImage.Height;
                        left += panelImage.Width + 2;
                    }
                }
            }
            this.Height = top + addHeight + 4;
            this.Width = 764;

        }
        private ComponentDockerImage DrawImage(Machine machine, Modules.Docker.Model.Image image)
        {
            ToolTip toolTip1;
            ComponentDockerContainer panelContainer;
            ComponentDockerImage panelImage = new ComponentDockerImage();
            panelImage.Image = image;
            int left = 120;
            int top = panelImage.Height / 2;

            foreach (var item in machine.Containers.Where(c => c.DockerImage == image.Repository))
            {
                panelContainer = new ComponentDockerContainer();
                panelContainer.Name = item.Name;
                panelContainer.Top = top;
                panelContainer.Left = left;
                panelContainer.DockerContainer = item;
                panelContainer.RefreshData();

                toolTip1 = new ToolTip();
                toolTip1.AutoPopDelay = 5000;
                toolTip1.InitialDelay = 1000;
                toolTip1.ReshowDelay = 500;
                toolTip1.ShowAlways = true;
                toolTip1.SetToolTip(panelContainer, item.Name);

                panelImage.Controls.Add(panelContainer);
                left += panelContainer.Width + 10;
            }
            panelImage.Height = 65;
            return panelImage;
        }
        #endregion

        #region Event
        private void _machine_MachineUpdated()
        {
            this.Invoke(new RefreshDataDelegate(RefreshData));
        }
        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            StartStop();
        }
        #endregion
    }
}
