namespace Droid.Infra.UI
{
    partial class ComponentVPN
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
            this.labelProxy = new System.Windows.Forms.Label();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelProxy
            // 
            this.labelProxy.AutoSize = true;
            this.labelProxy.ForeColor = System.Drawing.Color.White;
            this.labelProxy.Location = new System.Drawing.Point(3, 0);
            this.labelProxy.Name = "labelProxy";
            this.labelProxy.Size = new System.Drawing.Size(42, 13);
            this.labelProxy.TabIndex = 2;
            this.labelProxy.Text = "Proxy : ";
            // 
            // labelCurrent
            // 
            this.labelCurrent.AutoSize = true;
            this.labelCurrent.ForeColor = System.Drawing.Color.White;
            this.labelCurrent.Location = new System.Drawing.Point(3, 18);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(50, 13);
            this.labelCurrent.TabIndex = 3;
            this.labelCurrent.Text = "Current : ";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.ForeColor = System.Drawing.Color.White;
            this.labelState.Location = new System.Drawing.Point(3, 36);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(41, 13);
            this.labelState.TabIndex = 4;
            this.labelState.Text = "State : ";
            // 
            // ComponentVPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelCurrent);
            this.Controls.Add(this.labelProxy);
            this.Name = "ComponentVPN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProxy;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.Label labelState;
    }
}
