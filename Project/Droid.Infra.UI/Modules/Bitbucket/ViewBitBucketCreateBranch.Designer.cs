namespace Droid.Infra.UI.Modules.Bitbucket.View
{
    partial class ViewBitBucketCreateBranch
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
            this.labelBranch = new System.Windows.Forms.Label();
            this.comboBoxBranch = new System.Windows.Forms.ComboBox();
            this.comboBoxRevision = new System.Windows.Forms.ComboBox();
            this.labelRevision = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBranch
            // 
            this.labelBranch.AutoSize = true;
            this.labelBranch.Location = new System.Drawing.Point(3, 6);
            this.labelBranch.Name = "labelBranch";
            this.labelBranch.Size = new System.Drawing.Size(86, 15);
            this.labelBranch.TabIndex = 0;
            this.labelBranch.Text = "Source branch";
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBranch.FormattingEnabled = true;
            this.comboBoxBranch.Location = new System.Drawing.Point(134, 3);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(465, 23);
            this.comboBoxBranch.TabIndex = 1;
            this.comboBoxBranch.SelectedIndexChanged += new System.EventHandler(this.comboBoxBranch_SelectedIndexChanged);
            // 
            // comboBoxRevision
            // 
            this.comboBoxRevision.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRevision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRevision.FormattingEnabled = true;
            this.comboBoxRevision.Location = new System.Drawing.Point(134, 32);
            this.comboBoxRevision.Name = "comboBoxRevision";
            this.comboBoxRevision.Size = new System.Drawing.Size(465, 23);
            this.comboBoxRevision.TabIndex = 3;
            // 
            // labelRevision
            // 
            this.labelRevision.AutoSize = true;
            this.labelRevision.Location = new System.Drawing.Point(3, 35);
            this.labelRevision.Name = "labelRevision";
            this.labelRevision.Size = new System.Drawing.Size(54, 15);
            this.labelRevision.TabIndex = 2;
            this.labelRevision.Text = "Revision";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(134, 61);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(379, 23);
            this.textBoxName.TabIndex = 4;
            // 
            // buttonGo
            // 
            this.buttonGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGo.Location = new System.Drawing.Point(524, 61);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 5;
            this.buttonGo.Text = "Create";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 65);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 15);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name";
            // 
            // ViewBitBucketCreateBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBoxRevision);
            this.Controls.Add(this.labelRevision);
            this.Controls.Add(this.comboBoxBranch);
            this.Controls.Add(this.labelBranch);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ViewBitBucketCreateBranch";
            this.Size = new System.Drawing.Size(602, 91);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBranch;
        private System.Windows.Forms.ComboBox comboBoxBranch;
        private System.Windows.Forms.ComboBox comboBoxRevision;
        private System.Windows.Forms.Label labelRevision;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label labelName;
    }
}
