namespace Droid_Infra
{
    partial class CloudCreate
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
            this.label = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.textBoxConfigPath = new System.Windows.Forms.TextBox();
            this.comboBoxConnectionType = new System.Windows.Forms.ComboBox();
            this.buttonBrowseConfigPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBrowseOriginPath = new System.Windows.Forms.Button();
            this.textBoxOriginPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(3, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(105, 17);
            this.label.TabIndex = 9;
            this.label.Text = "Cloud config path";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.ForeColor = System.Drawing.Color.Black;
            this.buttonCreate.Location = new System.Drawing.Point(610, -2);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(94, 53);
            this.buttonCreate.TabIndex = 16;
            this.buttonCreate.Text = "Create cloud";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreateCloud_Click);
            // 
            // textBoxConfigPath
            // 
            this.textBoxConfigPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConfigPath.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfigPath.ForeColor = System.Drawing.Color.Black;
            this.textBoxConfigPath.Location = new System.Drawing.Point(177, -2);
            this.textBoxConfigPath.Name = "textBoxConfigPath";
            this.textBoxConfigPath.Size = new System.Drawing.Size(334, 24);
            this.textBoxConfigPath.TabIndex = 10;
            // 
            // comboBoxConnectionType
            // 
            this.comboBoxConnectionType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxConnectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConnectionType.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxConnectionType.ForeColor = System.Drawing.Color.Black;
            this.comboBoxConnectionType.FormattingEnabled = true;
            this.comboBoxConnectionType.Location = new System.Drawing.Point(386, 27);
            this.comboBoxConnectionType.Name = "comboBoxConnectionType";
            this.comboBoxConnectionType.Size = new System.Drawing.Size(125, 23);
            this.comboBoxConnectionType.TabIndex = 15;
            // 
            // buttonBrowseConfigPath
            // 
            this.buttonBrowseConfigPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseConfigPath.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowseConfigPath.ForeColor = System.Drawing.Color.Black;
            this.buttonBrowseConfigPath.Location = new System.Drawing.Point(514, -2);
            this.buttonBrowseConfigPath.Name = "buttonBrowseConfigPath";
            this.buttonBrowseConfigPath.Size = new System.Drawing.Size(94, 24);
            this.buttonBrowseConfigPath.TabIndex = 11;
            this.buttonBrowseConfigPath.Text = "Browse";
            this.buttonBrowseConfigPath.UseVisualStyleBackColor = true;
            this.buttonBrowseConfigPath.Click += new System.EventHandler(this.buttonBrowseConfigPath_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Origin path";
            // 
            // buttonBrowseOriginPath
            // 
            this.buttonBrowseOriginPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseOriginPath.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowseOriginPath.ForeColor = System.Drawing.Color.Black;
            this.buttonBrowseOriginPath.Location = new System.Drawing.Point(514, 26);
            this.buttonBrowseOriginPath.Name = "buttonBrowseOriginPath";
            this.buttonBrowseOriginPath.Size = new System.Drawing.Size(94, 25);
            this.buttonBrowseOriginPath.TabIndex = 14;
            this.buttonBrowseOriginPath.Text = "Browse";
            this.buttonBrowseOriginPath.UseVisualStyleBackColor = true;
            this.buttonBrowseOriginPath.Click += new System.EventHandler(this.buttonBrowseOriginPath_Click);
            // 
            // textBoxOriginPath
            // 
            this.textBoxOriginPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOriginPath.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOriginPath.ForeColor = System.Drawing.Color.Black;
            this.textBoxOriginPath.Location = new System.Drawing.Point(177, 27);
            this.textBoxOriginPath.Name = "textBoxOriginPath";
            this.textBoxOriginPath.Size = new System.Drawing.Size(206, 24);
            this.textBoxOriginPath.TabIndex = 13;
            // 
            // CloudCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxConfigPath);
            this.Controls.Add(this.comboBoxConnectionType);
            this.Controls.Add(this.buttonBrowseConfigPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBrowseOriginPath);
            this.Controls.Add(this.textBoxOriginPath);
            this.Name = "CloudCreate";
            this.Size = new System.Drawing.Size(707, 54);
            this.Click += new System.EventHandler(this.buttonBrowseConfigPath_Click_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textBoxConfigPath;
        private System.Windows.Forms.ComboBox comboBoxConnectionType;
        private System.Windows.Forms.Button buttonBrowseConfigPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBrowseOriginPath;
        private System.Windows.Forms.TextBox textBoxOriginPath;
    }
}
