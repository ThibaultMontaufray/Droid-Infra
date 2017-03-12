namespace Droid_Infra
{
    partial class CloudManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloudManage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelConfigFileValue = new System.Windows.Forms.Label();
            this.labelConfigFolderPath = new System.Windows.Forms.Label();
            this.labelDaemonStatusValue = new System.Windows.Forms.Label();
            this.labelDaemonStatus = new System.Windows.Forms.Label();
            this.dataGridViewRepo = new System.Windows.Forms.DataGridView();
            this.labelDaemonPIDValue = new System.Windows.Forms.Label();
            this.labelDaemonPID = new System.Windows.Forms.Label();
            this.labelLoginValue = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPasswordValue = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelSynchroDateValue = new System.Windows.Forms.Label();
            this.labelSynchroDate = new System.Windows.Forms.Label();
            this.buttonSynchroStartStop = new System.Windows.Forms.Button();
            this.ColumnIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelConfigFileValue
            // 
            this.labelConfigFileValue.Font = new System.Drawing.Font("Calibri", 10F);
            this.labelConfigFileValue.ForeColor = System.Drawing.Color.White;
            this.labelConfigFileValue.Location = new System.Drawing.Point(194, 64);
            this.labelConfigFileValue.Name = "labelConfigFileValue";
            this.labelConfigFileValue.Size = new System.Drawing.Size(508, 23);
            this.labelConfigFileValue.TabIndex = 22;
            this.labelConfigFileValue.Text = "_______";
            // 
            // labelConfigFolderPath
            // 
            this.labelConfigFolderPath.AutoSize = true;
            this.labelConfigFolderPath.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfigFolderPath.ForeColor = System.Drawing.Color.White;
            this.labelConfigFolderPath.Location = new System.Drawing.Point(3, 64);
            this.labelConfigFolderPath.Name = "labelConfigFolderPath";
            this.labelConfigFolderPath.Size = new System.Drawing.Size(105, 15);
            this.labelConfigFolderPath.TabIndex = 21;
            this.labelConfigFolderPath.Text = "Config folder path";
            // 
            // labelDaemonStatusValue
            // 
            this.labelDaemonStatusValue.AutoSize = true;
            this.labelDaemonStatusValue.Font = new System.Drawing.Font("Calibri", 10F);
            this.labelDaemonStatusValue.ForeColor = System.Drawing.Color.White;
            this.labelDaemonStatusValue.Location = new System.Drawing.Point(194, 0);
            this.labelDaemonStatusValue.Name = "labelDaemonStatusValue";
            this.labelDaemonStatusValue.Size = new System.Drawing.Size(57, 17);
            this.labelDaemonStatusValue.TabIndex = 20;
            this.labelDaemonStatusValue.Text = "_______";
            // 
            // labelDaemonStatus
            // 
            this.labelDaemonStatus.AutoSize = true;
            this.labelDaemonStatus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaemonStatus.ForeColor = System.Drawing.Color.White;
            this.labelDaemonStatus.Location = new System.Drawing.Point(3, 0);
            this.labelDaemonStatus.Name = "labelDaemonStatus";
            this.labelDaemonStatus.Size = new System.Drawing.Size(89, 15);
            this.labelDaemonStatus.TabIndex = 19;
            this.labelDaemonStatus.Text = "Daemon status";
            // 
            // dataGridViewRepo
            // 
            this.dataGridViewRepo.AllowUserToAddRows = false;
            this.dataGridViewRepo.AllowUserToDeleteRows = false;
            this.dataGridViewRepo.AllowUserToResizeColumns = false;
            this.dataGridViewRepo.AllowUserToResizeRows = false;
            this.dataGridViewRepo.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridViewRepo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewRepo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRepo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIcon,
            this.ColumnId,
            this.ColumnPath,
            this.ColumnTypeName,
            this.ColumnEnabled});
            this.dataGridViewRepo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewRepo.Location = new System.Drawing.Point(0, 124);
            this.dataGridViewRepo.Name = "dataGridViewRepo";
            this.dataGridViewRepo.RowHeadersVisible = false;
            this.dataGridViewRepo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRepo.Size = new System.Drawing.Size(705, 222);
            this.dataGridViewRepo.TabIndex = 23;
            // 
            // labelDaemonPIDValue
            // 
            this.labelDaemonPIDValue.Font = new System.Drawing.Font("Calibri", 10F);
            this.labelDaemonPIDValue.ForeColor = System.Drawing.Color.White;
            this.labelDaemonPIDValue.Location = new System.Drawing.Point(194, 31);
            this.labelDaemonPIDValue.Name = "labelDaemonPIDValue";
            this.labelDaemonPIDValue.Size = new System.Drawing.Size(146, 17);
            this.labelDaemonPIDValue.TabIndex = 25;
            this.labelDaemonPIDValue.Text = "_______";
            // 
            // labelDaemonPID
            // 
            this.labelDaemonPID.AutoSize = true;
            this.labelDaemonPID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaemonPID.ForeColor = System.Drawing.Color.White;
            this.labelDaemonPID.Location = new System.Drawing.Point(3, 31);
            this.labelDaemonPID.Name = "labelDaemonPID";
            this.labelDaemonPID.Size = new System.Drawing.Size(74, 15);
            this.labelDaemonPID.TabIndex = 24;
            this.labelDaemonPID.Text = "Daemon PID";
            // 
            // labelLoginValue
            // 
            this.labelLoginValue.Font = new System.Drawing.Font("Calibri", 10F);
            this.labelLoginValue.ForeColor = System.Drawing.Color.White;
            this.labelLoginValue.Location = new System.Drawing.Point(535, 0);
            this.labelLoginValue.Name = "labelLoginValue";
            this.labelLoginValue.Size = new System.Drawing.Size(146, 17);
            this.labelLoginValue.TabIndex = 27;
            this.labelLoginValue.Text = "_______";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.White;
            this.labelLogin.Location = new System.Drawing.Point(435, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(36, 15);
            this.labelLogin.TabIndex = 26;
            this.labelLogin.Text = "Login";
            // 
            // labelPasswordValue
            // 
            this.labelPasswordValue.Font = new System.Drawing.Font("Calibri", 10F);
            this.labelPasswordValue.ForeColor = System.Drawing.Color.White;
            this.labelPasswordValue.Location = new System.Drawing.Point(535, 31);
            this.labelPasswordValue.Name = "labelPasswordValue";
            this.labelPasswordValue.Size = new System.Drawing.Size(146, 17);
            this.labelPasswordValue.TabIndex = 29;
            this.labelPasswordValue.Text = "_______";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(435, 31);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(59, 15);
            this.labelPassword.TabIndex = 28;
            this.labelPassword.Text = "Password";
            // 
            // labelSynchroDateValue
            // 
            this.labelSynchroDateValue.Font = new System.Drawing.Font("Calibri", 10F);
            this.labelSynchroDateValue.ForeColor = System.Drawing.Color.White;
            this.labelSynchroDateValue.Location = new System.Drawing.Point(194, 99);
            this.labelSynchroDateValue.Name = "labelSynchroDateValue";
            this.labelSynchroDateValue.Size = new System.Drawing.Size(146, 17);
            this.labelSynchroDateValue.TabIndex = 31;
            this.labelSynchroDateValue.Text = "_______";
            // 
            // labelSynchroDate
            // 
            this.labelSynchroDate.AutoSize = true;
            this.labelSynchroDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSynchroDate.ForeColor = System.Drawing.Color.White;
            this.labelSynchroDate.Location = new System.Drawing.Point(3, 99);
            this.labelSynchroDate.Name = "labelSynchroDate";
            this.labelSynchroDate.Size = new System.Drawing.Size(117, 15);
            this.labelSynchroDate.TabIndex = 30;
            this.labelSynchroDate.Text = "Last synchronisation";
            // 
            // buttonSynchroStartStop
            // 
            this.buttonSynchroStartStop.Location = new System.Drawing.Point(627, 95);
            this.buttonSynchroStartStop.Name = "buttonSynchroStartStop";
            this.buttonSynchroStartStop.Size = new System.Drawing.Size(75, 23);
            this.buttonSynchroStartStop.TabIndex = 32;
            this.buttonSynchroStartStop.Text = "Start";
            this.buttonSynchroStartStop.UseVisualStyleBackColor = true;
            this.buttonSynchroStartStop.Click += new System.EventHandler(this.buttonSynchroStartStop_Click);
            // 
            // ColumnIcon
            // 
            this.ColumnIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnIcon.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnIcon.HeaderText = "";
            this.ColumnIcon.Name = "ColumnIcon";
            this.ColumnIcon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnIcon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnIcon.Width = 5;
            // 
            // ColumnId
            // 
            this.ColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnId.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Width = 41;
            // 
            // ColumnPath
            // 
            this.ColumnPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnPath.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnPath.HeaderText = "Path";
            this.ColumnPath.Name = "ColumnPath";
            // 
            // ColumnTypeName
            // 
            this.ColumnTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnTypeName.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnTypeName.HeaderText = "Type";
            this.ColumnTypeName.Name = "ColumnTypeName";
            this.ColumnTypeName.Width = 56;
            // 
            // ColumnEnabled
            // 
            this.ColumnEnabled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.NullValue = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnEnabled.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnEnabled.HeaderText = "Synchronised";
            this.ColumnEnabled.Name = "ColumnEnabled";
            this.ColumnEnabled.Width = 77;
            // 
            // CloudManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonSynchroStartStop);
            this.Controls.Add(this.labelSynchroDateValue);
            this.Controls.Add(this.labelSynchroDate);
            this.Controls.Add(this.labelPasswordValue);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLoginValue);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelDaemonPIDValue);
            this.Controls.Add(this.labelDaemonPID);
            this.Controls.Add(this.dataGridViewRepo);
            this.Controls.Add(this.labelConfigFileValue);
            this.Controls.Add(this.labelConfigFolderPath);
            this.Controls.Add(this.labelDaemonStatusValue);
            this.Controls.Add(this.labelDaemonStatus);
            this.Name = "CloudManage";
            this.Size = new System.Drawing.Size(705, 346);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConfigFileValue;
        private System.Windows.Forms.Label labelConfigFolderPath;
        private System.Windows.Forms.Label labelDaemonStatusValue;
        private System.Windows.Forms.Label labelDaemonStatus;
        private System.Windows.Forms.DataGridView dataGridViewRepo;
        private System.Windows.Forms.Label labelDaemonPIDValue;
        private System.Windows.Forms.Label labelDaemonPID;
        private System.Windows.Forms.Label labelLoginValue;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPasswordValue;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelSynchroDateValue;
        private System.Windows.Forms.Label labelSynchroDate;
        private System.Windows.Forms.Button buttonSynchroStartStop;
        private System.Windows.Forms.DataGridViewImageColumn ColumnIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTypeName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnEnabled;
    }
}
