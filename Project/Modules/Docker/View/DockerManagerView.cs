namespace Droid_Infra
{
    using System.Linq;
    using System.Windows.Forms;
    using Droid_Infra;
    using System.Collections.Generic;
    using System.Drawing;
    using System;

    public partial class DockerManagerView : UserControl
    {
        #region Attribute
        private DockerMachine _dockerMachine;    
        #endregion

        #region Properties
        public DockerMachine DockerMachine
        {
            get { return _dockerMachine; }
            set { _dockerMachine = value; }
        }
        #endregion

        #region Constructor
        public DockerManagerView()
        {
            InitializeComponent();
            InitializeEnvironment();
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        private void InitializeEnvironment()
        {
            _dockerMachine = new DockerMachine();
            RefreshMachineList();
        }
        private void BuildMachineCreator()
        {
            ListViewItem lvi = new ListViewItem("Create new docker machine");
            //lvi.BackColor = listViewMachine.Items.Count % 2 == 1 ? Color.FromArgb(60, 135, 180) : Color.FromArgb(90, 120, 150);
            lvi.BackColor = Color.FromArgb(64, 64, 64);
            lvi.ForeColor = Color.LightGray;
            lvi.ImageIndex = 0;
            lvi.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listViewMachine.Items.Add(lvi);

            splitContainer.SplitterDistance = lvi.Bounds.Width;
        }
        private void AddMachine(Machine machine)
        {
            ListViewItem lvi = new ListViewItem(machine.Name);
            //lvi.BackColor = listViewMachine.Items.Count % 2 == 1 ? Color.FromArgb(60, 135, 180) : Color.FromArgb(90, 120, 150);
            lvi.BackColor = Color.FromArgb(64, 64, 64);
            lvi.ForeColor = Color.LightGray;
            lvi.SubItems.Add(string.Format("Status : {0}", machine.State));
            lvi.ImageIndex = 1;
            lvi.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listViewMachine.Items.Add(lvi);
        }
        private void DrawListView(ListViewItem selectedItem)
        {
            bool flag = true;
            foreach (ListViewItem item in listViewMachine.Items)
            {
                flag = !flag;
                //  item.BackColor = flag ? Color.FromArgb(60, 135, 180) : Color.FromArgb(90, 120, 150);
                item.BackColor = Color.FromArgb(64, 64, 64);
                item.ForeColor = Color.LightGray;
            }
            selectedItem.BackColor = Color.LightGray;
            selectedItem.ForeColor = Color.Black;
            //selectedItem.BackColor = Color.DarkOrange;
            //selectedItem.ForeColor = Color.Black;
        }
        private void RefreshMachineDetails(Machine machine)
        {
            dataGridViewDetail.Rows.Clear();

            if (machine != null)
            {
                Cursor = Cursors.WaitCursor;
                _dockerMachine.RefreshDetails(machine.Name);

                textBoxMachineName.Text = machine.Name;

                dataGridViewDetail.Rows.Add();
                dataGridViewDetail.Rows[dataGridViewDetail.Rows.Count - 1].Cells[ColumnDetailParameter.Index].Value = "Name";
                dataGridViewDetail.Rows[dataGridViewDetail.Rows.Count - 1].Cells[ColumnDetailValue.Index].Value = machine.Name;
                dataGridViewDetail.Rows.Add();
                dataGridViewDetail.Rows[dataGridViewDetail.Rows.Count - 1].Cells[ColumnDetailParameter.Index].Value = "Status";
                dataGridViewDetail.Rows[dataGridViewDetail.Rows.Count - 1].Cells[ColumnDetailValue.Index].Value = machine.State;
                dataGridViewDetail.Rows.Add();
                dataGridViewDetail.Rows[dataGridViewDetail.Rows.Count - 1].Cells[ColumnDetailParameter.Index].Value = "URL";
                dataGridViewDetail.Rows[dataGridViewDetail.Rows.Count - 1].Cells[ColumnDetailValue.Index].Value = machine.Host.Swarm.URL;
                dataGridViewDetail.Rows.Add();
                dataGridViewDetail.Rows[dataGridViewDetail.Rows.Count - 1].Cells[ColumnDetailParameter.Index].Value = "RAM";
                dataGridViewDetail.Rows[dataGridViewDetail.Rows.Count - 1].Cells[ColumnDetailValue.Index].Value = machine.Driver.Ram;
                dataGridViewDetail.Rows.Add();
                dataGridViewDetail.Rows[dataGridViewDetail.Rows.Count - 1].Cells[ColumnDetailParameter.Index].Value = "Disk";
                dataGridViewDetail.Rows[dataGridViewDetail.Rows.Count - 1].Cells[ColumnDetailValue.Index].Value = machine.Driver.DiskSize;
                dataGridViewDetail.Rows.Add();
                dataGridViewDetail.Rows[dataGridViewDetail.Rows.Count - 1].Cells[ColumnDetailParameter.Index].Value = "CPU";
                dataGridViewDetail.Rows[dataGridViewDetail.Rows.Count - 1].Cells[ColumnDetailValue.Index].Value = machine.Driver.Cpu;
                dataGridViewDetail.Rows.Add();
                dataGridViewDetail.Rows[dataGridViewDetail.Rows.Count - 1].Cells[ColumnDetailParameter.Index].Value = "Store path";
                dataGridViewDetail.Rows[dataGridViewDetail.Rows.Count - 1].Cells[ColumnDetailValue.Index].Value = machine.StorePath;
                dataGridViewDetail.Rows.Add();
                dataGridViewDetail.Rows[dataGridViewDetail.Rows.Count - 1].Cells[ColumnDetailParameter.Index].Value = "IP";
                dataGridViewDetail.Rows[dataGridViewDetail.Rows.Count - 1].Cells[ColumnDetailValue.Index].Value = machine.Driver.IP;
                dataGridViewDetail.Rows.Add();
                dataGridViewDetail.Rows[dataGridViewDetail.Rows.Count - 1].Cells[ColumnDetailParameter.Index].Value = "Port ssh";
                dataGridViewDetail.Rows[dataGridViewDetail.Rows.Count - 1].Cells[ColumnDetailValue.Index].Value = machine.Driver.SshPort;
                dataGridViewDetail.Rows.Add();
                dataGridViewDetail.Rows[dataGridViewDetail.Rows.Count - 1].Cells[ColumnDetailParameter.Index].Value = "User ssh";
                dataGridViewDetail.Rows[dataGridViewDetail.Rows.Count - 1].Cells[ColumnDetailValue.Index].Value = machine.Driver.SshUser;
                Cursor = Cursors.Arrow;
            }
        }
        private Machine GetSelectedMachine()
        {
            if (listViewMachine.SelectedItems.Count == 1 && _dockerMachine.Machines != null)
            {
                string machineName = listViewMachine.SelectedItems[0].Text;
                List<Machine> tab = _dockerMachine.Machines.Where(m => m.Name.Equals(machineName)).ToList();
                if (tab.Count == 1) return tab[0];
                else return null;
            }
            return null;
        }
        private void RefreshMachineList()
        {
            listViewMachine.Items.Clear();
            listViewMachine.Columns.Add("Machine");
            listViewMachine.Columns.Add("Description");
            listViewMachine.Alignment = ListViewAlignment.Left;
            listViewMachine.ItemMouseHover += listViewMachine_ItemMouseHover;
            listViewMachine.ItemSelectionChanged += listViewMachine_ItemSelectionChanged;
            listViewMachine.BorderStyle = System.Windows.Forms.BorderStyle.None;

            BuildMachineCreator();
            foreach (Machine machine in _dockerMachine.Machines)
            {
                AddMachine(machine);
            }
            textBoxMachineName.Text = "DEMO-" + DateTime.Now.ToString("yyyyMMdd-hhmm");
        }
        private void RefreshDetailPanel()
        {
            if (listViewMachine.SelectedItems.Count == 1)
            {
                string machineName = listViewMachine.SelectedItems[0].Text;
                if (machineName.Equals("Create new docker machine"))
                {
                    tabControlMachine.Visible = false;
                    panelNewMachine.Visible = true;
                    textBoxMachineName.Text = "DEMO-" + DateTime.Now.ToString("yyyyMMdd-hhmm");
                }
                else
                {
                    panelNewMachine.Visible = false;
                    Machine machine = GetSelectedMachine();
                    if (machine != null)
                    {
                        RefreshMachineDetails(machine);
                        tabControlMachine.Visible = true;
                    }
                    else
                    {
                        tabControlMachine.Visible = false;
                    }
                }
            }
        }
        private void RefreshAllScreen()
        {
            RefreshMachineList();
            RefreshDetailPanel();
        }
        #endregion

        #region Event
        private void listViewMachine_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            DrawListView(e.Item);
            RefreshDetailPanel();
        }
        private void listViewMachine_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            DrawListView(e.Item);
        }
        private void buttonStart_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to start it ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                _dockerMachine.Start(textBoxMachineName.Text);
                RefreshAllScreen();
                Cursor = Cursors.Arrow;
            }
        }
        private void buttonStop_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to stop it ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                _dockerMachine.Stop(textBoxMachineName.Text);
                RefreshAllScreen();
                Cursor = Cursors.Arrow;
            }
        }
        private void buttonDelete_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete it ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                _dockerMachine.Delete(textBoxMachineName.Text);
                RefreshAllScreen();
                Cursor = Cursors.Arrow;
            }
        }
        private void buttonCreate_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to create it ?\r\nThis could take some minutes.", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                _dockerMachine.Create(textBoxMachineName.Text);
                RefreshAllScreen();
                Cursor = Cursors.Arrow;
            }
        }
        private void buttonImage_Click(object sender, EventArgs e)
        {
            _dockerMachine.Images(textBoxMachineName.Text);
        }
        #endregion
    }
}
