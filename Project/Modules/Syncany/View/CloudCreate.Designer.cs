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
            this.groupBoxCreation = new System.Windows.Forms.GroupBox();
            this.label = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxConfigPath = new System.Windows.Forms.TextBox();
            this.comboBoxConnectionType = new System.Windows.Forms.ComboBox();
            this.buttonBrowseConfigPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBrowseOriginPath = new System.Windows.Forms.Button();
            this.textBoxOriginPath = new System.Windows.Forms.TextBox();
            this.groupBoxCreation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCreation
            // 
            this.groupBoxCreation.Controls.Add(this.label);
            this.groupBoxCreation.Controls.Add(this.buttonUpdate);
            this.groupBoxCreation.Controls.Add(this.textBoxConfigPath);
            this.groupBoxCreation.Controls.Add(this.comboBoxConnectionType);
            this.groupBoxCreation.Controls.Add(this.buttonBrowseConfigPath);
            this.groupBoxCreation.Controls.Add(this.label1);
            this.groupBoxCreation.Controls.Add(this.buttonBrowseOriginPath);
            this.groupBoxCreation.Controls.Add(this.textBoxOriginPath);
            this.groupBoxCreation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCreation.ForeColor = System.Drawing.Color.White;
            this.groupBoxCreation.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCreation.Name = "groupBoxCreation";
            this.groupBoxCreation.Size = new System.Drawing.Size(711, 100);
            this.groupBoxCreation.TabIndex = 15;
            this.groupBoxCreation.TabStop = false;
            this.groupBoxCreation.Text = "Cloud";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(6, 29);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(122, 19);
            this.label.TabIndex = 0;
            this.label.Text = "Cloud config path";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.Black;
            this.buttonUpdate.Location = new System.Drawing.Point(608, 26);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(94, 56);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Create cloud";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonCreateCloud_Click);
            // 
            // textBoxConfigPath
            // 
            this.textBoxConfigPath.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfigPath.ForeColor = System.Drawing.Color.Black;
            this.textBoxConfigPath.Location = new System.Drawing.Point(175, 26);
            this.textBoxConfigPath.Name = "textBoxConfigPath";
            this.textBoxConfigPath.Size = new System.Drawing.Size(337, 27);
            this.textBoxConfigPath.TabIndex = 1;
            // 
            // comboBoxConnectionType
            // 
            this.comboBoxConnectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConnectionType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxConnectionType.ForeColor = System.Drawing.Color.Black;
            this.comboBoxConnectionType.FormattingEnabled = true;
            this.comboBoxConnectionType.Location = new System.Drawing.Point(387, 55);
            this.comboBoxConnectionType.Name = "comboBoxConnectionType";
            this.comboBoxConnectionType.Size = new System.Drawing.Size(125, 27);
            this.comboBoxConnectionType.TabIndex = 7;
            // 
            // buttonBrowseConfigPath
            // 
            this.buttonBrowseConfigPath.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowseConfigPath.ForeColor = System.Drawing.Color.Black;
            this.buttonBrowseConfigPath.Location = new System.Drawing.Point(513, 26);
            this.buttonBrowseConfigPath.Name = "buttonBrowseConfigPath";
            this.buttonBrowseConfigPath.Size = new System.Drawing.Size(94, 27);
            this.buttonBrowseConfigPath.TabIndex = 2;
            this.buttonBrowseConfigPath.Text = "Browse";
            this.buttonBrowseConfigPath.UseVisualStyleBackColor = true;
            this.buttonBrowseConfigPath.Click += new System.EventHandler(this.buttonBrowseConfigPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Origin path";
            // 
            // buttonBrowseOriginPath
            // 
            this.buttonBrowseOriginPath.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowseOriginPath.ForeColor = System.Drawing.Color.Black;
            this.buttonBrowseOriginPath.Location = new System.Drawing.Point(513, 54);
            this.buttonBrowseOriginPath.Name = "buttonBrowseOriginPath";
            this.buttonBrowseOriginPath.Size = new System.Drawing.Size(94, 28);
            this.buttonBrowseOriginPath.TabIndex = 5;
            this.buttonBrowseOriginPath.Text = "Browse";
            this.buttonBrowseOriginPath.UseVisualStyleBackColor = true;
            this.buttonBrowseOriginPath.Click += new System.EventHandler(this.buttonBrowseOriginPath_Click);
            // 
            // textBoxOriginPath
            // 
            this.textBoxOriginPath.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOriginPath.ForeColor = System.Drawing.Color.Black;
            this.textBoxOriginPath.Location = new System.Drawing.Point(175, 55);
            this.textBoxOriginPath.Name = "textBoxOriginPath";
            this.textBoxOriginPath.Size = new System.Drawing.Size(209, 27);
            this.textBoxOriginPath.TabIndex = 4;
            // 
            // CloudCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBoxCreation);
            this.Name = "CloudCreate";
            this.Size = new System.Drawing.Size(719, 106);
            this.groupBoxCreation.ResumeLayout(false);
            this.groupBoxCreation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCreation;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxConfigPath;
        private System.Windows.Forms.ComboBox comboBoxConnectionType;
        private System.Windows.Forms.Button buttonBrowseConfigPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBrowseOriginPath;
        private System.Windows.Forms.TextBox textBoxOriginPath;
    }
}
