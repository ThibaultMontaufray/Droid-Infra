namespace Droid.Infra.UI.Modules.Docker.View
{
    partial class ViewContainer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewContainer = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.labelCommand = new System.Windows.Forms.Label();
            this.numericUpDownPortTo = new System.Windows.Forms.NumericUpDown();
            this.labelPortTo = new System.Windows.Forms.Label();
            this.labelPortFrom = new System.Windows.Forms.Label();
            this.numericUpDownPortFrom = new System.Windows.Forms.NumericUpDown();
            this.buttonCleanFIelds = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.checkBoxRootRights = new System.Windows.Forms.CheckBox();
            this.textBoxAlias = new System.Windows.Forms.TextBox();
            this.labelAlias = new System.Windows.Forms.Label();
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.labelIp = new System.Windows.Forms.Label();
            this.comboBoxNetwork = new System.Windows.Forms.ComboBox();
            this.labelNetwork = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxImage = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelImageSelection = new System.Windows.Forms.Label();
            this.ColumnIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCommand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInspect = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContainer)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPortTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPortFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewContainer
            // 
            this.dataGridViewContainer.AllowUserToAddRows = false;
            this.dataGridViewContainer.AllowUserToDeleteRows = false;
            this.dataGridViewContainer.AllowUserToResizeColumns = false;
            this.dataGridViewContainer.AllowUserToResizeRows = false;
            this.dataGridViewContainer.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewContainer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewContainer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridViewContainer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewContainer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewContainer.ColumnHeadersHeight = 25;
            this.dataGridViewContainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewContainer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIcon,
            this.ColumnId,
            this.ColumnName,
            this.ColumnImage,
            this.ColumnCommand,
            this.ColumnCreated,
            this.ColumnStatus,
            this.ColumnPort,
            this.ColumnAction,
            this.ColumnInspect,
            this.ColumnDelete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewContainer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewContainer.EnableHeadersVisualStyles = false;
            this.dataGridViewContainer.Location = new System.Drawing.Point(0, 129);
            this.dataGridViewContainer.Name = "dataGridViewContainer";
            this.dataGridViewContainer.RowHeadersVisible = false;
            this.dataGridViewContainer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewContainer.Size = new System.Drawing.Size(900, 179);
            this.dataGridViewContainer.TabIndex = 2;
            this.dataGridViewContainer.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContainer_CellContentDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.textBoxCommand);
            this.panel1.Controls.Add(this.labelCommand);
            this.panel1.Controls.Add(this.numericUpDownPortTo);
            this.panel1.Controls.Add(this.labelPortTo);
            this.panel1.Controls.Add(this.labelPortFrom);
            this.panel1.Controls.Add(this.numericUpDownPortFrom);
            this.panel1.Controls.Add(this.buttonCleanFIelds);
            this.panel1.Controls.Add(this.buttonCreate);
            this.panel1.Controls.Add(this.checkBoxRootRights);
            this.panel1.Controls.Add(this.textBoxAlias);
            this.panel1.Controls.Add(this.labelAlias);
            this.panel1.Controls.Add(this.textBoxIp);
            this.panel1.Controls.Add(this.labelIp);
            this.panel1.Controls.Add(this.comboBoxNetwork);
            this.panel1.Controls.Add(this.labelNetwork);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.comboBoxImage);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.labelImageSelection);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 129);
            this.panel1.TabIndex = 3;
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.BackColor = System.Drawing.Color.DarkGray;
            this.textBoxCommand.Location = new System.Drawing.Point(155, 97);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(163, 22);
            this.textBoxCommand.TabIndex = 25;
            // 
            // labelCommand
            // 
            this.labelCommand.AutoSize = true;
            this.labelCommand.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelCommand.Location = new System.Drawing.Point(15, 100);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(70, 14);
            this.labelCommand.TabIndex = 24;
            this.labelCommand.Text = "Command : ";
            // 
            // numericUpDownPortTo
            // 
            this.numericUpDownPortTo.BackColor = System.Drawing.Color.DarkGray;
            this.numericUpDownPortTo.Location = new System.Drawing.Point(291, 69);
            this.numericUpDownPortTo.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPortTo.Name = "numericUpDownPortTo";
            this.numericUpDownPortTo.Size = new System.Drawing.Size(86, 22);
            this.numericUpDownPortTo.TabIndex = 23;
            this.numericUpDownPortTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownPortTo.Value = new decimal(new int[] {
            8081,
            0,
            0,
            0});
            // 
            // labelPortTo
            // 
            this.labelPortTo.AutoSize = true;
            this.labelPortTo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPortTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelPortTo.Location = new System.Drawing.Point(256, 71);
            this.labelPortTo.Name = "labelPortTo";
            this.labelPortTo.Size = new System.Drawing.Size(18, 14);
            this.labelPortTo.TabIndex = 22;
            this.labelPortTo.Text = "to";
            // 
            // labelPortFrom
            // 
            this.labelPortFrom.AutoSize = true;
            this.labelPortFrom.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPortFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelPortFrom.Location = new System.Drawing.Point(15, 71);
            this.labelPortFrom.Name = "labelPortFrom";
            this.labelPortFrom.Size = new System.Drawing.Size(111, 14);
            this.labelPortFrom.TabIndex = 21;
            this.labelPortFrom.Text = "Port openned from ";
            // 
            // numericUpDownPortFrom
            // 
            this.numericUpDownPortFrom.BackColor = System.Drawing.Color.DarkGray;
            this.numericUpDownPortFrom.Location = new System.Drawing.Point(155, 69);
            this.numericUpDownPortFrom.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPortFrom.Name = "numericUpDownPortFrom";
            this.numericUpDownPortFrom.Size = new System.Drawing.Size(86, 22);
            this.numericUpDownPortFrom.TabIndex = 20;
            this.numericUpDownPortFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownPortFrom.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // buttonCleanFIelds
            // 
            this.buttonCleanFIelds.BackColor = System.Drawing.Color.DimGray;
            this.buttonCleanFIelds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCleanFIelds.ForeColor = System.Drawing.Color.Black;
            this.buttonCleanFIelds.Location = new System.Drawing.Point(617, 96);
            this.buttonCleanFIelds.Name = "buttonCleanFIelds";
            this.buttonCleanFIelds.Size = new System.Drawing.Size(126, 23);
            this.buttonCleanFIelds.TabIndex = 19;
            this.buttonCleanFIelds.Text = "Clean fields";
            this.buttonCleanFIelds.UseVisualStyleBackColor = false;
            this.buttonCleanFIelds.Click += new System.EventHandler(this.buttonCleanFIelds_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.DimGray;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.ForeColor = System.Drawing.Color.Black;
            this.buttonCreate.Location = new System.Drawing.Point(749, 96);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(138, 23);
            this.buttonCreate.TabIndex = 18;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // checkBoxRootRights
            // 
            this.checkBoxRootRights.AutoSize = true;
            this.checkBoxRootRights.Location = new System.Drawing.Point(499, 44);
            this.checkBoxRootRights.Name = "checkBoxRootRights";
            this.checkBoxRootRights.Size = new System.Drawing.Size(94, 18);
            this.checkBoxRootRights.TabIndex = 17;
            this.checkBoxRootRights.Text = "Is privileged";
            this.checkBoxRootRights.UseVisualStyleBackColor = true;
            // 
            // textBoxAlias
            // 
            this.textBoxAlias.BackColor = System.Drawing.Color.DarkGray;
            this.textBoxAlias.Location = new System.Drawing.Point(708, 68);
            this.textBoxAlias.Name = "textBoxAlias";
            this.textBoxAlias.Size = new System.Drawing.Size(179, 22);
            this.textBoxAlias.TabIndex = 16;
            // 
            // labelAlias
            // 
            this.labelAlias.AutoSize = true;
            this.labelAlias.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelAlias.Location = new System.Drawing.Point(614, 71);
            this.labelAlias.Name = "labelAlias";
            this.labelAlias.Size = new System.Drawing.Size(44, 14);
            this.labelAlias.TabIndex = 15;
            this.labelAlias.Text = "Alias : ";
            // 
            // textBoxIp
            // 
            this.textBoxIp.BackColor = System.Drawing.Color.DarkGray;
            this.textBoxIp.Location = new System.Drawing.Point(708, 40);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(179, 22);
            this.textBoxIp.TabIndex = 14;
            // 
            // labelIp
            // 
            this.labelIp.AutoSize = true;
            this.labelIp.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelIp.Location = new System.Drawing.Point(614, 43);
            this.labelIp.Name = "labelIp";
            this.labelIp.Size = new System.Drawing.Size(27, 14);
            this.labelIp.TabIndex = 13;
            this.labelIp.Text = "Ip : ";
            // 
            // comboBoxNetwork
            // 
            this.comboBoxNetwork.BackColor = System.Drawing.Color.DarkGray;
            this.comboBoxNetwork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNetwork.FormattingEnabled = true;
            this.comboBoxNetwork.Location = new System.Drawing.Point(708, 12);
            this.comboBoxNetwork.Name = "comboBoxNetwork";
            this.comboBoxNetwork.Size = new System.Drawing.Size(179, 22);
            this.comboBoxNetwork.TabIndex = 12;
            // 
            // labelNetwork
            // 
            this.labelNetwork.AutoSize = true;
            this.labelNetwork.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNetwork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelNetwork.Location = new System.Drawing.Point(614, 15);
            this.labelNetwork.Name = "labelNetwork";
            this.labelNetwork.Size = new System.Drawing.Size(52, 14);
            this.labelNetwork.TabIndex = 11;
            this.labelNetwork.Text = "Network";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.DarkGray;
            this.textBoxName.Location = new System.Drawing.Point(155, 40);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(163, 22);
            this.textBoxName.TabIndex = 10;
            // 
            // comboBoxImage
            // 
            this.comboBoxImage.BackColor = System.Drawing.Color.DarkGray;
            this.comboBoxImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxImage.FormattingEnabled = true;
            this.comboBoxImage.Location = new System.Drawing.Point(155, 12);
            this.comboBoxImage.Name = "comboBoxImage";
            this.comboBoxImage.Size = new System.Drawing.Size(438, 22);
            this.comboBoxImage.TabIndex = 9;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelName.Location = new System.Drawing.Point(15, 43);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(48, 14);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Name : ";
            // 
            // labelImageSelection
            // 
            this.labelImageSelection.AutoSize = true;
            this.labelImageSelection.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImageSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelImageSelection.Location = new System.Drawing.Point(15, 15);
            this.labelImageSelection.Name = "labelImageSelection";
            this.labelImageSelection.Size = new System.Drawing.Size(103, 14);
            this.labelImageSelection.TabIndex = 7;
            this.labelImageSelection.Text = "Image selection *";
            // 
            // ColumnIcon
            // 
            this.ColumnIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnIcon.HeaderText = "";
            this.ColumnIcon.Name = "ColumnIcon";
            this.ColumnIcon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnIcon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnIcon.Width = 17;
            // 
            // ColumnId
            // 
            this.ColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnId.Width = 41;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnImage
            // 
            this.ColumnImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnImage.HeaderText = "Image";
            this.ColumnImage.Name = "ColumnImage";
            // 
            // ColumnCommand
            // 
            this.ColumnCommand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnCommand.HeaderText = "Command";
            this.ColumnCommand.Name = "ColumnCommand";
            this.ColumnCommand.Width = 84;
            // 
            // ColumnCreated
            // 
            this.ColumnCreated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnCreated.HeaderText = "Created";
            this.ColumnCreated.Name = "ColumnCreated";
            this.ColumnCreated.Width = 72;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.Width = 64;
            // 
            // ColumnPort
            // 
            this.ColumnPort.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnPort.HeaderText = "Ports";
            this.ColumnPort.Name = "ColumnPort";
            this.ColumnPort.ReadOnly = true;
            this.ColumnPort.Width = 57;
            // 
            // ColumnAction
            // 
            this.ColumnAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnAction.HeaderText = "";
            this.ColumnAction.Name = "ColumnAction";
            this.ColumnAction.Width = 17;
            // 
            // ColumnInspect
            // 
            this.ColumnInspect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnInspect.HeaderText = "";
            this.ColumnInspect.Name = "ColumnInspect";
            this.ColumnInspect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnInspect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnInspect.Width = 17;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnDelete.HeaderText = "";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.Width = 5;
            // 
            // ViewContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.dataGridViewContainer);
            this.Controls.Add(this.panel1);
            this.Name = "ViewContainer";
            this.Size = new System.Drawing.Size(900, 308);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContainer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPortTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPortFrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelImageSelection;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxImage;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelNetwork;
        private System.Windows.Forms.ComboBox comboBoxNetwork;
        private System.Windows.Forms.TextBox textBoxIp;
        private System.Windows.Forms.Label labelIp;
        private System.Windows.Forms.TextBox textBoxAlias;
        private System.Windows.Forms.Label labelAlias;
        private System.Windows.Forms.CheckBox checkBoxRootRights;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCleanFIelds;
        private System.Windows.Forms.Label labelPortFrom;
        private System.Windows.Forms.NumericUpDown numericUpDownPortFrom;
        private System.Windows.Forms.Label labelPortTo;
        private System.Windows.Forms.NumericUpDown numericUpDownPortTo;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.Label labelCommand;
        private System.Windows.Forms.DataGridViewImageColumn ColumnIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAction;
        private System.Windows.Forms.DataGridViewImageColumn ColumnInspect;
        private System.Windows.Forms.DataGridViewImageColumn ColumnDelete;
    }
}
