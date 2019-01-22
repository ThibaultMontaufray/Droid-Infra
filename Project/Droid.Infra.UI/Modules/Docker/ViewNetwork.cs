using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using Tools.Utilities;
using Droid.Infra.Modules.Docker.Model;
using Droid.Infra.Modules.Docker.Controler;

namespace Droid.Infra.UI.Modules.Docker.View
{
    public partial class ViewNetworks : UserControlCustom
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
        public ViewNetworks()
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
                    List<Network> networks = _adapter.Engine.CurrentMachine.Networks;
                    if (networks != null)
                    {
                        LoadNetwork(networks);
                    }
                }
                else
                {
                    CleanNetwork();
                }
            }
            else
            {
                CleanNetwork();
            }
        }
        #endregion

        #region Methods private
        private void LoadNetwork(List<Network> networks)
        {
            this.SuspendLayout();
            dataGridViewNetwork.Rows.Clear();

            foreach (Network network in networks)
            {
                dataGridViewNetwork.Rows.Add();
                dataGridViewNetwork.Rows[dataGridViewNetwork.Rows.Count - 1].Cells[ColumnId.Index].Value = network.Id.Substring(0, 12);
                dataGridViewNetwork.Rows[dataGridViewNetwork.Rows.Count - 1].Cells[ColumnDriver.Index].Value = network.Driver;
                dataGridViewNetwork.Rows[dataGridViewNetwork.Rows.Count - 1].Cells[ColumnName.Index].Value = network.Name;
                dataGridViewNetwork.Rows[dataGridViewNetwork.Rows.Count - 1].Cells[ColumnScope.Index].Value = network.Scope;
                dataGridViewNetwork.Rows[dataGridViewNetwork.Rows.Count - 1].Cells[ColumnDelete.Index].Value = Tools.Utilities.UI.Resources.ResourceIconSet16Default.cross;
                dataGridViewNetwork.Rows[dataGridViewNetwork.Rows.Count - 1].Cells[ColumnInspect.Index].Value = Tools.Utilities.UI.Resources.ResourceIconSet16Default.zoom;
                dataGridViewNetwork.Rows[dataGridViewNetwork.Rows.Count - 1].Tag = network;
            }
            this.ResumeLayout();

        }
        private void CleanNetwork()
        {
            this.SuspendLayout();
            dataGridViewNetwork.Rows.Clear();
            this.ResumeLayout();
        }
        private void Delete(int rowIndex)
        {
            if (_adapter != null && _adapter.Engine != null && _adapter.Engine.CurrentMachine != null)
            {
                _adapter.Engine.CurrentMachine.Networks.Where(n => n.Id == dataGridViewNetwork.Rows[rowIndex].Cells[ColumnId.Index].Value?.ToString()).First()?.Delete();
                RefreshData();
            }
        }
        private void Inspect(int rowIndex)
        {
        }
        #endregion

        #region Event
        private void dataGridViewNetwork_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ColumnDelete.Index)
            {
                Delete(e.RowIndex);
            }
            else if (e.ColumnIndex == ColumnInspect.Index)
            {
                _adapter.CurrentNetwork = dataGridViewNetwork.Rows[e.RowIndex].Tag as Model.Network;
                _adapter.GoAction("inspectNetwork");
                //Inspect(e.RowIndex);
            }
        }
        #endregion
    }
}
