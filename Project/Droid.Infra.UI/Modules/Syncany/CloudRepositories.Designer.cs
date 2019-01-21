namespace Droid.Infra.UI
{
    partial class CloudRepositories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonAddRepo = new System.Windows.Forms.Button();
            this.dataGridViewRepo = new System.Windows.Forms.DataGridView();
            this.comboBoxConnectionAddedRepo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRepoToAssociate = new System.Windows.Forms.TextBox();
            this.ColumnIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Font = new System.Drawing.Font("Calibri", 10F);
            this.buttonBrowse.ForeColor = System.Drawing.Color.Black;
            this.buttonBrowse.Location = new System.Drawing.Point(510, -3);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(94, 24);
            this.buttonBrowse.TabIndex = 25;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click_1);
            // 
            // buttonAddRepo
            // 
            this.buttonAddRepo.Font = new System.Drawing.Font("Calibri", 10F);
            this.buttonAddRepo.ForeColor = System.Drawing.Color.Black;
            this.buttonAddRepo.Location = new System.Drawing.Point(604, -3);
            this.buttonAddRepo.Name = "buttonAddRepo";
            this.buttonAddRepo.Size = new System.Drawing.Size(94, 24);
            this.buttonAddRepo.TabIndex = 24;
            this.buttonAddRepo.Text = "Add repo";
            this.buttonAddRepo.UseVisualStyleBackColor = true;
            this.buttonAddRepo.Click += new System.EventHandler(this.buttonAddRepo_Click_1);
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
            this.dataGridViewRepo.Location = new System.Drawing.Point(6, 27);
            this.dataGridViewRepo.Name = "dataGridViewRepo";
            this.dataGridViewRepo.RowHeadersVisible = false;
            this.dataGridViewRepo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRepo.Size = new System.Drawing.Size(692, 204);
            this.dataGridViewRepo.TabIndex = 23;
            // 
            // comboBoxConnectionAddedRepo
            // 
            this.comboBoxConnectionAddedRepo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConnectionAddedRepo.Font = new System.Drawing.Font("Calibri", 10F);
            this.comboBoxConnectionAddedRepo.ForeColor = System.Drawing.Color.Black;
            this.comboBoxConnectionAddedRepo.FormattingEnabled = true;
            this.comboBoxConnectionAddedRepo.Location = new System.Drawing.Point(383, -3);
            this.comboBoxConnectionAddedRepo.Name = "comboBoxConnectionAddedRepo";
            this.comboBoxConnectionAddedRepo.Size = new System.Drawing.Size(125, 23);
            this.comboBoxConnectionAddedRepo.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Add repository";
            // 
            // textBoxRepoToAssociate
            // 
            this.textBoxRepoToAssociate.Font = new System.Drawing.Font("Calibri", 10F);
            this.textBoxRepoToAssociate.ForeColor = System.Drawing.Color.Black;
            this.textBoxRepoToAssociate.Location = new System.Drawing.Point(171, -3);
            this.textBoxRepoToAssociate.Name = "textBoxRepoToAssociate";
            this.textBoxRepoToAssociate.Size = new System.Drawing.Size(209, 24);
            this.textBoxRepoToAssociate.TabIndex = 21;
            // 
            // ColumnIcon
            // 
            this.ColumnIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
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
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnPath.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnPath.HeaderText = "Path";
            this.ColumnPath.Name = "ColumnPath";
            // 
            // ColumnTypeName
            // 
            this.ColumnTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
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
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.ColumnEnabled.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnEnabled.HeaderText = "Synchronised";
            this.ColumnEnabled.Name = "ColumnEnabled";
            this.ColumnEnabled.Width = 77;
            // 
            // CloudRepositories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.buttonAddRepo);
            this.Controls.Add(this.dataGridViewRepo);
            this.Controls.Add(this.comboBoxConnectionAddedRepo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRepoToAssociate);
            this.Name = "CloudRepositories";
            this.Size = new System.Drawing.Size(700, 237);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonAddRepo;
        private System.Windows.Forms.DataGridView dataGridViewRepo;
        private System.Windows.Forms.ComboBox comboBoxConnectionAddedRepo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRepoToAssociate;
        private System.Windows.Forms.DataGridViewImageColumn ColumnIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTypeName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnEnabled;
    }
}
