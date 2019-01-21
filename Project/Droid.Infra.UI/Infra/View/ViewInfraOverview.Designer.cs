namespace Droid.Infra.UI
{
    partial class ViewInfraOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewInfraOverview));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.imageListComponent = new System.Windows.Forms.ImageList(this.components);
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnTypeIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDomain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnToken = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnPassword = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(722, 374);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Save";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Location = new System.Drawing.Point(641, 374);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 5;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
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
            // _dataGridView
            // 
            this._dataGridView.AllowUserToAddRows = false;
            this._dataGridView.AllowUserToDeleteRows = false;
            this._dataGridView.AllowUserToResizeColumns = false;
            this._dataGridView.AllowUserToResizeRows = false;
            this._dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dataGridView.BackgroundColor = System.Drawing.Color.DimGray;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTypeIcon,
            this.ColumnType,
            this.ColumnName,
            this.ColumnState,
            this.ColumnEnv,
            this.ColumnLogin,
            this.ColumnDomain,
            this.ColumnAddress,
            this.ColumnToken,
            this.ColumnPassword,
            this.ColumnDelete,
            this.ColumnEdit});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this._dataGridView.Location = new System.Drawing.Point(3, 41);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.RowHeadersVisible = false;
            this._dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dataGridView.Size = new System.Drawing.Size(794, 327);
            this._dataGridView.TabIndex = 10;
            this._dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dataGridView_CellClick);
            // 
            // ColumnTypeIcon
            // 
            this.ColumnTypeIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnTypeIcon.HeaderText = "";
            this.ColumnTypeIcon.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnTypeIcon.Name = "ColumnTypeIcon";
            this.ColumnTypeIcon.Width = 5;
            // 
            // ColumnType
            // 
            this.ColumnType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnType.HeaderText = "Type";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.Width = 56;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnState
            // 
            this.ColumnState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnState.HeaderText = "State";
            this.ColumnState.Name = "ColumnState";
            this.ColumnState.Width = 57;
            // 
            // ColumnEnv
            // 
            this.ColumnEnv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnEnv.HeaderText = "Env";
            this.ColumnEnv.Name = "ColumnEnv";
            this.ColumnEnv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnEnv.Width = 51;
            // 
            // ColumnLogin
            // 
            this.ColumnLogin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnLogin.HeaderText = "Login";
            this.ColumnLogin.Name = "ColumnLogin";
            this.ColumnLogin.Width = 58;
            // 
            // ColumnDomain
            // 
            this.ColumnDomain.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnDomain.HeaderText = "Domain";
            this.ColumnDomain.Name = "ColumnDomain";
            this.ColumnDomain.Width = 68;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnAddress.HeaderText = "Address";
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.Width = 70;
            // 
            // ColumnToken
            // 
            this.ColumnToken.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnToken.HeaderText = "Token";
            this.ColumnToken.Name = "ColumnToken";
            this.ColumnToken.Width = 44;
            // 
            // ColumnPassword
            // 
            this.ColumnPassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnPassword.HeaderText = "Password";
            this.ColumnPassword.Name = "ColumnPassword";
            this.ColumnPassword.Width = 59;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnDelete.HeaderText = "";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.Width = 5;
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnEdit.HeaderText = "";
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.Width = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(3, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(794, 24);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Current infra";
            // 
            // ViewInfraOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._dataGridView);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonAdd);
            this.Name = "ViewInfraOverview";
            this.Size = new System.Drawing.Size(800, 400);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ImageList imageListComponent;
        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewImageColumn ColumnTypeIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDomain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnToken;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnPassword;
        private System.Windows.Forms.DataGridViewImageColumn ColumnDelete;
        private System.Windows.Forms.DataGridViewImageColumn ColumnEdit;
    }
}
