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
using System.IO;
using Droid.Infra.Modules.Docker.Model;
using Droid.Infra.Modules.Docker.Controler;

namespace Droid.Infra.UI.Modules.Docker.View
{
    public partial class ViewDockerCompose : UserControlCustom
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
        public ViewDockerCompose()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods public
        public override void RefreshData()
        {
            dataGridViewCompose.Rows.Clear();
            if (_adapter != null && _adapter.Engine.DockerComposes != null)
            { 
                foreach (var item in _adapter.Engine.DockerComposes)
                {
                    dataGridViewCompose.Rows.Add();
                    dataGridViewCompose.Rows[dataGridViewCompose.Rows.Count - 1].Tag = item;
                    dataGridViewCompose.Rows[dataGridViewCompose.Rows.Count - 1].Cells[ColumnPath.Index].Value = item.CurrentDockerCompose?.Path;
                    dataGridViewCompose.Rows[dataGridViewCompose.Rows.Count - 1].Cells[ColumnStatus.Index].Value = item.Status;
                    dataGridViewCompose.Rows[dataGridViewCompose.Rows.Count - 1].Cells[ColumnIcon.Index].Value = Properties.Resources.docker_compose_small;
                    dataGridViewCompose.Rows[dataGridViewCompose.Rows.Count - 1].Cells[ColumnStop.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.control_play;
                    dataGridViewCompose.Rows[dataGridViewCompose.Rows.Count - 1].Cells[ColumnPause.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.control_pause;
                    dataGridViewCompose.Rows[dataGridViewCompose.Rows.Count - 1].Cells[ColumnDelete.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.cross;
                    dataGridViewCompose.Rows[dataGridViewCompose.Rows.Count - 1].Cells[ColumnInspect.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.zoom;
                }
            }
        }
        public override void ChangeLanguage()
        {
            base.ChangeLanguage();
        }
        #endregion

        #region Methods private
        private void Add()
        {
            if (!string.IsNullOrEmpty(textBoxPath.Text) && File.Exists(textBoxPath.Text))
            {
                textBoxPath.BackColor = Color.White;
                DockerComposeControler dcc = new DockerComposeControler(textBoxPath.Text);
                _adapter.Engine.DockerComposes.Add(dcc);
                RefreshData();
            }
            else
            {
                textBoxPath.BackColor = Color.LightYellow;
            }
        }
        private void Remove(DockerComposeControler dockCompose)
        {
            _adapter.Engine.DockerComposes.Remove(dockCompose);
            RefreshData();
        }
        private void Inspect(DockerComposeControler dockCompose)
        {
            _adapter.Engine.CurrentCompose = dockCompose;
            _adapter.Parent.GoAction("docker_composeInspect");
        }
        private void PlayPause(DockerComposeControler dockCompose)
        {
            _adapter.Engine.CurrentCompose = dockCompose;
            _adapter.Parent.GoAction("docker_composePlay");
            RefreshData();
        }
        private void Clear(DockerComposeControler dockCompose)
        {
            _adapter.Engine.CurrentCompose = dockCompose;
            _adapter.Parent.GoAction("docker_composeClear");
            RefreshData();
        }
        private void Stop(DockerComposeControler dockCompose)
        {
            _adapter.Engine.CurrentCompose = dockCompose;
            _adapter.Parent.GoAction("docker_composeStop");
            RefreshData();
        }
        private void Logs(DockerComposeControler dockCompose)
        {
            _adapter.Engine.CurrentCompose = dockCompose;
            _adapter.Parent.GoAction("docker_composeLogs");
        }
        #endregion

        #region Event
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Add();
        }
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "YML (*.yml)| *.yml|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = ofd.FileName;
            }
        }
        private void dataGridViewCompose_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ColumnDelete.Index)
            {
                Remove((DockerComposeControler)dataGridViewCompose.Rows[e.RowIndex].Tag);
            }
            else if (e.ColumnIndex == ColumnInspect.Index)
            {
                Inspect((DockerComposeControler)dataGridViewCompose.Rows[e.RowIndex].Tag);
            }
            else if (e.ColumnIndex == ColumnPause.Index)
            {
                PlayPause((DockerComposeControler)dataGridViewCompose.Rows[e.RowIndex].Tag);
            }
            else if (e.ColumnIndex == ColumnStop.Index)
            {
                Stop((DockerComposeControler)dataGridViewCompose.Rows[e.RowIndex].Tag);
            }
        }
        #endregion
    }
}
