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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.buttonBrowseNewRepo = new System.Windows.Forms.Button();
            this.textBoxRepoToAssociate = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxConfigPath = new System.Windows.Forms.TextBox();
            this.comboBoxConnectionType = new System.Windows.Forms.ComboBox();
            this.buttonBrowseConfigPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBrowseOriginPath = new System.Windows.Forms.Button();
            this.textBoxOriginPath = new System.Windows.Forms.TextBox();
            this.groupBoxCreation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCreation
            // 
            this.groupBoxCreation.Controls.Add(this.buttonAddRepo);
            this.groupBoxCreation.Controls.Add(this.dataGridViewRepo);
            this.groupBoxCreation.Controls.Add(this.comboBoxConnectionAddedRepo);
            this.groupBoxCreation.Controls.Add(this.label2);
            this.groupBoxCreation.Controls.Add(this.buttonBrowseNewRepo);
            this.groupBoxCreation.Controls.Add(this.textBoxRepoToAssociate);
            this.groupBoxCreation.Controls.Add(this.label);
            this.groupBoxCreation.Controls.Add(this.buttonUpdate);
            this.groupBoxCreation.Controls.Add(this.textBoxConfigPath);
            this.groupBoxCreation.Controls.Add(this.comboBoxConnectionType);
            this.groupBoxCreation.Controls.Add(this.buttonBrowseConfigPath);
            this.groupBoxCreation.Controls.Add(this.label1);
            this.groupBoxCreation.Controls.Add(this.buttonBrowseOriginPath);
            this.groupBoxCreation.Controls.Add(this.textBoxOriginPath);
            this.groupBoxCreation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCreation.ForeColor = System.Drawing.Color.White;
            this.groupBoxCreation.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCreation.Name = "groupBoxCreation";
            this.groupBoxCreation.Size = new System.Drawing.Size(711, 330);
            this.groupBoxCreation.TabIndex = 15;
            this.groupBoxCreation.TabStop = false;
            this.groupBoxCreation.Text = "Cloud";
            // 
            // buttonAddRepo
            // 
            this.buttonAddRepo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddRepo.ForeColor = System.Drawing.Color.Black;
            this.buttonAddRepo.Location = new System.Drawing.Point(608, 83);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRepo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRepo.Location = new System.Drawing.Point(10, 117);
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
            this.comboBoxConnectionAddedRepo.Location = new System.Drawing.Point(387, 84);
            this.comboBoxConnectionAddedRepo.Name = "comboBoxConnectionAddedRepo";
            this.comboBoxConnectionAddedRepo.Size = new System.Drawing.Size(125, 27);
            this.comboBoxConnectionAddedRepo.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Add repository";
            // 
            // buttonBrowseNewRepo
            // 
            this.buttonBrowseNewRepo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowseNewRepo.ForeColor = System.Drawing.Color.Black;
            this.buttonBrowseNewRepo.Location = new System.Drawing.Point(513, 83);
            this.buttonBrowseNewRepo.Name = "buttonBrowseNewRepo";
            this.buttonBrowseNewRepo.Size = new System.Drawing.Size(94, 28);
            this.buttonBrowseNewRepo.TabIndex = 11;
            this.buttonBrowseNewRepo.Text = "Browse";
            this.buttonBrowseNewRepo.UseVisualStyleBackColor = true;
            this.buttonBrowseNewRepo.Click += new System.EventHandler(this.buttonBrowseAddRepository_Click);
            // 
            // textBoxRepoToAssociate
            // 
            this.textBoxRepoToAssociate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRepoToAssociate.ForeColor = System.Drawing.Color.Black;
            this.textBoxRepoToAssociate.Location = new System.Drawing.Point(175, 84);
            this.textBoxRepoToAssociate.Name = "textBoxRepoToAssociate";
            this.textBoxRepoToAssociate.Size = new System.Drawing.Size(209, 27);
            this.textBoxRepoToAssociate.TabIndex = 10;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(6, 29);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(122, 19);
            this.label.TabIndex = 0;
            this.label.Text = "Cloud config path";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.Black;
            this.buttonUpdate.Location = new System.Drawing.Point(608, 26);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(94, 56);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Create cloud";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonCreateCloud_Click);
            // 
            // textBoxConfigPath
            // 
            this.textBoxConfigPath.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfigPath.ForeColor = System.Drawing.Color.Black;
            this.textBoxConfigPath.Location = new System.Drawing.Point(175, 26);
            this.textBoxConfigPath.Name = "textBoxConfigPath";
            this.textBoxConfigPath.Size = new System.Drawing.Size(337, 27);
            this.textBoxConfigPath.TabIndex = 1;
            // 
            // comboBoxConnectionType
            // 
            this.comboBoxConnectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConnectionType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxConnectionType.ForeColor = System.Drawing.Color.Black;
            this.comboBoxConnectionType.FormattingEnabled = true;
            this.comboBoxConnectionType.Location = new System.Drawing.Point(387, 55);
            this.comboBoxConnectionType.Name = "comboBoxConnectionType";
            this.comboBoxConnectionType.Size = new System.Drawing.Size(125, 27);
            this.comboBoxConnectionType.TabIndex = 7;
            // 
            // buttonBrowseConfigPath
            // 
            this.buttonBrowseConfigPath.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowseConfigPath.ForeColor = System.Drawing.Color.Black;
            this.buttonBrowseConfigPath.Location = new System.Drawing.Point(513, 26);
            this.buttonBrowseConfigPath.Name = "buttonBrowseConfigPath";
            this.buttonBrowseConfigPath.Size = new System.Drawing.Size(94, 27);
            this.buttonBrowseConfigPath.TabIndex = 2;
            this.buttonBrowseConfigPath.Text = "Browse";
            this.buttonBrowseConfigPath.UseVisualStyleBackColor = true;
            this.buttonBrowseConfigPath.Click += new System.EventHandler(this.buttonBrowseConfigPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Origin path";
            // 
            // buttonBrowseOriginPath
            // 
            this.buttonBrowseOriginPath.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowseOriginPath.ForeColor = System.Drawing.Color.Black;
            this.buttonBrowseOriginPath.Location = new System.Drawing.Point(513, 54);
            this.buttonBrowseOriginPath.Name = "buttonBrowseOriginPath";
            this.buttonBrowseOriginPath.Size = new System.Drawing.Size(94, 28);
            this.buttonBrowseOriginPath.TabIndex = 5;
            this.buttonBrowseOriginPath.Text = "Browse";
            this.buttonBrowseOriginPath.UseVisualStyleBackColor = true;
            this.buttonBrowseOriginPath.Click += new System.EventHandler(this.buttonBrowseOriginPath_Click);
            // 
            // textBoxOriginPath
            // 
            this.textBoxOriginPath.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOriginPath.ForeColor = System.Drawing.Color.Black;
            this.textBoxOriginPath.Location = new System.Drawing.Point(175, 55);
            this.textBoxOriginPath.Name = "textBoxOriginPath";
            this.textBoxOriginPath.Size = new System.Drawing.Size(209, 27);
            this.textBoxOriginPath.TabIndex = 4;
            // 
            // CloudView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBoxCreation);
            this.Name = "CloudView";
            this.Size = new System.Drawing.Size(719, 336);
            this.groupBoxCreation.ResumeLayout(false);
            this.groupBoxCreation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCreation;
        private System.Windows.Forms.ComboBox comboBoxConnectionAddedRepo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBrowseNewRepo;
        private System.Windows.Forms.TextBox textBoxRepoToAssociate;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxConfigPath;
        private System.Windows.Forms.ComboBox comboBoxConnectionType;
        private System.Windows.Forms.Button buttonBrowseConfigPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBrowseOriginPath;
        private System.Windows.Forms.TextBox textBoxOriginPath;
        private System.Windows.Forms.DataGridView dataGridViewRepo;
        private System.Windows.Forms.DataGridViewImageColumn ColumnIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTypeName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnEnabled;
        private System.Windows.Forms.Button buttonAddRepo;
    }
}
