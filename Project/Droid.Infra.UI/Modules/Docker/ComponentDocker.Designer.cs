namespace Droid.Infra.UI
{
    partial class ComponentDocker
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
            this.labelMachines = new System.Windows.Forms.Label();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelIp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMachines
            // 
            this.labelMachines.AutoSize = true;
            this.labelMachines.ForeColor = System.Drawing.Color.White;
            this.labelMachines.Location = new System.Drawing.Point(3, -1);
            this.labelMachines.Name = "labelMachines";
            this.labelMachines.Size = new System.Drawing.Size(62, 13);
            this.labelMachines.TabIndex = 1;
            this.labelMachines.Text = "Machines : ";
            // 
            // labelCurrent
            // 
            this.labelCurrent.AutoSize = true;
            this.labelCurrent.ForeColor = System.Drawing.Color.White;
            this.labelCurrent.Location = new System.Drawing.Point(3, 16);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(50, 13);
            this.labelCurrent.TabIndex = 2;
            this.labelCurrent.Text = "Current : ";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.ForeColor = System.Drawing.Color.White;
            this.labelState.Location = new System.Drawing.Point(3, 32);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(41, 13);
            this.labelState.TabIndex = 3;
            this.labelState.Text = "State : ";
            // 
            // labelIp
            // 
            this.labelIp.AutoSize = true;
            this.labelIp.ForeColor = System.Drawing.Color.White;
            this.labelIp.Location = new System.Drawing.Point(3, 49);
            this.labelIp.Name = "labelIp";
            this.labelIp.Size = new System.Drawing.Size(26, 13);
            this.labelIp.TabIndex = 4;
            this.labelIp.Text = "IP : ";
            // 
            // ComponentDocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelIp);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelCurrent);
            this.Controls.Add(this.labelMachines);
            this.Name = "ComponentDocker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMachines;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelIp;
    }
}
