namespace Droid_Infra
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
            labelLogin = new System.Windows.Forms.Label();
            textBoxLogin = new System.Windows.Forms.TextBox();
            maskedTextBoxPWD = new System.Windows.Forms.MaskedTextBox();
            labelPWD = new System.Windows.Forms.Label();
            textBoxUrl = new System.Windows.Forms.TextBox();
            labelUrl = new System.Windows.Forms.Label();
            buttonAuthenticate = new System.Windows.Forms.Button();
            labelConnectionFailled = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new System.Drawing.Point(4, 37);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new System.Drawing.Size(33, 13);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Login";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new System.Drawing.Point(53, 34);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new System.Drawing.Size(169, 20);
            textBoxLogin.TabIndex = 2;
            // 
            // maskedTextBoxPWD
            // 
            maskedTextBoxPWD.Location = new System.Drawing.Point(294, 34);
            maskedTextBoxPWD.Name = "maskedTextBoxPWD";
            maskedTextBoxPWD.PasswordChar = '*';
            maskedTextBoxPWD.Size = new System.Drawing.Size(169, 20);
            maskedTextBoxPWD.TabIndex = 3;
            // 
            // labelPWD
            // 
            labelPWD.AutoSize = true;
            labelPWD.Location = new System.Drawing.Point(235, 37);
            labelPWD.Name = "labelPWD";
            labelPWD.Size = new System.Drawing.Size(53, 13);
            labelPWD.TabIndex = 3;
            labelPWD.Text = "Password";
            // 
            // textBoxUrl
            // 
            textBoxUrl.Location = new System.Drawing.Point(53, 8);
            textBoxUrl.Name = "textBoxUrl";
            textBoxUrl.Size = new System.Drawing.Size(523, 20);
            textBoxUrl.TabIndex = 1;
            // 
            // labelUrl
            // 
            labelUrl.AutoSize = true;
            labelUrl.Location = new System.Drawing.Point(4, 11);
            labelUrl.Name = "labelUrl";
            labelUrl.Size = new System.Drawing.Size(29, 13);
            labelUrl.TabIndex = 5;
            labelUrl.Text = "URL";
            // 
            // buttonAuthenticate
            // 
            buttonAuthenticate.Location = new System.Drawing.Point(469, 33);
            buttonAuthenticate.Name = "buttonAuthenticate";
            buttonAuthenticate.Size = new System.Drawing.Size(107, 20);
            buttonAuthenticate.TabIndex = 6;
            buttonAuthenticate.Text = "Authentication";
            buttonAuthenticate.UseVisualStyleBackColor = true;
            buttonAuthenticate.Click += new System.EventHandler(buttonAutheticate_Click);
            // 
            // labelConnectionFailled
            // 
            labelConnectionFailled.BackColor = System.Drawing.Color.Transparent;
            labelConnectionFailled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelConnectionFailled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            labelConnectionFailled.Location = new System.Drawing.Point(469, 3);
            labelConnectionFailled.Name = "labelConnectionFailled";
            labelConnectionFailled.Size = new System.Drawing.Size(107, 29);
            labelConnectionFailled.TabIndex = 7;
            labelConnectionFailled.Text = "Connection failled";
            labelConnectionFailled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelConnectionFailled.Visible = false;
            // 
            // GitHubLogger
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(labelConnectionFailled);
            Controls.Add(buttonAuthenticate);
            Controls.Add(labelUrl);
            Controls.Add(textBoxUrl);
            Controls.Add(labelPWD);
            Controls.Add(maskedTextBoxPWD);
            Controls.Add(textBoxLogin);
            Controls.Add(labelLogin);
            Name = "GitHubLogger";
            Size = new System.Drawing.Size(579, 64);
            ResumeLayout(false);
            PerformLayout();

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
