namespace Droid.Infra.UI
{
    partial class ComponentComputer
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
            this.labelRam = new System.Windows.Forms.Label();
            this.labelDisk = new System.Windows.Forms.Label();
            this.labelOs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelRam
            // 
            this.labelRam.AutoSize = true;
            this.labelRam.ForeColor = System.Drawing.Color.White;
            this.labelRam.Location = new System.Drawing.Point(0, 0);
            this.labelRam.Name = "labelRam";
            this.labelRam.Size = new System.Drawing.Size(56, 13);
            this.labelRam.TabIndex = 0;
            this.labelRam.Text = "RAM : 4Go ";
            // 
            // labelDisk
            // 
            this.labelDisk.AutoSize = true;
            this.labelDisk.ForeColor = System.Drawing.Color.White;
            this.labelDisk.Location = new System.Drawing.Point(0, 14);
            this.labelDisk.Name = "labelDisk";
            this.labelDisk.Size = new System.Drawing.Size(75, 13);
            this.labelDisk.TabIndex = 1;
            this.labelDisk.Text = "Disk : 30% free";
            // 
            // labelOs
            // 
            this.labelOs.AutoSize = true;
            this.labelOs.ForeColor = System.Drawing.Color.White;
            this.labelOs.Location = new System.Drawing.Point(0, 29);
            this.labelOs.Name = "labelOs";
            this.labelOs.Size = new System.Drawing.Size(67, 13);
            this.labelOs.TabIndex = 2;
            this.labelOs.Text = "OS : WS 2012";
            // 
            // ComponentComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelOs);
            this.Controls.Add(this.labelDisk);
            this.Controls.Add(this.labelRam);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ComponentComputer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRam;
        private System.Windows.Forms.Label labelDisk;
        private System.Windows.Forms.Label labelOs;
    }
}
