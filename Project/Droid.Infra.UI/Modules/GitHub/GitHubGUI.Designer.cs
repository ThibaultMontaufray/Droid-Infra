﻿namespace Droid.Infra.UI
{
    partial class GitHubGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this._gitHubUserDetail = new Droid.Infra.GitHubUserDetail();
            this._gitHubLogger = new Droid.Infra.GitHubLogger();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 252);
            this.panel1.TabIndex = 1;
            // 
            // _gitHubUserDetail
            // 
            this._gitHubUserDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._gitHubUserDetail.Location = new System.Drawing.Point(12, 12);
            this._gitHubUserDetail.Name = "_gitHubUserDetail";
            this._gitHubUserDetail.Size = new System.Drawing.Size(579, 64);
            this._gitHubUserDetail.TabIndex = 0;
            this._gitHubUserDetail.Visible = false;
            // 
            // _gitHubLogger
            // 
            this._gitHubLogger.GitHubAdapter = null;
            this._gitHubLogger.Location = new System.Drawing.Point(12, 12);
            this._gitHubLogger.Name = "_gitHubLogger";
            this._gitHubLogger.Size = new System.Drawing.Size(579, 64);
            this._gitHubLogger.TabIndex = 0;
            // 
            // GitHubGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 346);
            this.Controls.Add(this._gitHubUserDetail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._gitHubLogger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GitHubGUI";
            this.Text = "GitHub ";
            this.ResumeLayout(false);

        }

        #endregion

        private GitHubLogger _gitHubLogger;
        private System.Windows.Forms.Panel panel1;
        private GitHubUserDetail _gitHubUserDetail;
    }
}