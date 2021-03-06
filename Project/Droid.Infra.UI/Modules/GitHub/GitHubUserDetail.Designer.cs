﻿namespace Droid.Infra.UI
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
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.buttonLogOff = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelInfoFollower = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelUserLocation = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelUserArrival = new System.Windows.Forms.Label();
            this.labelInfoFollowing = new System.Windows.Forms.Label();
            this.labelInfoRepository = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxAvatar.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar.InitialImage")));
            this.pictureBoxAvatar.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar.TabIndex = 7;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // buttonLogOff
            // 
            this.buttonLogOff.Location = new System.Drawing.Point(487, 45);
            this.buttonLogOff.Name = "buttonLogOff";
            this.buttonLogOff.Size = new System.Drawing.Size(92, 20);
            this.buttonLogOff.TabIndex = 8;
            this.buttonLogOff.Text = "Log off";
            this.buttonLogOff.UseVisualStyleBackColor = true;
            this.buttonLogOff.Visible = false;
            this.buttonLogOff.Click += new System.EventHandler(this.buttonLogOff_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.White;
            this.labelUserName.Location = new System.Drawing.Point(70, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(237, 23);
            this.labelUserName.TabIndex = 9;
            this.labelUserName.Text = "User name";
            // 
            // labelInfoFollower
            // 
            this.labelInfoFollower.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoFollower.ForeColor = System.Drawing.Color.White;
            this.labelInfoFollower.Location = new System.Drawing.Point(377, 0);
            this.labelInfoFollower.Name = "labelInfoFollower";
            this.labelInfoFollower.Size = new System.Drawing.Size(202, 14);
            this.labelInfoFollower.TabIndex = 10;
            this.labelInfoFollower.Text = "User details ";
            this.labelInfoFollower.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // labelUserLocation
            // 
            this.labelUserLocation.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserLocation.ForeColor = System.Drawing.Color.White;
            this.labelUserLocation.Location = new System.Drawing.Point(92, 26);
            this.labelUserLocation.Name = "labelUserLocation";
            this.labelUserLocation.Size = new System.Drawing.Size(371, 19);
            this.labelUserLocation.TabIndex = 12;
            this.labelUserLocation.Text = "User location";
            this.labelUserLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(71, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(14, 14);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // labelUserArrival
            // 
            this.labelUserArrival.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserArrival.ForeColor = System.Drawing.Color.White;
            this.labelUserArrival.Location = new System.Drawing.Point(92, 45);
            this.labelUserArrival.Name = "labelUserArrival";
            this.labelUserArrival.Size = new System.Drawing.Size(371, 19);
            this.labelUserArrival.TabIndex = 14;
            this.labelUserArrival.Text = "User arrival";
            this.labelUserArrival.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInfoFollowing
            // 
            this.labelInfoFollowing.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoFollowing.ForeColor = System.Drawing.Color.White;
            this.labelInfoFollowing.Location = new System.Drawing.Point(377, 14);
            this.labelInfoFollowing.Name = "labelInfoFollowing";
            this.labelInfoFollowing.Size = new System.Drawing.Size(202, 14);
            this.labelInfoFollowing.TabIndex = 15;
            this.labelInfoFollowing.Text = "User details ";
            this.labelInfoFollowing.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelInfoRepository
            // 
            this.labelInfoRepository.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoRepository.ForeColor = System.Drawing.Color.White;
            this.labelInfoRepository.Location = new System.Drawing.Point(377, 28);
            this.labelInfoRepository.Name = "labelInfoRepository";
            this.labelInfoRepository.Size = new System.Drawing.Size(202, 14);
            this.labelInfoRepository.TabIndex = 16;
            this.labelInfoRepository.Text = "User details ";
            this.labelInfoRepository.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GitHubUserDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.labelInfoRepository);
            this.Controls.Add(this.labelInfoFollowing);
            this.Controls.Add(this.labelUserArrival);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelUserLocation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelInfoFollower);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.buttonLogOff);
            this.Controls.Add(this.pictureBoxAvatar);
            this.Name = "GitHubUserDetail";
            this.Size = new System.Drawing.Size(579, 64);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

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
