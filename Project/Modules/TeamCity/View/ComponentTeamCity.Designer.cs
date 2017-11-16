namespace Droid_Infra
{
    partial class ComponentTeamCity
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
            this.labelAgents = new System.Windows.Forms.Label();
            this.labelProjects = new System.Windows.Forms.Label();
            this.labelQueue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAgents
            // 
            this.labelAgents.AutoSize = true;
            this.labelAgents.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgents.ForeColor = System.Drawing.Color.White;
            this.labelAgents.Location = new System.Drawing.Point(0, 0);
            this.labelAgents.Name = "labelAgents";
            this.labelAgents.Size = new System.Drawing.Size(97, 13);
            this.labelAgents.TabIndex = 0;
            this.labelAgents.Text = "Actives agents : 0/0";
            // 
            // labelProjects
            // 
            this.labelProjects.AutoSize = true;
            this.labelProjects.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProjects.ForeColor = System.Drawing.Color.White;
            this.labelProjects.Location = new System.Drawing.Point(0, 24);
            this.labelProjects.Name = "labelProjects";
            this.labelProjects.Size = new System.Drawing.Size(59, 13);
            this.labelProjects.TabIndex = 1;
            this.labelProjects.Text = "Projects : 0";
            // 
            // labelQueue
            // 
            this.labelQueue.AutoSize = true;
            this.labelQueue.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQueue.ForeColor = System.Drawing.Color.White;
            this.labelQueue.Location = new System.Drawing.Point(0, 47);
            this.labelQueue.Name = "labelQueue";
            this.labelQueue.Size = new System.Drawing.Size(58, 13);
            this.labelQueue.TabIndex = 2;
            this.labelQueue.Text = "Pending : 0";
            // 
            // ComponentTeamCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelQueue);
            this.Controls.Add(this.labelProjects);
            this.Controls.Add(this.labelAgents);
            this.Name = "ComponentTeamCity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAgents;
        private System.Windows.Forms.Label labelProjects;
        private System.Windows.Forms.Label labelQueue;
    }
}
