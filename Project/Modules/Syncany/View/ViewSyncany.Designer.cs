namespace Droid_Infra
{ 
    partial class ViewSyncany
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
            Droid_Infra.Interface_syncany interface_syncany1 = new Droid_Infra.Interface_syncany();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSyncany));
            this.cloudStatus1 = new Droid_Infra.CloudStatus();
            this.cloudView1 = new Droid_Infra.CloudView();
            this.SuspendLayout();
            // 
            // cloudStatus1
            // 
            this.cloudStatus1.BackColor = System.Drawing.Color.Transparent;
            this.cloudStatus1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cloudStatus1.Location = new System.Drawing.Point(0, 0);
            this.cloudStatus1.Name = "cloudStatus1";
            this.cloudStatus1.Size = new System.Drawing.Size(718, 116);
            this.cloudStatus1.TabIndex = 1;
            // 
            // cloudView1
            // 
            this.cloudView1.BackColor = System.Drawing.Color.Transparent;
            this.cloudView1.Dock = System.Windows.Forms.DockStyle.Fill;
            interface_syncany1.CloudConfigPath = null;
            interface_syncany1.CloudConnectionType = null;
            interface_syncany1.CloudRepositories = ((System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>>)(resources.GetObject("interface_syncany1.CloudRepositories")));
            interface_syncany1.DirectoryOriginal = null;
            interface_syncany1.DirectoryToAssociate = null;
            interface_syncany1.Login = "demoLog";
            interface_syncany1.Password = "demoPwd";
            interface_syncany1.WorkingDirectory = null;
            this.cloudView1.InterficeSyncany = interface_syncany1;
            this.cloudView1.Location = new System.Drawing.Point(0, 116);
            this.cloudView1.Name = "cloudView1";
            this.cloudView1.Size = new System.Drawing.Size(718, 335);
            this.cloudView1.TabIndex = 2;
            // 
            // ViewSyncany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.cloudView1);
            this.Controls.Add(this.cloudStatus1);
            this.Name = "ViewSyncany";
            this.Size = new System.Drawing.Size(718, 451);
            this.ResumeLayout(false);

        }

    #endregion

        private CloudStatus cloudStatus1;
        private CloudView cloudView1;
    }
}
