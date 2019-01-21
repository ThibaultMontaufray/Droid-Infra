namespace Droid.Infra.UI
{
    partial class ComponentMySql
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
            this.labelHost = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelConnected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHost.ForeColor = System.Drawing.Color.White;
            this.labelHost.Location = new System.Drawing.Point(0, 0);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(36, 13);
            this.labelHost.TabIndex = 0;
            this.labelHost.Text = "Host : ";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.White;
            this.labelLogin.Location = new System.Drawing.Point(0, 24);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(39, 13);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Login : ";
            // 
            // labelConnected
            // 
            this.labelConnected.AutoSize = true;
            this.labelConnected.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnected.ForeColor = System.Drawing.Color.White;
            this.labelConnected.Location = new System.Drawing.Point(0, 47);
            this.labelConnected.Name = "labelConnected";
            this.labelConnected.Size = new System.Drawing.Size(72, 13);
            this.labelConnected.TabIndex = 2;
            this.labelConnected.Text = "Disconnected";
            // 
            // ComponentPostGre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelConnected);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelHost);
            this.Name = "ComponentPostGre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelConnected;
    }
}
