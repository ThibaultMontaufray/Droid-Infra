namespace Droid.Infra.UI.Modules.Docker.View
{
    partial class ViewNetworks
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewNetwork = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnScope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInspect = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNetwork)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 43);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewNetwork
            // 
            this.dataGridViewNetwork.AllowUserToAddRows = false;
            this.dataGridViewNetwork.AllowUserToDeleteRows = false;
            this.dataGridViewNetwork.AllowUserToResizeColumns = false;
            this.dataGridViewNetwork.AllowUserToResizeRows = false;
            this.dataGridViewNetwork.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewNetwork.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNetwork.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridViewNetwork.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNetwork.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewNetwork.ColumnHeadersHeight = 25;
            this.dataGridViewNetwork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewNetwork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnDriver,
            this.ColumnScope,
            this.ColumnInspect,
            this.ColumnDelete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNetwork.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNetwork.EnableHeadersVisualStyles = false;
            this.dataGridViewNetwork.Location = new System.Drawing.Point(0, 43);
            this.dataGridViewNetwork.Name = "dataGridViewNetwork";
            this.dataGridViewNetwork.RowHeadersVisible = false;
            this.dataGridViewNetwork.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNetwork.Size = new System.Drawing.Size(508, 301);
            this.dataGridViewNetwork.TabIndex = 1;
            this.dataGridViewNetwork.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNetwork_CellContentDoubleClick);
            // 
            // ColumnId
            // 
            this.ColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnId.Width = 41;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnDriver
            // 
            this.ColumnDriver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnDriver.HeaderText = "Driver";
            this.ColumnDriver.Name = "ColumnDriver";
            this.ColumnDriver.Width = 62;
            // 
            // ColumnScope
            // 
            this.ColumnScope.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnScope.HeaderText = "Scope";
            this.ColumnScope.Name = "ColumnScope";
            this.ColumnScope.Width = 62;
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
            // ColumnDelete
            // 
            this.ColumnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnDelete.HeaderText = "";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.Width = 5;
            // 
            // ViewNetworks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.dataGridViewNetwork);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ViewNetworks";
            this.Size = new System.Drawing.Size(508, 344);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNetwork)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewNetwork;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnScope;
        private System.Windows.Forms.DataGridViewImageColumn ColumnInspect;
        private System.Windows.Forms.DataGridViewImageColumn ColumnDelete;
    }
}
