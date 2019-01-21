namespace Droid.Infra.UI
{
    partial class ViewBitBucketSetting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelName = new System.Windows.Forms.Label();
            this.dataGridViewRepo = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.DimGray;
            this.labelName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(33, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(424, 32);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewRepo
            // 
            this.dataGridViewRepo.AllowUserToAddRows = false;
            this.dataGridViewRepo.AllowUserToDeleteRows = false;
            this.dataGridViewRepo.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridViewRepo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRepo.ColumnHeadersVisible = false;
            this.dataGridViewRepo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnCreation,
            this.ColumnOwner});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRepo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRepo.Location = new System.Drawing.Point(0, 48);
            this.dataGridViewRepo.Name = "dataGridViewRepo";
            this.dataGridViewRepo.RowHeadersVisible = false;
            this.dataGridViewRepo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRepo.Size = new System.Drawing.Size(454, 150);
            this.dataGridViewRepo.TabIndex = 13;
            this.dataGridViewRepo.SelectionChanged += new System.EventHandler(this.dataGridViewRepo_SelectionChanged);
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "ColumnName";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnCreation
            // 
            this.ColumnCreation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.ColumnCreation.HeaderText = "ColumnCreation";
            this.ColumnCreation.Name = "ColumnCreation";
            this.ColumnCreation.Width = 5;
            // 
            // ColumnOwner
            // 
            this.ColumnOwner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.ColumnOwner.HeaderText = "ColumnOwner";
            this.ColumnOwner.Name = "ColumnOwner";
            this.ColumnOwner.Width = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // ViewBitBucketUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewRepo);
            this.Controls.Add(this.labelName);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ViewBitBucketUser";
            this.Size = new System.Drawing.Size(457, 430);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView dataGridViewRepo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCreation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOwner;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
