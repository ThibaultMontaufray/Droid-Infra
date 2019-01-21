namespace Droid.Infra.UI
{
    partial class ViewBitbucketManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBitbucketManage));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewTeam = new System.Windows.Forms.TreeView();
            this.tabControlRepo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this._repoPanel = new Droid.Infra.Modules.Bitbucket.View.RepoPanel();
            this.cloudRepositories1 = new Droid.Infra.CloudRepositories();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControlRepo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel1.Controls.Add(this.treeViewTeam);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel2.Controls.Add(this.tabControlRepo);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 500);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeViewTeam
            // 
            this.treeViewTeam.BackColor = System.Drawing.Color.WhiteSmoke;
            this.treeViewTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewTeam.Location = new System.Drawing.Point(0, 0);
            this.treeViewTeam.Name = "treeViewTeam";
            this.treeViewTeam.Size = new System.Drawing.Size(200, 500);
            this.treeViewTeam.TabIndex = 0;
            this.treeViewTeam.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTeam_AfterSelect);
            // 
            // tabControlRepo
            // 
            this.tabControlRepo.Controls.Add(this.tabPage1);
            this.tabControlRepo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlRepo.Location = new System.Drawing.Point(0, 0);
            this.tabControlRepo.Name = "tabControlRepo";
            this.tabControlRepo.SelectedIndex = 0;
            this.tabControlRepo.Size = new System.Drawing.Size(796, 500);
            this.tabControlRepo.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this._repoPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPageDefault";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // _repoPanel
            // 
            this._repoPanel.Adapter = null;
            this._repoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._repoPanel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._repoPanel.Location = new System.Drawing.Point(3, 3);
            this._repoPanel.Name = "_repoPanel";
            this._repoPanel.Size = new System.Drawing.Size(782, 468);
            this._repoPanel.TabIndex = 0;
            // 
            // cloudRepositories1
            // 
            this.cloudRepositories1.BackColor = System.Drawing.Color.Transparent;
            this.cloudRepositories1.Location = new System.Drawing.Point(0, 0);
            this.cloudRepositories1.Name = "cloudRepositories1";
            this.cloudRepositories1.Size = new System.Drawing.Size(700, 237);
            this.cloudRepositories1.TabIndex = 0;
            this.cloudRepositories1.WorkingDirectory = null;
            // 
            // ViewBitbucketManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ViewBitbucketManage";
            this.Size = new System.Drawing.Size(1000, 500);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControlRepo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControlRepo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView treeViewTeam;
        private Modules.Bitbucket.View.RepoPanel _repoPanel;
        private CloudRepositories cloudRepositories1;
    }
}
