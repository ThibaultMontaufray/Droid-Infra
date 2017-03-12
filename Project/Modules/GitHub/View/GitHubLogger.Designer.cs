﻿namespace Droid_Infra
{
    partial class GitHubLogger
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPWD = new System.Windows.Forms.MaskedTextBox();
            this.labelPWD = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.labelUrl = new System.Windows.Forms.Label();
            this.buttonAuthenticate = new System.Windows.Forms.Button();
            this.labelConnectionFailled = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(4, 37);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(53, 34);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(169, 20);
            this.textBoxLogin.TabIndex = 2;
            // 
            // maskedTextBoxPWD
            // 
            this.maskedTextBoxPWD.Location = new System.Drawing.Point(294, 34);
            this.maskedTextBoxPWD.Name = "maskedTextBoxPWD";
            this.maskedTextBoxPWD.PasswordChar = '*';
            this.maskedTextBoxPWD.Size = new System.Drawing.Size(169, 20);
            this.maskedTextBoxPWD.TabIndex = 3;
            // 
            // labelPWD
            // 
            this.labelPWD.AutoSize = true;
            this.labelPWD.Location = new System.Drawing.Point(235, 37);
            this.labelPWD.Name = "labelPWD";
            this.labelPWD.Size = new System.Drawing.Size(53, 13);
            this.labelPWD.TabIndex = 3;
            this.labelPWD.Text = "Password";
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(53, 8);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(523, 20);
            this.textBoxUrl.TabIndex = 1;
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(4, 11);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(29, 13);
            this.labelUrl.TabIndex = 5;
            this.labelUrl.Text = "URL";
            // 
            // buttonAuthenticate
            // 
            this.buttonAuthenticate.Location = new System.Drawing.Point(469, 33);
            this.buttonAuthenticate.Name = "buttonAuthenticate";
            this.buttonAuthenticate.Size = new System.Drawing.Size(107, 20);
            this.buttonAuthenticate.TabIndex = 6;
            this.buttonAuthenticate.Text = "Authentication";
            this.buttonAuthenticate.UseVisualStyleBackColor = true;
            this.buttonAuthenticate.Click += new System.EventHandler(this.buttonAutheticate_Click);
            // 
            // labelConnectionFailled
            // 
            this.labelConnectionFailled.BackColor = System.Drawing.Color.Transparent;
            this.labelConnectionFailled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnectionFailled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelConnectionFailled.Location = new System.Drawing.Point(469, 3);
            this.labelConnectionFailled.Name = "labelConnectionFailled";
            this.labelConnectionFailled.Size = new System.Drawing.Size(107, 29);
            this.labelConnectionFailled.TabIndex = 7;
            this.labelConnectionFailled.Text = "Connection failled";
            this.labelConnectionFailled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelConnectionFailled.Visible = false;
            // 
            // GitHubLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelConnectionFailled);
            this.Controls.Add(this.buttonAuthenticate);
            this.Controls.Add(this.labelUrl);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.labelPWD);
            this.Controls.Add(this.maskedTextBoxPWD);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelLogin);
            this.Name = "GitHubLogger";
            this.Size = new System.Drawing.Size(579, 64);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPWD;
        private System.Windows.Forms.Label labelPWD;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.Button buttonAuthenticate;
        private System.Windows.Forms.Label labelConnectionFailled;
    }
}
