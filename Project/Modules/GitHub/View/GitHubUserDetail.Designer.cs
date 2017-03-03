namespace Droid_Infra
{
    partial class GitHubUserDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GitHubUserDetail));
            pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            buttonLogOff = new System.Windows.Forms.Button();
            labelUserName = new System.Windows.Forms.Label();
            labelInfoFollower = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            labelUserLocation = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            labelUserArrival = new System.Windows.Forms.Label();
            labelInfoFollowing = new System.Windows.Forms.Label();
            labelInfoRepository = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(pictureBoxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            pictureBoxAvatar.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar.InitialImage")));
            pictureBoxAvatar.Location = new System.Drawing.Point(0, 0);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new System.Drawing.Size(64, 64);
            pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxAvatar.TabIndex = 7;
            pictureBoxAvatar.TabStop = false;
            // 
            // buttonLogOff
            // 
            buttonLogOff.Location = new System.Drawing.Point(487, 45);
            buttonLogOff.Name = "buttonLogOff";
            buttonLogOff.Size = new System.Drawing.Size(92, 20);
            buttonLogOff.TabIndex = 8;
            buttonLogOff.Text = "Log off";
            buttonLogOff.UseVisualStyleBackColor = true;
            buttonLogOff.Click += new System.EventHandler(buttonLogOff_Click);
            // 
            // labelUserName
            // 
            labelUserName.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelUserName.Location = new System.Drawing.Point(70, 0);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new System.Drawing.Size(237, 23);
            labelUserName.TabIndex = 9;
            labelUserName.Text = "User name";
            // 
            // labelInfoFollower
            // 
            labelInfoFollower.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelInfoFollower.Location = new System.Drawing.Point(377, 0);
            labelInfoFollower.Name = "labelInfoFollower";
            labelInfoFollower.Size = new System.Drawing.Size(202, 14);
            labelInfoFollower.TabIndex = 10;
            labelInfoFollower.Text = "User details ";
            labelInfoFollower.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            pictureBox1.Location = new System.Drawing.Point(70, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(16, 16);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // labelUserLocation
            // 
            labelUserLocation.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelUserLocation.Location = new System.Drawing.Point(92, 26);
            labelUserLocation.Name = "labelUserLocation";
            labelUserLocation.Size = new System.Drawing.Size(371, 19);
            labelUserLocation.TabIndex = 12;
            labelUserLocation.Text = "User location";
            labelUserLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            pictureBox2.Location = new System.Drawing.Point(71, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(14, 14);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // labelUserArrival
            // 
            labelUserArrival.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelUserArrival.Location = new System.Drawing.Point(92, 45);
            labelUserArrival.Name = "labelUserArrival";
            labelUserArrival.Size = new System.Drawing.Size(371, 19);
            labelUserArrival.TabIndex = 14;
            labelUserArrival.Text = "User arrival";
            labelUserArrival.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInfoFollowing
            // 
            labelInfoFollowing.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelInfoFollowing.Location = new System.Drawing.Point(377, 14);
            labelInfoFollowing.Name = "labelInfoFollowing";
            labelInfoFollowing.Size = new System.Drawing.Size(202, 14);
            labelInfoFollowing.TabIndex = 15;
            labelInfoFollowing.Text = "User details ";
            labelInfoFollowing.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelInfoRepository
            // 
            labelInfoRepository.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelInfoRepository.Location = new System.Drawing.Point(377, 28);
            labelInfoRepository.Name = "labelInfoRepository";
            labelInfoRepository.Size = new System.Drawing.Size(202, 14);
            labelInfoRepository.TabIndex = 16;
            labelInfoRepository.Text = "User details ";
            labelInfoRepository.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GitHubUserDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            Controls.Add(labelInfoRepository);
            Controls.Add(labelInfoFollowing);
            Controls.Add(labelUserArrival);
            Controls.Add(pictureBox2);
            Controls.Add(labelUserLocation);
            Controls.Add(pictureBox1);
            Controls.Add(labelInfoFollower);
            Controls.Add(labelUserName);
            Controls.Add(buttonLogOff);
            Controls.Add(pictureBoxAvatar);
            Name = "GitHubUserDetail";
            Size = new System.Drawing.Size(579, 64);
            ((System.ComponentModel.ISupportInitialize)(pictureBoxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.Button buttonLogOff;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelInfoFollower;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUserLocation;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelUserArrival;
        private System.Windows.Forms.Label labelInfoFollowing;
        private System.Windows.Forms.Label labelInfoRepository;
    }
}
