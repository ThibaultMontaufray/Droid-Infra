namespace Droid.Infra.UI
{
    partial class ComponentBitbucket
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
            this.labelrepo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelrepo
            // 
            this.labelrepo.AutoSize = true;
            this.labelrepo.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.labelrepo.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelrepo.Location = new System.Drawing.Point(0, 0);
            this.labelrepo.Name = "labelrepo";
            this.labelrepo.Size = new System.Drawing.Size(44, 13);
            this.labelrepo.TabIndex = 0;
            this.labelrepo.Text = "Repo : 0";
            // 
            // ComponentBitbucket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelrepo);
            this.Name = "ComponentBitbucket";
            this.Size = new System.Drawing.Size(98, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelrepo;
    }
}
