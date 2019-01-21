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
using Droid.Infra.Modules.Docker.Model;
using Droid.Infra.Modules.Docker.Controler;

namespace Droid.Infra.UI.Modules.Docker.View
{
    public partial class ViewContainer : UserControlCustom
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
                RefreshData();
            }
        }
        #endregion

        #region Constructor
        public ViewContainer()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods public
        public override void RefreshData()
        {
            if (_adapter != null && _adapter.Engine != null)
            {
                _adapter.Engine.RefreshDataAsync();

                if (_adapter.Engine.CurrentMachine != null)
                {
                    _adapter.Engine.CurrentMachine = _adapter.Engine.CurrentMachine;

                    InitCombobox();
                    LoadContainer(_adapter.Engine.CurrentMachine.Containers);
                }
                else
                {
                    CleanContainer();
                }
            }
            else
            {
                CleanContainer();
            }
        }
        #endregion

        #region Methods private
        private void InitCombobox()
        {
            comboBoxImage.Items.Clear();
            comboBoxImage.Items.Add(string.Empty);
            foreach (var item in _adapter.Engine.CurrentMachine.Images)
            {
                comboBoxImage.Items.Add(item);
            }

            comboBoxNetwork.Items.Clear();
            comboBoxNetwork.Items.Add(string.Empty);
            foreach (var item in _adapter.Engine.CurrentMachine.Networks)
            {
                comboBoxNetwork.Items.Add(item);
            }
        }
        private void LoadContainer(List<Model.Container> Containers)
        {
            System.Drawing.Image icon;
            this.SuspendLayout();
            dataGridViewContainer.Rows.Clear();

            foreach (Model.Container Container in Containers)
            {
                icon = Container.DockerImage != null ? Droid.Image.Interface_image.ACTION_135_research_icon("icon " + Container.DockerImage.Replace("-oss", string.Empty)) : Properties.Resources.docker_container_small; ;
                dataGridViewContainer.Rows.Add();
                dataGridViewContainer.Rows[dataGridViewContainer.Rows.Count - 1].Cells[ColumnIcon.Index].Value = icon == null ?  Properties.Resources.docker_container_small : icon;
                dataGridViewContainer.Rows[dataGridViewContainer.Rows.Count - 1].Cells[ColumnId.Index].Value = Container.Id.Substring(0, 12);
                dataGridViewContainer.Rows[dataGridViewContainer.Rows.Count - 1].Cells[ColumnName.Index].Value = Container.Name;
                dataGridViewContainer.Rows[dataGridViewContainer.Rows.Count - 1].Cells[ColumnCommand.Index].Value = Container.Command;
                dataGridViewContainer.Rows[dataGridViewContainer.Rows.Count - 1].Cells[ColumnCreated.Index].Value = Container.Created;
                dataGridViewContainer.Rows[dataGridViewContainer.Rows.Count - 1].Cells[ColumnImage.Index].Value = Container.DockerImage;
                dataGridViewContainer.Rows[dataGridViewContainer.Rows.Count - 1].Cells[ColumnPort.Index].Value = Container.Port;
                dataGridViewContainer.Rows[dataGridViewContainer.Rows.Count - 1].Cells[ColumnStatus.Index].Value = Container.Status;
                dataGridViewContainer.Rows[dataGridViewContainer.Rows.Count - 1].Cells[ColumnDelete.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.cross;
                dataGridViewContainer.Rows[dataGridViewContainer.Rows.Count - 1].Cells[ColumnInspect.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.zoom;
                dataGridViewContainer.Rows[dataGridViewContainer.Rows.Count - 1].Height = 48;
                dataGridViewContainer.Rows[dataGridViewContainer.Rows.Count - 1].Tag = Container;
            }
            this.ResumeLayout();

        }
        private void CleanContainer()
        {
            this.SuspendLayout();
            dataGridViewContainer.Rows.Clear();
            this.ResumeLayout();
        }
        private void Delete(int rowIndex)
        {
            if (_adapter != null && _adapter.Engine != null && _adapter.Engine.CurrentMachine != null)
            {
                Model.Container v = _adapter.Engine.CurrentMachine.Containers.Where(c => c.Id == dataGridViewContainer.Rows[rowIndex].Cells[ColumnId.Index].Value?.ToString()).First();
                v?.Delete();
                RefreshData();
            }
        }
        private void Inspect(int rowIndex)
        {
        }
        private void CreateContainer()
        {
            if (comboBoxImage.SelectedItem != null)
            { 
                string command = "docker run";
                command += string.Format(" -p {0}:{1}", numericUpDownPortFrom.Value, numericUpDownPortTo.Value);
                if (!string.IsNullOrEmpty(textBoxName.Text)) { command += string.Format(" --name {0}", textBoxName.Text); }
                if (comboBoxNetwork.SelectedItem != null) { command += string.Format(" --network {0}", ((Network)(comboBoxNetwork.SelectedItem)).Name); }
                if (!string.IsNullOrEmpty(textBoxIp.Text)) { command += string.Format(" --ip {0}", textBoxIp.Text); }
                if (!string.IsNullOrEmpty(textBoxAlias.Text)) { command += string.Format(" --network-alias {0}", textBoxAlias.Text); }
                if (checkBoxRootRights.Checked) { command += " --privileged -e \"container = docker\" -v /sys/fs/cgroup:/sys/fs/cgroup"; }
                command += " -itd " + ((((Model.Image)comboBoxImage.SelectedItem).Repository != null) ? ((Model.Image)comboBoxImage.SelectedItem).Repository : ((Model.Image)comboBoxImage.SelectedItem).Id);
                command += string.IsNullOrEmpty(textBoxCommand.Text) ? "  /usr/sbin/init" : textBoxCommand.Text;
                
                if (_adapter != null && _adapter.Engine != null && _adapter.Engine.CurrentMachine != null)
                {
                    Model.Container c = new Model.Container();
                    c.Create(command);
                    RefreshData();
                }
            }
        }
        private void CleanFields()
        {
            checkBoxRootRights.Checked = false;
            textBoxAlias.Text = string.Empty;
            textBoxIp.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxCommand.Text = "/usr/sbin/init";
            comboBoxImage.SelectedIndex = 0;
            comboBoxNetwork.SelectedIndex = 0;
            numericUpDownPortFrom.Value = 80;
            numericUpDownPortTo.Value = 8081;
        }
        #endregion

        #region Event
        private void dataGridViewContainer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ColumnDelete.Index)
            {
                Delete(e.RowIndex);
            }
            else if (e.ColumnIndex == ColumnInspect.Index)
            {
                _adapter.CurrentContainer = dataGridViewContainer.Rows[e.RowIndex].Tag as Model.Container;
                _adapter.GoAction("inspectContainer");
            }
        }
        private void buttonCleanFIelds_Click(object sender, EventArgs e)
        {
            CleanFields();
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CreateContainer();
        }
        #endregion
    }
}
