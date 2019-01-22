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

namespace Droid.Infra.UI
{
    public partial class ViewInfraOverview : UserControlCustom
    {
        #region Attributes
        private InterfaceInfra _intInfra;
        #endregion

        #region Properties
        public InterfaceInfra IntInfra
        {
            get { return _intInfra; }
            set { _intInfra = value; }
        }
        #endregion

        #region Constructor
        public ViewInfraOverview(InterfaceInfra intInfra)
        {
            _intInfra = intInfra;
            InitializeComponent();
        }
        #endregion

        #region Methods public
        public override void RefreshData()
        {
            _dataGridView.Rows.Clear();
            if (_intInfra?.InfraFarm.Adapters != null)
            {
                foreach (InfraAdapter item in _intInfra?.InfraFarm.Adapters)
                {
                    _dataGridView.Rows.Add();
                    _dataGridView.Rows[_dataGridView.Rows.Count - 1].Tag = item;
                    _dataGridView.Rows[_dataGridView.Rows.Count - 1].Cells[ColumnName.Index].Value = item.Name;
                    _dataGridView.Rows[_dataGridView.Rows.Count - 1].Cells[ColumnDomain.Index].Value = item.Domain;
                    _dataGridView.Rows[_dataGridView.Rows.Count - 1].Cells[ColumnLogin.Index].Value = item.Login;
                    _dataGridView.Rows[_dataGridView.Rows.Count - 1].Cells[ColumnDelete.Index].Value = Tools.Utilities.UI.Resources.ResourceIconSet16Default.cross;
                    _dataGridView.Rows[_dataGridView.Rows.Count - 1].Cells[ColumnEdit.Index].Value = Tools.Utilities.UI.Resources.ResourceIconSet16Default.drive_edit;
                    _dataGridView.Rows[_dataGridView.Rows.Count - 1].Cells[ColumnTypeIcon.Index].Value = GetImage(item);
                    _dataGridView.Rows[_dataGridView.Rows.Count - 1].Cells[ColumnAddress.Index].Value = (string.IsNullOrEmpty(item.Ip) ? string.Empty : item.Ip + ((string.IsNullOrEmpty(item.Port)) ? string.Empty : ":" + item.Port));
                    _dataGridView.Rows[_dataGridView.Rows.Count - 1].Cells[ColumnToken.Index].Value = !string.IsNullOrEmpty(item.Token);
                    _dataGridView.Rows[_dataGridView.Rows.Count - 1].Cells[ColumnEnv.Index].Value = item.Env.ToString();
                    _dataGridView.Rows[_dataGridView.Rows.Count - 1].Cells[ColumnType.Index].Value = item.Techno.ToString();
                    _dataGridView.Rows[_dataGridView.Rows.Count - 1].Cells[ColumnPassword.Index].Value = !string.IsNullOrEmpty(item.Password);
                }
            }
        }
        #endregion

        #region Methods private
        private void Init()
        {
            RefreshData();
        }
        private System.Drawing.Image GetImage(InfraAdapter component)
        {
            switch (component.Techno.ToString())
            {
                case "BITBUCKET":
                    return Properties.Resources.bitbucket;
                case "DOCKER":
                    return Properties.Resources.docker;
                case "GITHUB":
                    return Properties.Resources.github;
                case "JENKINS":
                    return Properties.Resources.jenkins;
                case "JIRA":
                    return Properties.Resources.jira;
                case "MYSQL":
                    return Properties.Resources.mysql2;
                case "OPENVPN":
                    return Properties.Resources.VPN;
                case "POSTGRE":
                    return Properties.Resources.postgresql;
                case "SERVER":
                    return Properties.Resources.Serveur;
                case "SONARQUBE":
                    return Properties.Resources.sonar;
                case "TEAMCITY":
                    return Properties.Resources.teamcity;
                case "YOUTRACK":
                    return Properties.Resources.youtrack;
                default:
                    return Properties.Resources.unknown;
            }
        }
        #endregion

        #region Event
        private void buttonSave_Click(object sender, EventArgs e)
        {
            _intInfra?.GoAction("Infra_Save");
        }
        private void _dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ColumnEdit.Index)
            {
                _intInfra.InfraFarm.CurrentAdapter = (InfraAdapter)_dataGridView.Rows[e.RowIndex].Tag;
                _intInfra.GoAction("Infra_Edit");
            }
            else if (e.ColumnIndex == ColumnDelete.Index)
            {
                if (MessageBox.Show("Are you sure ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                { 
                    _dataGridView.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            _intInfra?.GoAction("Infra_Open");
        }
        #endregion
    }
}
