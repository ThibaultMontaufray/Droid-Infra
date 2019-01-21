namespace Droid.Infra.UI.Modules.Docker.View
{
    partial class ComponentDockerMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentDockerMachine));
            this.labelMachineName = new System.Windows.Forms.Label();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.labelDetail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMachineName
            // 
            this.labelMachineName.Location = new System.Drawing.Point(0, 0);
            this.labelMachineName.Name = "labelMachineName";
            this.labelMachineName.Size = new System.Drawing.Size(198, 36);
            this.labelMachineName.TabIndex = 2;
            this.labelMachineName.Text = "NAME";
            this.labelMachineName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStartStop.BackgroundImage")));
            this.buttonStartStop.FlatAppearance.BorderSize = 0;
            this.buttonStartStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonStartStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartStop.Location = new System.Drawing.Point(466, 2);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(32, 32);
            this.buttonStartStop.TabIndex = 3;
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // labelDetail
            // 
            this.labelDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDetail.Location = new System.Drawing.Point(204, 0);
            this.labelDetail.Name = "labelDetail";
            this.labelDetail.Size = new System.Drawing.Size(256, 36);
            this.labelDetail.TabIndex = 4;
            this.labelDetail.Text = "---";
            this.labelDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComponentDockerMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelDetail);
            this.Controls.Add(this.buttonStartStop);
            this.Controls.Add(this.labelMachineName);
            this.Name = "ComponentDockerMachine";
            this.Size = new System.Drawing.Size(500, 36);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelMachineName;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.Label labelDetail;
    }
}
