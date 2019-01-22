using System;
using Tools.Utilities;
using Docker;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;

namespace Droid.Infra.UI
{
    public partial class ViewDockerManage : UserControlCustom
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
                InitViewDockerManage();
            }
        }
        #endregion

        #region Constructor
        public ViewDockerManage()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        private void InitViewDockerManage()
        {
            if (_adapter != null && _adapter.Engine != null)
            {
                RefreshDockerData();
            }
        }
        private void RefreshDockerData()
        {
            //Task t = new Task(() => {
            _adapter.Engine.RefreshDataAsync();
            labelDMStatus.Text = _adapter.Engine.Status;
            labelDMVersion.Text = _adapter.Engine.Version;
            labelDMIp.Text = "Docker machine ip : " + _adapter.Engine.Ip;
            labelDMActive.Text = "Activated machine : " + _adapter.Engine.CurrentMachine?.Name;

            this.SuspendLayout();
            dataGridViewMachines.Rows.Clear();

            try
            {
                foreach (Machine machine in _adapter.Engine.Machines)
                {
                    dataGridViewMachines.Rows.Add();
                    dataGridViewMachines.Rows[dataGridViewMachines.Rows.Count - 1].Cells[ColumnName.Index].Value = machine.Name;
                    dataGridViewMachines.Rows[dataGridViewMachines.Rows.Count - 1].Cells[ColumnDriver.Index].Value = machine.DriverName;
                    dataGridViewMachines.Rows[dataGridViewMachines.Rows.Count - 1].Cells[ColumnDocker.Index].Value = machine.ConfigVersion;
                    dataGridViewMachines.Rows[dataGridViewMachines.Rows.Count - 1].Cells[ColumnDelete.Index].Value = Tools.Utilities.UI.Resources.ResourceIconSet16Default.cross;
                    dataGridViewMachines.Rows[dataGridViewMachines.Rows.Count - 1].Cells[ColumnInspect.Index].Value = Tools.Utilities.UI.Resources.ResourceIconSet16Default.zoom;
                    dataGridViewMachines.Rows[dataGridViewMachines.Rows.Count - 1].Cells[ColumnResetEnv.Index].Value = Tools.Utilities.UI.Resources.ResourceIconSet16Default.table_refresh;
                    dataGridViewMachines.Rows[dataGridViewMachines.Rows.Count - 1].Cells[ColumnRegenerateCert.Index].Value = Tools.Utilities.UI.Resources.ResourceIconSet16Default.ssl_certificates;
                    dataGridViewMachines.Rows[dataGridViewMachines.Rows.Count - 1].Cells[ColumnActive.Index].Value = (_adapter.Engine.CurrentMachine != null && _adapter.Engine.CurrentMachine.Name.Equals(machine.Name)) ? Tools.Utilities.UI.Resources.ResourceIconSet16Default.cog_go : Tools.Utilities.UI.Resources.ResourceIconSet16Default.cog_delete;
                    dataGridViewMachines.Rows[dataGridViewMachines.Rows.Count - 1].Cells[ColumnStartStop.Index].Value = machine.State == "Running" ? Tools.Utilities.UI.Resources.ResourceIconSet16Default.control_pause : Tools.Utilities.UI.Resources.ResourceIconSet16Default.control_play;
                    switch (machine.State)
                    {
                        case "Running":
                            dataGridViewMachines.Rows[dataGridViewMachines.Rows.Count - 1].Cells[ColumnState.Index].Value = Tools.Utilities.UI.Resources.ResourceIconSet16Default.bullet_green;
                            break;
                        case "Stopped":
                            dataGridViewMachines.Rows[dataGridViewMachines.Rows.Count - 1].Cells[ColumnState.Index].Value = Tools.Utilities.UI.Resources.ResourceIconSet16Default.bullet_red;
                            break;
                        case "Timeout":
                            dataGridViewMachines.Rows[dataGridViewMachines.Rows.Count - 1].Cells[ColumnState.Index].Value = Tools.Utilities.UI.Resources.ResourceIconSet16Default.bullet_black;
                            break;
                        default:
                            dataGridViewMachines.Rows[dataGridViewMachines.Rows.Count - 1].Cells[ColumnState.Index].Value = Tools.Utilities.UI.Resources.ResourceIconSet16Default.bullet_orange;
                            break;
                    }
                }
            }
            catch (Exception)
            {

            }
            buttonStart.Text = _adapter.Engine.Status.StartsWith("Running") ? "Stop" : "Start";
            this.ResumeLayout();

            if (dataGridViewMachines.Rows.Count > 0) { LoadMachine(dataGridViewMachines.Rows[0].Cells[ColumnName.Index].Value.ToString()); }
            else { CleanMachines(); }
            //});
            //return t;
        }
        private void LoadMachine(string machineName)
        {
            if (!string.IsNullOrEmpty(machineName))
            { 
                Machine machine = _adapter.Engine.Machines.Where(m => m.Name.Equals(machineName)).FirstOrDefault();
                if (machine != null)
                {
                    labelMachineName.Text = "Name : " + machine.Name;
                    labelConfigVersion.Text = "Version : " + machine.ConfigVersion;
                    labelLastStatus.Text = "Status : " + machine.State;
                    labelPath.Text = "Path : " + machine.StorePath;
                    labelDriverIp.Text = "Driver ip : " + machine.Driver.IP + ":" + machine.Driver.SshPort;
                    labelDriverUser.Text = "Driver user : " + machine.Driver.SshUser;
                    labelDriverCpu.Text = "Driver cpu : " + machine.Driver.Cpu;
                    labelDriverSize.Text = "Driver size : " + machine.Driver.Cpu;
                    labelHost.Text = "Host : " + machine.Host.Engine.ToString();
                    labelHostRam.Text = "Ram : " + machine.Host.Ram.ToString();
                    labelHostDisk.Text = "Disk : " + machine.Host.Disk.ToString();
                    lableHostSwarmUrl.Text = "Swarm : " + machine.Host.Swarm.URL;
                    labelHostEngine.Text = "Engine : " + machine.Host.Engine.ToString();
                }
            }
        }
        private void CleanMachines()
        {
            labelMachineName.Text = "Name : ";
            labelConfigVersion.Text = "Version : ";
            labelLastStatus.Text = "Status : ";
            labelPath.Text = "Path : ";
            labelDriverIp.Text = "Driver ip : ";
            labelDriverUser.Text = "Driver user : ";
            labelDriverCpu.Text = "Driver cpu : ";
            labelDriverSize.Text = "Driver size : ";
            labelHost.Text = "Host : ";
            labelHostRam.Text = "Ram : ";
            labelHostDisk.Text = "Disk : ";
            lableHostSwarmUrl.Text = "Swarm : ";
            labelHostEngine.Text = "Engine : ";
        }
        private async void ComputeMachineStopStart()
        {
            buttonStart.Text = _adapter.Engine.Status.StartsWith("Running") ? "Stopping .." : "Starting ..";
            buttonStart.Enabled = false;
            await Task.Run(() => {
                if (_adapter.Engine.Status.StartsWith("Running")) { _adapter.Engine.CurrentMachine.Stop(); }
                else { _adapter.Engine.CurrentMachine.Start(); }
            });
            buttonStart.Enabled = true;
            RefreshDockerData();
        }
        private async void DeleteMachine(string machineName)
        {
            if (MessageBox.Show(string.Format("Are you sure to delete \"{0}\" docker machine ?", machineName), "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                await Task.Run(() =>
                {
                    _adapter.Engine.Machines.Where(m => m.Name == machineName).First()?.Delete();
                });
                RefreshDockerData();
            }
        }
        private void InspectMachine(string machineName)
        {

        }
        private async void StopStartMachine(string machineName)
        {
            var machines = _adapter.Engine.Machines.Where(m => m.Name.Equals(machineName)).ToList();
            await Task.Run(() => {
                if (machines.Count == 1)
                {
                    if (machines[0].State == "Running")
                    {
                        _adapter.Engine.Machines.Where(m => m.Name == machineName).First()?.Stop();
                    }
                    else
                    {
                        _adapter.Engine.Machines.Where(m => m.Name == machineName).First()?.Start();
                    }
                }
            });
            RefreshDockerData();
        }
        private async void ChangeActiveMachine(string machineName)
        {
            await Task.Run(() =>
            {
                _adapter.Engine.CurrentMachine = _adapter.Engine.Machines.Where(m => m.Name.Equals(machineName)).First();
            });
            RefreshDockerData();
        }
        private async void RegenerateCert(string machineName)
        {
            await Task.Run(() =>
            {
                _adapter.Engine.Machines.Where(m => m.Name == machineName).First()?.RegenerateCert();
            });
            RefreshDockerData();
        }
        private async void ResetEnv(string machineName)
        {
            await Task.Run(() =>
            {
                _adapter.Engine.Machines.Where(m => m.Name == machineName).First()?.DisplayEnvVar();
            });
            RefreshDockerData();
        }
        #endregion

        #region Event
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            ComputeMachineStopStart();
        }
        private void dataGridViewMachines_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMachines.Rows.Count > 0)
            {
                if (dataGridViewMachines.SelectedRows.Count > 0)
                { 
                    LoadMachine(dataGridViewMachines.SelectedRows[0].Cells[ColumnName.Index].Value?.ToString());
                }
                else
                {
                    LoadMachine(dataGridViewMachines.Rows[0].Cells[ColumnName.Index].Value.ToString());
                }
            }
            else
            {
                CleanMachines();
            }
        }
        private void buttonDMCreateMachine_Click(object sender, EventArgs e)
        {

        }
        private void dataGridViewMachines_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            string machine = dataGridViewMachines.Rows[e.RowIndex].Cells[ColumnName.Index].Value?.ToString();
            if (e.ColumnIndex == ColumnDelete.Index)
            {
                DeleteMachine(machine);
            }
            else if (e.ColumnIndex == ColumnStartStop.Index)
            {
                dataGridViewMachines.Rows[e.RowIndex].Cells[ColumnStartStop.Index].Value = Tools.Utilities.UI.Resources.ResourceIconSet16Default.arrow_rotate_clockwise;
                StopStartMachine(machine);
            }
            else if (e.ColumnIndex == ColumnActive.Index)
            {
                ChangeActiveMachine(machine);
            }
            else if (e.ColumnIndex == ColumnRegenerateCert.Index)
            {
                RegenerateCert(machine);
            }
            else if (e.ColumnIndex == ColumnResetEnv.Index)
            {
                ResetEnv(machine);
            }
            if (e.ColumnIndex == ColumnInspect.Index)
            {
                InspectMachine(machine);
            }
        }
        #endregion
    }
}
