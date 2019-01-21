namespace Droid.Infra.UI
{
    partial class ViewInfraAdapter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewInfraAdapter));
            this.labelTitleView = new System.Windows.Forms.Label();
            this.comboBoxInfra = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.imageListComponent = new System.Windows.Forms.ImageList(this.components);
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.labelIp = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEnv = new System.Windows.Forms.Label();
            this.comboBoxEnv = new System.Windows.Forms.ComboBox();
            this.textBoxDomain = new System.Windows.Forms.TextBox();
            this.labelDomain = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.pictureBoxTechno = new System.Windows.Forms.PictureBox();
            this.textBoxToken = new System.Windows.Forms.TextBox();
            this.labelToken = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTechno)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitleView
            // 
            this.labelTitleView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitleView.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleView.Location = new System.Drawing.Point(86, 20);
            this.labelTitleView.Name = "labelTitleView";
            this.labelTitleView.Size = new System.Drawing.Size(312, 23);
            this.labelTitleView.TabIndex = 1;
            this.labelTitleView.Text = "Infrastructure component";
            // 
            // comboBoxInfra
            // 
            this.comboBoxInfra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInfra.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxInfra.FormattingEnabled = true;
            this.comboBoxInfra.Location = new System.Drawing.Point(143, 48);
            this.comboBoxInfra.Name = "comboBoxInfra";
            this.comboBoxInfra.Size = new System.Drawing.Size(244, 23);
            this.comboBoxInfra.TabIndex = 2;
            this.comboBoxInfra.SelectedIndexChanged += new System.EventHandler(this.comboBoxInfra_SelectedIndexChanged);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(87, 49);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(37, 18);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Type";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(312, 282);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(231, 282);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(17, 78);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 18);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(117, 78);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(270, 23);
            this.textBoxName.TabIndex = 7;
            // 
            // imageListComponent
            // 
            this.imageListComponent.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListComponent.ImageStream")));
            this.imageListComponent.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListComponent.Images.SetKeyName(0, "BitBucket");
            this.imageListComponent.Images.SetKeyName(1, "Serveur");
            this.imageListComponent.Images.SetKeyName(2, "Sonarqube");
            this.imageListComponent.Images.SetKeyName(3, "SQL");
            this.imageListComponent.Images.SetKeyName(4, "TeamCity");
            this.imageListComponent.Images.SetKeyName(5, "unknown");
            // 
            // textBoxIp
            // 
            this.textBoxIp.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIp.Location = new System.Drawing.Point(117, 107);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(150, 23);
            this.textBoxIp.TabIndex = 11;
            // 
            // labelIp
            // 
            this.labelIp.AutoSize = true;
            this.labelIp.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIp.Location = new System.Drawing.Point(17, 107);
            this.labelIp.Name = "labelIp";
            this.labelIp.Size = new System.Drawing.Size(20, 18);
            this.labelIp.TabIndex = 10;
            this.labelIp.Text = "Ip";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPort.Location = new System.Drawing.Point(321, 107);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(66, 23);
            this.textBoxPort.TabIndex = 13;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort.Location = new System.Drawing.Point(273, 108);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(34, 18);
            this.labelPort.TabIndex = 12;
            this.labelPort.Text = "Port";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(117, 164);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(270, 23);
            this.textBoxPassword.TabIndex = 17;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(17, 164);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(67, 18);
            this.labelPassword.TabIndex = 16;
            this.labelPassword.Text = "Password";
            // 
            // labelEnv
            // 
            this.labelEnv.AutoSize = true;
            this.labelEnv.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnv.Location = new System.Drawing.Point(17, 251);
            this.labelEnv.Name = "labelEnv";
            this.labelEnv.Size = new System.Drawing.Size(88, 18);
            this.labelEnv.TabIndex = 18;
            this.labelEnv.Text = "Environment";
            // 
            // comboBoxEnv
            // 
            this.comboBoxEnv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEnv.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEnv.FormattingEnabled = true;
            this.comboBoxEnv.Location = new System.Drawing.Point(117, 251);
            this.comboBoxEnv.Name = "comboBoxEnv";
            this.comboBoxEnv.Size = new System.Drawing.Size(270, 23);
            this.comboBoxEnv.TabIndex = 22;
            // 
            // textBoxDomain
            // 
            this.textBoxDomain.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDomain.Location = new System.Drawing.Point(117, 222);
            this.textBoxDomain.Name = "textBoxDomain";
            this.textBoxDomain.Size = new System.Drawing.Size(270, 23);
            this.textBoxDomain.TabIndex = 24;
            // 
            // labelDomain
            // 
            this.labelDomain.AutoSize = true;
            this.labelDomain.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDomain.Location = new System.Drawing.Point(17, 222);
            this.labelDomain.Name = "labelDomain";
            this.labelDomain.Size = new System.Drawing.Size(56, 18);
            this.labelDomain.TabIndex = 23;
            this.labelDomain.Text = "Domain";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.Location = new System.Drawing.Point(117, 135);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(270, 23);
            this.textBoxLogin.TabIndex = 26;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(17, 135);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(41, 18);
            this.labelLogin.TabIndex = 25;
            this.labelLogin.Text = "Login";
            // 
            // pictureBoxTechno
            // 
            this.pictureBoxTechno.BackgroundImage = global::Droid.Infra.Properties.Resources.unknown;
            this.pictureBoxTechno.Location = new System.Drawing.Point(20, 20);
            this.pictureBoxTechno.Name = "pictureBoxTechno";
            this.pictureBoxTechno.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxTechno.TabIndex = 0;
            this.pictureBoxTechno.TabStop = false;
            // 
            // textBoxToken
            // 
            this.textBoxToken.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxToken.Location = new System.Drawing.Point(117, 193);
            this.textBoxToken.Name = "textBoxToken";
            this.textBoxToken.Size = new System.Drawing.Size(270, 23);
            this.textBoxToken.TabIndex = 28;
            // 
            // labelToken
            // 
            this.labelToken.AutoSize = true;
            this.labelToken.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToken.Location = new System.Drawing.Point(17, 193);
            this.labelToken.Name = "labelToken";
            this.labelToken.Size = new System.Drawing.Size(45, 18);
            this.labelToken.TabIndex = 27;
            this.labelToken.Text = "Token";
            // 
            // ViewInfraComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.textBoxToken);
            this.Controls.Add(this.labelToken);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxDomain);
            this.Controls.Add(this.labelDomain);
            this.Controls.Add(this.comboBoxEnv);
            this.Controls.Add(this.labelEnv);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textBoxIp);
            this.Controls.Add(this.labelIp);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBoxInfra);
            this.Controls.Add(this.labelTitleView);
            this.Controls.Add(this.pictureBoxTechno);
            this.Name = "ViewInfraComponent";
            this.Size = new System.Drawing.Size(401, 318);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTechno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTechno;
        private System.Windows.Forms.Label labelTitleView;
        private System.Windows.Forms.ComboBox comboBoxInfra;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ImageList imageListComponent;
        private System.Windows.Forms.TextBox textBoxIp;
        private System.Windows.Forms.Label labelIp;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEnv;
        private System.Windows.Forms.ComboBox comboBoxEnv;
        private System.Windows.Forms.TextBox textBoxDomain;
        private System.Windows.Forms.Label labelDomain;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxToken;
        private System.Windows.Forms.Label labelToken;
    }
}
