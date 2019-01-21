namespace Droid.Infra.UI.Modules.Docker.View
{
    partial class ViewImages
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
            this.dataGridViewImages = new System.Windows.Forms.DataGridView();
            this.ColumnIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRepository = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInspect = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImages)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 193);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewImages
            // 
            this.dataGridViewImages.AllowUserToAddRows = false;
            this.dataGridViewImages.AllowUserToDeleteRows = false;
            this.dataGridViewImages.AllowUserToResizeColumns = false;
            this.dataGridViewImages.AllowUserToResizeRows = false;
            this.dataGridViewImages.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewImages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewImages.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridViewImages.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewImages.ColumnHeadersHeight = 25;
            this.dataGridViewImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewImages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIcon,
            this.ColumnId,
            this.ColumnRepository,
            this.ColumnTag,
            this.ColumnCreated,
            this.ColumnSize,
            this.ColumnInspect,
            this.ColumnDelete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImages.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewImages.EnableHeadersVisualStyles = false;
            this.dataGridViewImages.Location = new System.Drawing.Point(0, 193);
            this.dataGridViewImages.Name = "dataGridViewImages";
            this.dataGridViewImages.RowHeadersVisible = false;
            this.dataGridViewImages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewImages.Size = new System.Drawing.Size(700, 226);
            this.dataGridViewImages.TabIndex = 1;
            this.dataGridViewImages.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewImages_CellContentDoubleClick);
            // 
            // ColumnIcon
            // 
            this.ColumnIcon.HeaderText = "";
            this.ColumnIcon.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnIcon.Name = "ColumnIcon";
            // 
            // ColumnId
            // 
            this.ColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnId.Width = 41;
            // 
            // ColumnRepository
            // 
            this.ColumnRepository.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnRepository.HeaderText = "Repository";
            this.ColumnRepository.Name = "ColumnRepository";
            // 
            // ColumnTag
            // 
            this.ColumnTag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnTag.HeaderText = "Tag";
            this.ColumnTag.Name = "ColumnTag";
            this.ColumnTag.Width = 48;
            // 
            // ColumnCreated
            // 
            this.ColumnCreated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnCreated.HeaderText = "Created";
            this.ColumnCreated.Name = "ColumnCreated";
            this.ColumnCreated.Width = 72;
            // 
            // ColumnSize
            // 
            this.ColumnSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnSize.HeaderText = "Size";
            this.ColumnSize.Name = "ColumnSize";
            this.ColumnSize.Width = 52;
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
            // ViewImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.dataGridViewImages);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ViewImages";
            this.Size = new System.Drawing.Size(700, 419);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewImages;
        private System.Windows.Forms.DataGridViewImageColumn ColumnIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRepository;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSize;
        private System.Windows.Forms.DataGridViewImageColumn ColumnInspect;
        private System.Windows.Forms.DataGridViewImageColumn ColumnDelete;
    }
}
