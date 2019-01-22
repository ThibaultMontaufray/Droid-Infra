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
using System.Diagnostics;
using System.Data.Common.CommandTrees.ExpressionBuilder;

namespace Droid.Infra.UI
{
    public partial class ViewComputer : UserControlCustom
    {
        #region Attributes
        private ComputerAdapter _adapter;
        #endregion

        #region Properties
        public ComputerAdapter Adapter
        {
            get { return _adapter; }
            set { _adapter = value; }
        }
        #endregion

        #region Constructor
        public ViewComputer()
        {
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public override void RefreshData()
        {
            if (_adapter != null)
            {
                _labelGraphicCardValue.Text = _adapter.GraphicCard;
                _labelOsValue.Text = _adapter.Os;
                _labelRamValue.Text = _adapter.RAM;
                _labelIISInstalledValue.Text = _adapter.IIS.IsRunning ? "Running" : "Stopped";

                dataGridViewEvents.Rows.Clear();
                if (_adapter.SysEvent != null)
                {
                    for (int i = _adapter.SysEvent.Count - 1; i > _adapter.SysEvent.Count - 1000; i--)
                    {
                        if (_adapter.SysEvent[i].EntryType.ToString() != "Information")
                        { 
                            dataGridViewEvents.Rows.Add();
                            dataGridViewEvents.Rows[dataGridViewEvents.Rows.Count - 1].Cells[ColumnLevel.Index].Value = _adapter.SysEvent[i].EntryType.ToString() == "Error" ? Tools.Utilities.UI.Resources.ResourceIconSet16Default.exclamation : Tools.Utilities.UI.Resources.ResourceIconSet16Default.error;
                            dataGridViewEvents.Rows[dataGridViewEvents.Rows.Count - 1].Cells[ColumnDescription.Index].Value = _adapter.SysEvent[i].Message;
                            dataGridViewEvents.Rows[dataGridViewEvents.Rows.Count - 1].Cells[ColumnDate.Index].Value = _adapter.SysEvent[i].TimeGenerated;
                            dataGridViewEvents.Rows[dataGridViewEvents.Rows.Count - 1].Cells[ColumnSource.Index].Value = _adapter.SysEvent[i].Source;
                        }
                    }
                }
            }
        }
        public override void ChangeLanguage()
        {

        }
        #endregion

        #region Methods private
        private void Init()
        {
            RefreshDataAsync();
        }
        #endregion

        #region Event
        #endregion
    }
}
