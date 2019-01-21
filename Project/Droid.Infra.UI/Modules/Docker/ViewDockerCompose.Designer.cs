namespace Droid.Infra.UI.Modules.Docker.View
{
    partial class ViewDockerCompose
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
            this.dataGridViewCompose = new System.Windows.Forms.DataGridView();
            this.ColumnIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInspect = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnStop = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnPause = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompose)).BeginInit();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCompose
            // 
            this.dataGridViewCompose.AllowUserToAddRows = false;
            this.dataGridViewCompose.AllowUserToDeleteRows = false;
            this.dataGridViewCompose.AllowUserToResizeColumns = false;
            this.dataGridViewCompose.AllowUserToResizeRows = false;
            this.dataGridViewCompose.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewCompose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCompose.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridViewCompose.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCompose.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCompose.ColumnHeadersHeight = 25;
            this.dataGridViewCompose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCompose.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIcon,
            this.ColumnPath,
            this.ColumnStatus,
            this.ColumnInspect,
            this.ColumnStop,
            this.ColumnPause,
            this.ColumnDelete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCompose.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCompose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCompose.EnableHeadersVisualStyles = false;
            this.dataGridViewCompose.Location = new System.Drawing.Point(0, 33);
            this.dataGridViewCompose.Name = "dataGridViewCompose";
            this.dataGridViewCompose.RowHeadersVisible = false;
            this.dataGridViewCompose.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCompose.Size = new System.Drawing.Size(760, 226);
            this.dataGridViewCompose.TabIndex = 2;
            this.dataGridViewCompose.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCompose_CellContentClick);
            // 
            // ColumnIcon
            // 
            this.ColumnIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnIcon.HeaderText = "";
            this.ColumnIcon.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnIcon.Name = "ColumnIcon";
            this.ColumnIcon.Width = 5;
            // 
            // ColumnPath
            // 
            this.ColumnPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPath.HeaderText = "Path";
            this.ColumnPath.Name = "ColumnPath";
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.Width = 64;
            // 
            // ColumnInspect
            // 
            this.ColumnInspect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnInspect.HeaderText = "";
            this.ColumnInspect.Name = "ColumnInspect";
            this.ColumnInspect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnInspect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnInspect.Width = 17;
            // 
            // ColumnStartStop
            // 
            this.ColumnStop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnStop.HeaderText = "";
            this.ColumnStop.Name = "ColumnStartStop";
            this.ColumnStop.Width = 5;
            // 
            // ColumnPause
            // 
            this.ColumnPause.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnPause.HeaderText = "";
            this.ColumnPause.Name = "ColumnPause";
            this.ColumnPause.Width = 5;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnDelete.HeaderText = "";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.Width = 5;
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.Transparent;
            this.panelFilter.Controls.Add(this.buttonBrowse);
            this.panelFilter.Controls.Add(this.textBoxPath);
            this.panelFilter.Controls.Add(this.buttonAdd);
            this.panelFilter.Controls.Add(this.labelPath);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 0);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(760, 33);
            this.panelFilter.TabIndex = 3;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.BackColor = System.Drawing.Color.DimGray;
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowse.ForeColor = System.Drawing.Color.Black;
            this.buttonBrowse.Location = new System.Drawing.Point(601, 5);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 6;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.Location = new System.Drawing.Point(168, 5);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(427, 23);
            this.textBoxPath.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.DimGray;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(682, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(3, 8);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(159, 15);
            this.labelPath.TabIndex = 0;
            this.labelPath.Text = "Path of docker-compose file";
            // 
            // ViewDockerCompose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.dataGridViewCompose);
            this.Controls.Add(this.panelFilter);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "ViewDockerCompose";
            this.Size = new System.Drawing.Size(760, 259);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompose)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCompose;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.DataGridViewImageColumn ColumnIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewImageColumn ColumnInspect;
        private System.Windows.Forms.DataGridViewImageColumn ColumnStop;
        private System.Windows.Forms.DataGridViewImageColumn ColumnPause;
        private System.Windows.Forms.DataGridViewImageColumn ColumnDelete;
        private System.Windows.Forms.Button buttonBrowse;
    }
}
