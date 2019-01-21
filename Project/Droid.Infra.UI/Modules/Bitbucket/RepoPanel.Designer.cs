namespace Droid.Infra.UI.Modules.Bitbucket.View
{
    partial class RepoPanel
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewCommit = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewFileList = new System.Windows.Forms.DataGridView();
            this.textBoxFileFiltering = new System.Windows.Forms.TextBox();
            this.richTextBoxFileDescription = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ColumnRevision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileList)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewCommit);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(624, 515);
            this.splitContainer1.SplitterDistance = 224;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridViewCommit
            // 
            this.dataGridViewCommit.AllowUserToAddRows = false;
            this.dataGridViewCommit.AllowUserToDeleteRows = false;
            this.dataGridViewCommit.AllowUserToResizeRows = false;
            this.dataGridViewCommit.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCommit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCommit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRevision,
            this.ColumnBranch,
            this.ColumnDescription,
            this.ColumnAuthor,
            this.ColumnAge,
            this.ColumnTag,
            this.ColumnStep});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCommit.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCommit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCommit.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCommit.Name = "dataGridViewCommit";
            this.dataGridViewCommit.RowHeadersVisible = false;
            this.dataGridViewCommit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCommit.Size = new System.Drawing.Size(624, 224);
            this.dataGridViewCommit.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridViewFileList);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxFileFiltering);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.richTextBoxFileDescription);
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Panel2.Controls.Add(this.textBox1);
            this.splitContainer2.Size = new System.Drawing.Size(624, 287);
            this.splitContainer2.SplitterDistance = 208;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridViewFileList
            // 
            this.dataGridViewFileList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFileList.Location = new System.Drawing.Point(0, 22);
            this.dataGridViewFileList.Name = "dataGridViewFileList";
            this.dataGridViewFileList.Size = new System.Drawing.Size(208, 265);
            this.dataGridViewFileList.TabIndex = 1;
            // 
            // textBoxFileFiltering
            // 
            this.textBoxFileFiltering.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxFileFiltering.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxFileFiltering.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFileFiltering.Location = new System.Drawing.Point(0, 0);
            this.textBoxFileFiltering.Name = "textBoxFileFiltering";
            this.textBoxFileFiltering.Size = new System.Drawing.Size(208, 22);
            this.textBoxFileFiltering.TabIndex = 0;
            this.textBoxFileFiltering.Text = "### Filtering ###";
            // 
            // richTextBoxFileDescription
            // 
            this.richTextBoxFileDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxFileDescription.Location = new System.Drawing.Point(0, 92);
            this.richTextBoxFileDescription.Name = "richTextBoxFileDescription";
            this.richTextBoxFileDescription.Size = new System.Drawing.Size(412, 195);
            this.richTextBoxFileDescription.TabIndex = 2;
            this.richTextBoxFileDescription.Text = "";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 37);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(412, 55);
            this.textBox1.TabIndex = 0;
            // 
            // ColumnRevision
            // 
            this.ColumnRevision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnRevision.HeaderText = "Revision";
            this.ColumnRevision.Name = "ColumnRevision";
            this.ColumnRevision.Width = 79;
            // 
            // ColumnBranch
            // 
            this.ColumnBranch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnBranch.HeaderText = "Branch";
            this.ColumnBranch.Name = "ColumnBranch";
            this.ColumnBranch.Width = 69;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDescription.HeaderText = "Description";
            this.ColumnDescription.Name = "ColumnDescription";
            // 
            // ColumnAuthor
            // 
            this.ColumnAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnAuthor.HeaderText = "Author";
            this.ColumnAuthor.Name = "ColumnAuthor";
            this.ColumnAuthor.Width = 68;
            // 
            // ColumnAge
            // 
            this.ColumnAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnAge.HeaderText = "Age";
            this.ColumnAge.Name = "ColumnAge";
            this.ColumnAge.Width = 52;
            // 
            // ColumnTag
            // 
            this.ColumnTag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnTag.HeaderText = "Tag";
            this.ColumnTag.Name = "ColumnTag";
            this.ColumnTag.Width = 50;
            // 
            // ColumnStep
            // 
            this.ColumnStep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnStep.HeaderText = "Step";
            this.ColumnStep.Name = "ColumnStep";
            this.ColumnStep.Width = 56;
            // 
            // RepoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RepoPanel";
            this.Size = new System.Drawing.Size(624, 515);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommit)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewCommit;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textBoxFileFiltering;
        private System.Windows.Forms.DataGridView dataGridViewFileList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBoxFileDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRevision;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStep;
    }
}
