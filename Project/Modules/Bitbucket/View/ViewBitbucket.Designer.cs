namespace Droid_Infra
{
    partial class ViewBitbucket
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
            this.viewBitBucketRepository1 = new Droid_Infra.ViewBitBucketRepository();
            this.viewBitBucketUser1 = new Droid_Infra.ViewBitBucketUser();
            this.viewBitBucketLogin1 = new Droid_Infra.ViewBitBucketLogin();
            this.SuspendLayout();
            // 
            // viewBitBucketRepository1
            // 
            this.viewBitBucketRepository1.Adapter = null;
            this.viewBitBucketRepository1.BackColor = System.Drawing.Color.Black;
            this.viewBitBucketRepository1.Location = new System.Drawing.Point(466, 3);
            this.viewBitBucketRepository1.Name = "viewBitBucketRepository1";
            this.viewBitBucketRepository1.Size = new System.Drawing.Size(364, 326);
            this.viewBitBucketRepository1.TabIndex = 3;
            // 
            // viewBitBucketUser1
            // 
            this.viewBitBucketUser1.Adapter = null;
            this.viewBitBucketUser1.BackColor = System.Drawing.Color.Black;
            this.viewBitBucketUser1.Location = new System.Drawing.Point(3, 96);
            this.viewBitBucketUser1.Name = "viewBitBucketUser1";
            this.viewBitBucketUser1.Size = new System.Drawing.Size(457, 233);
            this.viewBitBucketUser1.TabIndex = 1;
            // 
            // viewBitBucketLogin1
            // 
            this.viewBitBucketLogin1.Adapter = null;
            this.viewBitBucketLogin1.BackColor = System.Drawing.Color.Black;
            this.viewBitBucketLogin1.Location = new System.Drawing.Point(3, 3);
            this.viewBitBucketLogin1.Name = "viewBitBucketLogin1";
            this.viewBitBucketLogin1.Size = new System.Drawing.Size(457, 87);
            this.viewBitBucketLogin1.TabIndex = 0;
            // 
            // ViewBitbucket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.viewBitBucketRepository1);
            this.Controls.Add(this.viewBitBucketUser1);
            this.Controls.Add(this.viewBitBucketLogin1);
            this.Name = "ViewBitbucket";
            this.Size = new System.Drawing.Size(835, 335);
            this.ResumeLayout(false);

        }

        #endregion

        private ViewBitBucketLogin viewBitBucketLogin1;
        private ViewBitBucketUser viewBitBucketUser1;
        private ViewBitBucketRepository viewBitBucketRepository1;
    }
}
