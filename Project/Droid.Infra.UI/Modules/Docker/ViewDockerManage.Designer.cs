namespace Droid.Infra.UI
{
    partial class ViewDockerManage
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelMachineName = new System.Windows.Forms.Label();
            this.labelConfigVersion = new System.Windows.Forms.Label();
            this.labelLastStatus = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dataGridViewMachines = new System.Windows.Forms.DataGridView();
            this.panelDockerMachine = new System.Windows.Forms.Panel();
            this.buttonDMCreateMachine = new System.Windows.Forms.Button();
            this.labelDMActive = new System.Windows.Forms.Label();
            this.labelDMIp = new System.Windows.Forms.Label();
            this.labelDMStatus = new System.Windows.Forms.Label();
            this.labelDMVersion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDriverSize = new System.Windows.Forms.Label();
            this.labelDriverCpu = new System.Windows.Forms.Label();
            this.labelDriverUser = new System.Windows.Forms.Label();
            this.labelDriverIp = new System.Windows.Forms.Label();
            this.groupBoxHost = new System.Windows.Forms.GroupBox();
            this.labelHostEngine = new System.Windows.Forms.Label();
            this.labelHostDisk = new System.Windows.Forms.Label();
            this.labelHostRam = new System.Windows.Forms.Label();
            this.lableHostSwarmUrl = new System.Windows.Forms.Label();
            this.labelHost = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnActive = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnState = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSwarm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDocker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStartStop = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnRegenerateCert = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnResetEnv = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnInspect = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMachines)).BeginInit();
            this.panelDockerMachine.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxHost.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMachineName
            // 
            this.labelMachineName.AutoSize = true;
            this.labelMachineName.Location = new System.Drawing.Point(344, 15);
            this.labelMachineName.Name = "labelMachineName";
            this.labelMachineName.Size = new System.Drawing.Size(37, 14);
            this.labelMachineName.TabIndex = 0;
            this.labelMachineName.Text = "_____";
            // 
            // labelConfigVersion
            // 
            this.labelConfigVersion.AutoSize = true;
            this.labelConfigVersion.Location = new System.Drawing.Point(344, 45);
            this.labelConfigVersion.Name = "labelConfigVersion";
            this.labelConfigVersion.Size = new System.Drawing.Size(37, 14);
            this.labelConfigVersion.TabIndex = 1;
            this.labelConfigVersion.Text = "_____";
            // 
            // labelLastStatus
            // 
            this.labelLastStatus.AutoSize = true;
            this.labelLastStatus.Location = new System.Drawing.Point(344, 75);
            this.labelLastStatus.Name = "labelLastStatus";
            this.labelLastStatus.Size = new System.Drawing.Size(37, 14);
            this.labelLastStatus.TabIndex = 2;
            this.labelLastStatus.Text = "_____";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.DimGray;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.ForeColor = System.Drawing.Color.Black;
            this.buttonStart.Location = new System.Drawing.Point(916, 161);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.DimGray;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.ForeColor = System.Drawing.Color.Black;
            this.buttonRefresh.Location = new System.Drawing.Point(835, 161);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // dataGridViewMachines
            // 
            this.dataGridViewMachines.AllowUserToAddRows = false;
            this.dataGridViewMachines.AllowUserToDeleteRows = false;
            this.dataGridViewMachines.AllowUserToResizeColumns = false;
            this.dataGridViewMachines.AllowUserToResizeRows = false;
            this.dataGridViewMachines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMachines.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewMachines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMachines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewMachines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMachines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMachines.ColumnHeadersHeight = 25;
            this.dataGridViewMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMachines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnActive,
            this.ColumnDriver,
            this.ColumnState,
            this.ColumnUrl,
            this.ColumnSwarm,
            this.ColumnDocker,
            this.ColumnError,
            this.ColumnStartStop,
            this.ColumnRegenerateCert,
            this.ColumnResetEnv,
            this.ColumnInspect,
            this.ColumnDelete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMachines.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMachines.EnableHeadersVisualStyles = false;
            this.dataGridViewMachines.Location = new System.Drawing.Point(337, 3);
            this.dataGridViewMachines.Name = "dataGridViewMachines";
            this.dataGridViewMachines.RowHeadersVisible = false;
            this.dataGridViewMachines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMachines.Size = new System.Drawing.Size(660, 164);
            this.dataGridViewMachines.TabIndex = 5;
            this.dataGridViewMachines.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMachines_CellClick);
            this.dataGridViewMachines.SelectionChanged += new System.EventHandler(this.dataGridViewMachines_SelectionChanged);
            // 
            // panelDockerMachine
            // 
            this.panelDockerMachine.BackColor = System.Drawing.Color.Black;
            this.panelDockerMachine.Controls.Add(this.buttonDMCreateMachine);
            this.panelDockerMachine.Controls.Add(this.labelDMActive);
            this.panelDockerMachine.Controls.Add(this.labelDMIp);
            this.panelDockerMachine.Controls.Add(this.labelDMStatus);
            this.panelDockerMachine.Controls.Add(this.labelDMVersion);
            this.panelDockerMachine.Location = new System.Drawing.Point(3, 3);
            this.panelDockerMachine.Name = "panelDockerMachine";
            this.panelDockerMachine.Size = new System.Drawing.Size(328, 164);
            this.panelDockerMachine.TabIndex = 6;
            // 
            // buttonDMCreateMachine
            // 
            this.buttonDMCreateMachine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDMCreateMachine.BackColor = System.Drawing.Color.DimGray;
            this.buttonDMCreateMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDMCreateMachine.ForeColor = System.Drawing.Color.Black;
            this.buttonDMCreateMachine.Location = new System.Drawing.Point(8, 133);
            this.buttonDMCreateMachine.Name = "buttonDMCreateMachine";
            this.buttonDMCreateMachine.Size = new System.Drawing.Size(311, 23);
            this.buttonDMCreateMachine.TabIndex = 9;
            this.buttonDMCreateMachine.Text = "Create a new docker machine";
            this.buttonDMCreateMachine.UseVisualStyleBackColor = false;
            this.buttonDMCreateMachine.Click += new System.EventHandler(this.buttonDMCreateMachine_Click);
            // 
            // labelDMActive
            // 
            this.labelDMActive.AutoSize = true;
            this.labelDMActive.Location = new System.Drawing.Point(5, 95);
            this.labelDMActive.Name = "labelDMActive";
            this.labelDMActive.Size = new System.Drawing.Size(37, 14);
            this.labelDMActive.TabIndex = 6;
            this.labelDMActive.Text = "_____";
            // 
            // labelDMIp
            // 
            this.labelDMIp.AutoSize = true;
            this.labelDMIp.Location = new System.Drawing.Point(5, 65);
            this.labelDMIp.Name = "labelDMIp";
            this.labelDMIp.Size = new System.Drawing.Size(37, 14);
            this.labelDMIp.TabIndex = 5;
            this.labelDMIp.Text = "_____";
            // 
            // labelDMStatus
            // 
            this.labelDMStatus.AutoSize = true;
            this.labelDMStatus.Location = new System.Drawing.Point(5, 35);
            this.labelDMStatus.Name = "labelDMStatus";
            this.labelDMStatus.Size = new System.Drawing.Size(37, 14);
            this.labelDMStatus.TabIndex = 4;
            this.labelDMStatus.Text = "_____";
            // 
            // labelDMVersion
            // 
            this.labelDMVersion.AutoSize = true;
            this.labelDMVersion.Location = new System.Drawing.Point(5, 5);
            this.labelDMVersion.Name = "labelDMVersion";
            this.labelDMVersion.Size = new System.Drawing.Size(37, 14);
            this.labelDMVersion.TabIndex = 3;
            this.labelDMVersion.Text = "_____";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.labelDriverSize);
            this.panel2.Controls.Add(this.labelDriverCpu);
            this.panel2.Controls.Add(this.labelDriverUser);
            this.panel2.Controls.Add(this.labelDriverIp);
            this.panel2.Controls.Add(this.groupBoxHost);
            this.panel2.Controls.Add(this.labelPath);
            this.panel2.Controls.Add(this.labelMachineName);
            this.panel2.Controls.Add(this.labelConfigVersion);
            this.panel2.Controls.Add(this.labelLastStatus);
            this.panel2.Controls.Add(this.buttonRefresh);
            this.panel2.Controls.Add(this.buttonStart);
            this.panel2.Location = new System.Drawing.Point(3, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 192);
            this.panel2.TabIndex = 7;
            // 
            // labelDriverSize
            // 
            this.labelDriverSize.AutoSize = true;
            this.labelDriverSize.Location = new System.Drawing.Point(344, 165);
            this.labelDriverSize.Name = "labelDriverSize";
            this.labelDriverSize.Size = new System.Drawing.Size(37, 14);
            this.labelDriverSize.TabIndex = 12;
            this.labelDriverSize.Text = "_____";
            // 
            // labelDriverCpu
            // 
            this.labelDriverCpu.AutoSize = true;
            this.labelDriverCpu.Location = new System.Drawing.Point(732, 42);
            this.labelDriverCpu.Name = "labelDriverCpu";
            this.labelDriverCpu.Size = new System.Drawing.Size(37, 14);
            this.labelDriverCpu.TabIndex = 11;
            this.labelDriverCpu.Text = "_____";
            // 
            // labelDriverUser
            // 
            this.labelDriverUser.AutoSize = true;
            this.labelDriverUser.Location = new System.Drawing.Point(732, 12);
            this.labelDriverUser.Name = "labelDriverUser";
            this.labelDriverUser.Size = new System.Drawing.Size(37, 14);
            this.labelDriverUser.TabIndex = 10;
            this.labelDriverUser.Text = "_____";
            // 
            // labelDriverIp
            // 
            this.labelDriverIp.AutoSize = true;
            this.labelDriverIp.Location = new System.Drawing.Point(344, 135);
            this.labelDriverIp.Name = "labelDriverIp";
            this.labelDriverIp.Size = new System.Drawing.Size(37, 14);
            this.labelDriverIp.TabIndex = 8;
            this.labelDriverIp.Text = "_____";
            // 
            // groupBoxHost
            // 
            this.groupBoxHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxHost.Controls.Add(this.labelHostEngine);
            this.groupBoxHost.Controls.Add(this.labelHostDisk);
            this.groupBoxHost.Controls.Add(this.labelHostRam);
            this.groupBoxHost.Controls.Add(this.lableHostSwarmUrl);
            this.groupBoxHost.Controls.Add(this.labelHost);
            this.groupBoxHost.Location = new System.Drawing.Point(3, 3);
            this.groupBoxHost.Name = "groupBoxHost";
            this.groupBoxHost.Size = new System.Drawing.Size(325, 185);
            this.groupBoxHost.TabIndex = 7;
            this.groupBoxHost.TabStop = false;
            // 
            // labelHostEngine
            // 
            this.labelHostEngine.AutoSize = true;
            this.labelHostEngine.Location = new System.Drawing.Point(15, 150);
            this.labelHostEngine.Name = "labelHostEngine";
            this.labelHostEngine.Size = new System.Drawing.Size(37, 14);
            this.labelHostEngine.TabIndex = 10;
            this.labelHostEngine.Text = "_____";
            // 
            // labelHostDisk
            // 
            this.labelHostDisk.AutoSize = true;
            this.labelHostDisk.Location = new System.Drawing.Point(15, 120);
            this.labelHostDisk.Name = "labelHostDisk";
            this.labelHostDisk.Size = new System.Drawing.Size(37, 14);
            this.labelHostDisk.TabIndex = 9;
            this.labelHostDisk.Text = "_____";
            // 
            // labelHostRam
            // 
            this.labelHostRam.AutoSize = true;
            this.labelHostRam.Location = new System.Drawing.Point(15, 90);
            this.labelHostRam.Name = "labelHostRam";
            this.labelHostRam.Size = new System.Drawing.Size(37, 14);
            this.labelHostRam.TabIndex = 8;
            this.labelHostRam.Text = "_____";
            // 
            // lableHostSwarmUrl
            // 
            this.lableHostSwarmUrl.AutoSize = true;
            this.lableHostSwarmUrl.Location = new System.Drawing.Point(15, 60);
            this.lableHostSwarmUrl.Name = "lableHostSwarmUrl";
            this.lableHostSwarmUrl.Size = new System.Drawing.Size(37, 14);
            this.lableHostSwarmUrl.TabIndex = 7;
            this.lableHostSwarmUrl.Text = "_____";
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Location = new System.Drawing.Point(15, 30);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(37, 14);
            this.labelHost.TabIndex = 6;
            this.labelHost.Text = "_____";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(344, 105);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(37, 14);
            this.labelPath.TabIndex = 5;
            this.labelPath.Text = "_____";
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnActive
            // 
            this.ColumnActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnActive.HeaderText = "Active";
            this.ColumnActive.Name = "ColumnActive";
            this.ColumnActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnActive.Width = 61;
            // 
            // ColumnDriver
            // 
            this.ColumnDriver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnDriver.HeaderText = "Driver";
            this.ColumnDriver.Name = "ColumnDriver";
            this.ColumnDriver.Width = 62;
            // 
            // ColumnState
            // 
            this.ColumnState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnState.HeaderText = "State";
            this.ColumnState.Name = "ColumnState";
            this.ColumnState.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnState.Width = 58;
            // 
            // ColumnUrl
            // 
            this.ColumnUrl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnUrl.HeaderText = "Url";
            this.ColumnUrl.Name = "ColumnUrl";
            this.ColumnUrl.Width = 46;
            // 
            // ColumnSwarm
            // 
            this.ColumnSwarm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnSwarm.HeaderText = "Swarm";
            this.ColumnSwarm.Name = "ColumnSwarm";
            this.ColumnSwarm.Width = 66;
            // 
            // ColumnDocker
            // 
            this.ColumnDocker.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnDocker.HeaderText = "Docker";
            this.ColumnDocker.Name = "ColumnDocker";
            this.ColumnDocker.Width = 67;
            // 
            // ColumnError
            // 
            this.ColumnError.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnError.HeaderText = "Errors";
            this.ColumnError.Name = "ColumnError";
            this.ColumnError.Width = 61;
            // 
            // ColumnStartStop
            // 
            this.ColumnStartStop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnStartStop.HeaderText = "";
            this.ColumnStartStop.Name = "ColumnStartStop";
            this.ColumnStartStop.ToolTipText = "Start / stop engine";
            this.ColumnStartStop.Width = 5;
            // 
            // ColumnRegenerateCert
            // 
            this.ColumnRegenerateCert.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnRegenerateCert.HeaderText = "";
            this.ColumnRegenerateCert.Name = "ColumnRegenerateCert";
            this.ColumnRegenerateCert.ToolTipText = "Regenerate certificat";
            this.ColumnRegenerateCert.Width = 5;
            // 
            // ColumnResetEnv
            // 
            this.ColumnResetEnv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnResetEnv.HeaderText = "";
            this.ColumnResetEnv.Name = "ColumnResetEnv";
            this.ColumnResetEnv.ToolTipText = "Reset environment variables";
            this.ColumnResetEnv.Width = 5;
            // 
            // ColumnInspect
            // 
            this.ColumnInspect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnInspect.HeaderText = "";
            this.ColumnInspect.Name = "ColumnInspect";
            this.ColumnInspect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnInspect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnInspect.ToolTipText = "Inspect engine";
            this.ColumnInspect.Width = 17;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnDelete.HeaderText = "";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ToolTipText = "Delete engine";
            this.ColumnDelete.Width = 5;
            // 
            // ViewDockerManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelDockerMachine);
            this.Controls.Add(this.dataGridViewMachines);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "ViewDockerManage";
            this.Size = new System.Drawing.Size(1000, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMachines)).EndInit();
            this.panelDockerMachine.ResumeLayout(false);
            this.panelDockerMachine.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxHost.ResumeLayout(false);
            this.groupBoxHost.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMachineName;
        private System.Windows.Forms.Label labelConfigVersion;
        private System.Windows.Forms.Label labelLastStatus;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridView dataGridViewMachines;
        private System.Windows.Forms.Panel panelDockerMachine;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDMStatus;
        private System.Windows.Forms.Label labelDMVersion;
        private System.Windows.Forms.Label labelDMActive;
        private System.Windows.Forms.Label labelDMIp;
        private System.Windows.Forms.Button buttonDMCreateMachine;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.GroupBox groupBoxHost;
        private System.Windows.Forms.Label labelHostRam;
        private System.Windows.Forms.Label lableHostSwarmUrl;
        private System.Windows.Forms.Label labelHostDisk;
        private System.Windows.Forms.Label labelHostEngine;
        private System.Windows.Forms.Label labelDriverCpu;
        private System.Windows.Forms.Label labelDriverUser;
        private System.Windows.Forms.Label labelDriverIp;
        private System.Windows.Forms.Label labelDriverSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewImageColumn ColumnActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDriver;
        private System.Windows.Forms.DataGridViewImageColumn ColumnState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSwarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDocker;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnError;
        private System.Windows.Forms.DataGridViewImageColumn ColumnStartStop;
        private System.Windows.Forms.DataGridViewImageColumn ColumnRegenerateCert;
        private System.Windows.Forms.DataGridViewImageColumn ColumnResetEnv;
        private System.Windows.Forms.DataGridViewImageColumn ColumnInspect;
        private System.Windows.Forms.DataGridViewImageColumn ColumnDelete;
    }
}
