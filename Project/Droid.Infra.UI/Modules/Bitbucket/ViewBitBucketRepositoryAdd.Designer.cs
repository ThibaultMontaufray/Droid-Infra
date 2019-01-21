namespace Droid.Infra.UI.Modules.Bitbucket.View
{
    partial class ViewBitBucketRepositoryAdd
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxRepo = new System.Windows.Forms.TextBox();
            this.labelRepository = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 6);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(65, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "User name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(91, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(178, 23);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(194, 61);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxRepo
            // 
            this.textBoxRepo.Location = new System.Drawing.Point(91, 32);
            this.textBoxRepo.Name = "textBoxRepo";
            this.textBoxRepo.Size = new System.Drawing.Size(178, 23);
            this.textBoxRepo.TabIndex = 4;
            // 
            // labelRepository
            // 
            this.labelRepository.AutoSize = true;
            this.labelRepository.Location = new System.Drawing.Point(3, 35);
            this.labelRepository.Name = "labelRepository";
            this.labelRepository.Size = new System.Drawing.Size(66, 15);
            this.labelRepository.TabIndex = 3;
            this.labelRepository.Text = "Repository";
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(113, 61);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 5;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(3, 65);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 15);
            this.labelStatus.TabIndex = 6;
            // 
            // ViewBitBucketRepositoryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.textBoxRepo);
            this.Controls.Add(this.labelRepository);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ViewBitBucketRepositoryAdd";
            this.Size = new System.Drawing.Size(277, 94);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxRepo;
        private System.Windows.Forms.Label labelRepository;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Label labelStatus;
    }
}
