namespace Droid_Infra
{
    partial class CloudView
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
            this.groupBoxCreation = new System.Windows.Forms.GroupBox();
            this.buttonAddRepo = new System.Windows.Forms.Button();
            this.dataGridViewRepo = new System.Windows.Forms.DataGridView();
            this.ColumnIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.comboBoxConnectionAddedRepo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRepoToAssociate = new System.Windows.Forms.TextBox();
            this.labelDaemonStatus = new System.Windows.Forms.Label();
            this.labelDaemonStatusValue = new System.Windows.Forms.Label();
            this.labelConfigFolderPath = new System.Windows.Forms.Label();
            this.labelConfigFileValue = new System.Windows.Forms.Label();
            this.groupBoxCreation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCreation
            // 
            this.groupBoxCreation.Controls.Add(this.labelConfigFileValue);
            this.groupBoxCreation.Controls.Add(this.labelConfigFolderPath);
            this.groupBoxCreation.Controls.Add(this.labelDaemonStatusValue);
            this.groupBoxCreation.Controls.Add(this.labelDaemonStatus);
            this.groupBoxCreation.Controls.Add(this.buttonAddRepo);
            this.groupBoxCreation.Controls.Add(this.dataGridViewRepo);
            this.groupBoxCreation.Controls.Add(this.comboBoxConnectionAddedRepo);
            this.groupBoxCreation.Controls.Add(this.label2);
            this.groupBoxCreation.Controls.Add(this.textBoxRepoToAssociate);
            this.groupBoxCreation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCreation.ForeColor = System.Drawing.Color.White;
            this.groupBoxCreation.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCreation.Name = "groupBoxCreation";
            this.groupBoxCreation.Size = new System.Drawing.Size(716, 359);
            this.groupBoxCreation.TabIndex = 15;
            this.groupBoxCreation.TabStop = false;
            this.groupBoxCreation.Text = "Cloud";
            // 
            // buttonAddRepo
            // 
            this.buttonAddRepo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddRepo.ForeColor = System.Drawing.Color.Black;
            this.buttonAddRepo.Location = new System.Drawing.Point(611, 22);
            this.buttonAddRepo.Name = "buttonAddRepo";
            this.buttonAddRepo.Size = new System.Drawing.Size(94, 27);
            this.buttonAddRepo.TabIndex = 14;
            this.buttonAddRepo.Text = "Add repo";
            this.buttonAddRepo.UseVisualStyleBackColor = true;
            this.buttonAddRepo.Click += new System.EventHandler(this.buttonAddRepo_Click);
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
            this.dataGridViewRepo.Location = new System.Drawing.Point(13, 56);
            this.dataGridViewRepo.Name = "dataGridViewRepo";
            this.dataGridViewRepo.RowHeadersVisible = false;
            this.dataGridViewRepo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRepo.Size = new System.Drawing.Size(692, 201);
            this.dataGridViewRepo.TabIndex = 13;
            // 
            // ColumnIcon
            // 
            this.ColumnIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.ColumnIcon.HeaderText = "";
            this.ColumnIcon.Name = "ColumnIcon";
            this.ColumnIcon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnIcon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnIcon.Width = 5;
            // 
            // ColumnId
            // 
            this.ColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Width = 47;
            // 
            // ColumnPath
            // 
            this.ColumnPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPath.HeaderText = "Path";
            this.ColumnPath.Name = "ColumnPath";
            // 
            // ColumnTypeName
            // 
            this.ColumnTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnTypeName.HeaderText = "Type";
            this.ColumnTypeName.Name = "ColumnTypeName";
            this.ColumnTypeName.Width = 67;
            // 
            // ColumnEnabled
            // 
            this.ColumnEnabled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnEnabled.HeaderText = "Synchronised";
            this.ColumnEnabled.Name = "ColumnEnabled";
            this.ColumnEnabled.Width = 107;
            // 
            // comboBoxConnectionAddedRepo
            // 
            this.comboBoxConnectionAddedRepo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConnectionAddedRepo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxConnectionAddedRepo.ForeColor = System.Drawing.Color.Black;
            this.comboBoxConnectionAddedRepo.FormattingEnabled = true;
            this.comboBoxConnectionAddedRepo.Location = new System.Drawing.Point(390, 23);
            this.comboBoxConnectionAddedRepo.Name = "comboBoxConnectionAddedRepo";
            this.comboBoxConnectionAddedRepo.Size = new System.Drawing.Size(125, 27);
            this.comboBoxConnectionAddedRepo.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Add repository";
            // 
            // textBoxRepoToAssociate
            // 
            this.textBoxRepoToAssociate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRepoToAssociate.ForeColor = System.Drawing.Color.Black;
            this.textBoxRepoToAssociate.Location = new System.Drawing.Point(178, 23);
            this.textBoxRepoToAssociate.Name = "textBoxRepoToAssociate";
            this.textBoxRepoToAssociate.Size = new System.Drawing.Size(209, 27);
            this.textBoxRepoToAssociate.TabIndex = 10;
            // 
            // labelDaemonStatus
            // 
            this.labelDaemonStatus.AutoSize = true;
            this.labelDaemonStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaemonStatus.ForeColor = System.Drawing.Color.White;
            this.labelDaemonStatus.Location = new System.Drawing.Point(10, 276);
            this.labelDaemonStatus.Name = "labelDaemonStatus";
            this.labelDaemonStatus.Size = new System.Drawing.Size(107, 19);
            this.labelDaemonStatus.TabIndex = 15;
            this.labelDaemonStatus.Text = "Daemon status";
            // 
            // labelDaemonStatusValue
            // 
            this.labelDaemonStatusValue.AutoSize = true;
            this.labelDaemonStatusValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaemonStatusValue.ForeColor = System.Drawing.Color.White;
            this.labelDaemonStatusValue.Location = new System.Drawing.Point(174, 276);
            this.labelDaemonStatusValue.Name = "labelDaemonStatusValue";
            this.labelDaemonStatusValue.Size = new System.Drawing.Size(65, 19);
            this.labelDaemonStatusValue.TabIndex = 16;
            this.labelDaemonStatusValue.Text = "_______";
            // 
            // labelConfigFolderPath
            // 
            this.labelConfigFolderPath.AutoSize = true;
            this.labelConfigFolderPath.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfigFolderPath.ForeColor = System.Drawing.Color.White;
            this.labelConfigFolderPath.Location = new System.Drawing.Point(10, 311);
            this.labelConfigFolderPath.Name = "labelConfigFolderPath";
            this.labelConfigFolderPath.Size = new System.Drawing.Size(125, 19);
            this.labelConfigFolderPath.TabIndex = 17;
            this.labelConfigFolderPath.Text = "Config folder path";
            // 
            // labelConfigFileValue
            // 
            this.labelConfigFileValue.AutoSize = true;
            this.labelConfigFileValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfigFileValue.ForeColor = System.Drawing.Color.White;
            this.labelConfigFileValue.Location = new System.Drawing.Point(174, 311);
            this.labelConfigFileValue.Name = "labelConfigFileValue";
            this.labelConfigFileValue.Size = new System.Drawing.Size(65, 19);
            this.labelConfigFileValue.TabIndex = 18;
            this.labelConfigFileValue.Text = "_______";
            // 
            // CloudView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBoxCreation);
            this.Name = "CloudView";
            this.Size = new System.Drawing.Size(719, 364);
            this.groupBoxCreation.ResumeLayout(false);
            this.groupBoxCreation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCreation;
        private System.Windows.Forms.ComboBox comboBoxConnectionAddedRepo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRepoToAssociate;
        private System.Windows.Forms.DataGridView dataGridViewRepo;
        private System.Windows.Forms.DataGridViewImageColumn ColumnIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTypeName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnEnabled;
        private System.Windows.Forms.Button buttonAddRepo;
        private System.Windows.Forms.Label labelDaemonStatus;
        private System.Windows.Forms.Label labelDaemonStatusValue;
        private System.Windows.Forms.Label labelConfigFileValue;
        private System.Windows.Forms.Label labelConfigFolderPath;
    }
}
