namespace Droid.Infra.UI.Modules.Docker.View
{
    partial class ComponentDockerImage
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
            this.labelImageName = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelTag = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelImageName
            // 
            this.labelImageName.AutoSize = true;
            this.labelImageName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImageName.Location = new System.Drawing.Point(0, 0);
            this.labelImageName.Name = "labelImageName";
            this.labelImageName.Size = new System.Drawing.Size(41, 15);
            this.labelImageName.TabIndex = 0;
            this.labelImageName.Text = "NAME";
            this.labelImageName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(5, 18);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxIcon.TabIndex = 1;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelTag
            // 
            this.labelTag.AutoSize = true;
            this.labelTag.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTag.Location = new System.Drawing.Point(51, 23);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(27, 15);
            this.labelTag.TabIndex = 2;
            this.labelTag.Text = "TAG";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.Location = new System.Drawing.Point(51, 38);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(28, 15);
            this.labelSize.TabIndex = 3;
            this.labelSize.Text = "Size";
            // 
            // ComponentDockerImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelTag);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.labelImageName);
            this.Name = "ComponentDockerImage";
            this.Size = new System.Drawing.Size(150, 63);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImageName;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelTag;
        private System.Windows.Forms.Label labelSize;
    }
}
