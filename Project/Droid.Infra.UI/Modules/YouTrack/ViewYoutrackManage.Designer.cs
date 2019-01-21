using Droid.Infra.Modules.Docker.View;

namespace Droid.Infra.UI.Modules.YouTrack.View
{
    partial class ViewYoutrackManage
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
            this._dataGridViewProjects = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this._superGridViewIssues = new Droid.Infra.Modules.Docker.View.SuperGrid();
            this.panelFooter = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._superGridViewIssues)).BeginInit();
            this.SuspendLayout();
            // 
            // _dataGridViewProjects
            // 
            this._dataGridViewProjects.AllowUserToAddRows = false;
            this._dataGridViewProjects.AllowUserToDeleteRows = false;
            this._dataGridViewProjects.AllowUserToResizeColumns = false;
            this._dataGridViewProjects.AllowUserToResizeRows = false;
            this._dataGridViewProjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._dataGridViewProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName});
            this._dataGridViewProjects.Location = new System.Drawing.Point(3, 3);
            this._dataGridViewProjects.Name = "_dataGridViewProjects";
            this._dataGridViewProjects.RowHeadersVisible = false;
            this._dataGridViewProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dataGridViewProjects.Size = new System.Drawing.Size(150, 494);
            this._dataGridViewProjects.TabIndex = 0;
            this._dataGridViewProjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dataGridViewProjects_CellClick);
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(159, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 54);
            this.panel1.TabIndex = 2;
            // 
            // _superGridViewIssues
            // 
            this._superGridViewIssues.AllowUserToAddRows = false;
            this._superGridViewIssues.AllowUserToDeleteRows = false;
            this._superGridViewIssues.AllowUserToResizeColumns = false;
            this._superGridViewIssues.AllowUserToResizeRows = false;
            this._superGridViewIssues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._superGridViewIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._superGridViewIssues.DefaultCellStyle = dataGridViewCellStyle2;
            this._superGridViewIssues.Location = new System.Drawing.Point(159, 63);
            this._superGridViewIssues.Name = "_superGridViewIssues";
            this._superGridViewIssues.PageSize = 10;
            this._superGridViewIssues.RowHeadersVisible = false;
            this._superGridViewIssues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._superGridViewIssues.Size = new System.Drawing.Size(638, 321);
            this._superGridViewIssues.TabIndex = 1;
            this._superGridViewIssues.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dataGridViewIssues_CellClick);
            // 
            // panelFooter
            // 
            this.panelFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFooter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFooter.Location = new System.Drawing.Point(159, 390);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(638, 107);
            this.panelFooter.TabIndex = 3;
            // 
            // ViewYoutrackManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._superGridViewIssues);
            this.Controls.Add(this._dataGridViewProjects);
            this.Name = "ViewYoutrackManage";
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._superGridViewIssues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _dataGridViewProjects;
        private SuperGrid _superGridViewIssues;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.Panel panelFooter;
    }
}
