namespace Droid.Infra.UI
{
    partial class DockerManagerView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DockerManagerView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            splitContainer = new System.Windows.Forms.SplitContainer();
            listViewMachine = new System.Windows.Forms.ListView();
            imageListMachine = new System.Windows.Forms.ImageList(components);
            panelNewMachine = new System.Windows.Forms.Panel();
            buttonCreate = new System.Windows.Forms.Button();
            textBoxMachineName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            labelNewMachine = new System.Windows.Forms.Label();
            tabPageImages = new System.Windows.Forms.TabPage();
            tabPageDetail = new System.Windows.Forms.TabPage();
            panelCommand = new System.Windows.Forms.Panel();
            buttonStart = new System.Windows.Forms.Button();
            buttonStop = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            buttonImage = new System.Windows.Forms.Button();
            dataGridViewDetail = new System.Windows.Forms.DataGridView();
            ColumnDetailValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColumnEMpty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColumnDetailParameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tabControlMachine = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(splitContainer)).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            panelNewMachine.SuspendLayout();
            tabPageDetail.SuspendLayout();
            panelCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewDetail)).BeginInit();
            tabControlMachine.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.BackColor = System.Drawing.Color.Black;
            splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer.Location = new System.Drawing.Point(0, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(listViewMachine);
            splitContainer.Panel1MinSize = 120;
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.BackColor = System.Drawing.Color.Black;
            splitContainer.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            splitContainer.Panel2.Controls.Add(panelNewMachine);
            splitContainer.Panel2.Controls.Add(tabControlMachine);
            splitContainer.Size = new System.Drawing.Size(975, 550);
            splitContainer.SplitterDistance = 379;
            splitContainer.TabIndex = 2;
            // 
            // listViewMachine
            // 
            listViewMachine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            listViewMachine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            listViewMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewMachine.FullRowSelect = true;
            listViewMachine.LargeImageList = imageListMachine;
            listViewMachine.Location = new System.Drawing.Point(0, 0);
            listViewMachine.MultiSelect = false;
            listViewMachine.Name = "listViewMachine";
            listViewMachine.RightToLeftLayout = true;
            listViewMachine.Size = new System.Drawing.Size(379, 550);
            listViewMachine.SmallImageList = imageListMachine;
            listViewMachine.StateImageList = imageListMachine;
            listViewMachine.TabIndex = 1;
            listViewMachine.UseCompatibleStateImageBehavior = false;
            listViewMachine.View = System.Windows.Forms.View.Tile;
            // 
            // imageListMachine
            // 
            imageListMachine.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMachine.ImageStream")));
            imageListMachine.TransparentColor = System.Drawing.Color.Transparent;
            imageListMachine.Images.SetKeyName(0, "create");
            imageListMachine.Images.SetKeyName(1, "ubuntu");
            imageListMachine.Images.SetKeyName(2, "computer");
            // 
            // panelNewMachine
            // 
            panelNewMachine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            panelNewMachine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            panelNewMachine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelNewMachine.Controls.Add(buttonCreate);
            panelNewMachine.Controls.Add(textBoxMachineName);
            panelNewMachine.Controls.Add(label2);
            panelNewMachine.Controls.Add(labelNewMachine);
            panelNewMachine.Location = new System.Drawing.Point(13, 60);
            panelNewMachine.Name = "panelNewMachine";
            panelNewMachine.Size = new System.Drawing.Size(562, 101);
            panelNewMachine.TabIndex = 4;
            panelNewMachine.Visible = false;
            // 
            // buttonCreate
            // 
            buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            buttonCreate.Location = new System.Drawing.Point(482, 43);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new System.Drawing.Size(75, 23);
            buttonCreate.TabIndex = 3;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += new System.EventHandler(buttonCreate_Click);
            // 
            // textBoxMachineName
            // 
            textBoxMachineName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            textBoxMachineName.Font = new System.Drawing.Font("Calibri", 8F);
            textBoxMachineName.Location = new System.Drawing.Point(164, 44);
            textBoxMachineName.Name = "textBoxMachineName";
            textBoxMachineName.Size = new System.Drawing.Size(312, 21);
            textBoxMachineName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(13, 46);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(145, 13);
            label2.TabIndex = 1;
            label2.Text = "Docker machine name : ";
            // 
            // labelNewMachine
            // 
            labelNewMachine.BackColor = System.Drawing.Color.Maroon;
            labelNewMachine.Dock = System.Windows.Forms.DockStyle.Top;
            labelNewMachine.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelNewMachine.Location = new System.Drawing.Point(0, 0);
            labelNewMachine.Name = "labelNewMachine";
            labelNewMachine.Size = new System.Drawing.Size(560, 23);
            labelNewMachine.TabIndex = 0;
            labelNewMachine.Text = "Create a new docker machine";
            // 
            // tabPageImages
            // 
            tabPageImages.Location = new System.Drawing.Point(4, 24);
            tabPageImages.Name = "tabPageImages";
            tabPageImages.Padding = new System.Windows.Forms.Padding(3);
            tabPageImages.Size = new System.Drawing.Size(584, 522);
            tabPageImages.TabIndex = 1;
            tabPageImages.Text = "Images";
            tabPageImages.UseVisualStyleBackColor = true;
            // 
            // tabPageDetail
            // 
            tabPageDetail.Controls.Add(dataGridViewDetail);
            tabPageDetail.Controls.Add(panelCommand);
            tabPageDetail.Location = new System.Drawing.Point(4, 24);
            tabPageDetail.Name = "tabPageDetail";
            tabPageDetail.Padding = new System.Windows.Forms.Padding(3);
            tabPageDetail.Size = new System.Drawing.Size(584, 522);
            tabPageDetail.TabIndex = 0;
            tabPageDetail.Text = "Detail";
            tabPageDetail.UseVisualStyleBackColor = true;
            // 
            // panelCommand
            // 
            panelCommand.BackColor = System.Drawing.Color.Black;
            panelCommand.Controls.Add(buttonImage);
            panelCommand.Controls.Add(buttonDelete);
            panelCommand.Controls.Add(buttonStop);
            panelCommand.Controls.Add(buttonStart);
            panelCommand.Dock = System.Windows.Forms.DockStyle.Top;
            panelCommand.Location = new System.Drawing.Point(3, 3);
            panelCommand.Name = "panelCommand";
            panelCommand.Size = new System.Drawing.Size(578, 28);
            panelCommand.TabIndex = 2;
            // 
            // buttonStart
            // 
            buttonStart.Location = new System.Drawing.Point(3, 3);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new System.Drawing.Size(75, 23);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += new System.EventHandler(buttonStart_Click);
            // 
            // buttonStop
            // 
            buttonStop.Location = new System.Drawing.Point(84, 3);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new System.Drawing.Size(75, 23);
            buttonStop.TabIndex = 1;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += new System.EventHandler(buttonStop_Click);
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new System.Drawing.Point(165, 3);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new System.Drawing.Size(75, 23);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += new System.EventHandler(buttonDelete_Click);
            // 
            // buttonImage
            // 
            buttonImage.Location = new System.Drawing.Point(246, 3);
            buttonImage.Name = "buttonImage";
            buttonImage.Size = new System.Drawing.Size(75, 23);
            buttonImage.TabIndex = 3;
            buttonImage.Text = "Image";
            buttonImage.UseVisualStyleBackColor = true;
            buttonImage.Click += new System.EventHandler(buttonImage_Click);
            // 
            // dataGridViewDetail
            // 
            dataGridViewDetail.AllowUserToAddRows = false;
            dataGridViewDetail.AllowUserToDeleteRows = false;
            dataGridViewDetail.AllowUserToResizeColumns = false;
            dataGridViewDetail.AllowUserToResizeRows = false;
            dataGridViewDetail.BackgroundColor = System.Drawing.Color.White;
            dataGridViewDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetail.ColumnHeadersVisible = false;
            dataGridViewDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            ColumnDetailParameter,
            ColumnEMpty,
            ColumnDetailValue});
            dataGridViewDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewDetail.GridColor = System.Drawing.Color.White;
            dataGridViewDetail.Location = new System.Drawing.Point(3, 31);
            dataGridViewDetail.Name = "dataGridViewDetail";
            dataGridViewDetail.RowHeadersVisible = false;
            dataGridViewDetail.Size = new System.Drawing.Size(578, 488);
            dataGridViewDetail.TabIndex = 3;
            // 
            // ColumnDetailValue
            // 
            ColumnDetailValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            ColumnDetailValue.DefaultCellStyle = dataGridViewCellStyle4;
            ColumnDetailValue.HeaderText = "Value";
            ColumnDetailValue.Name = "ColumnDetailValue";
            // 
            // ColumnEMpty
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            ColumnEMpty.DefaultCellStyle = dataGridViewCellStyle3;
            ColumnEMpty.HeaderText = "";
            ColumnEMpty.Name = "ColumnEMpty";
            ColumnEMpty.Width = 10;
            // 
            // ColumnDetailParameter
            // 
            ColumnDetailParameter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            ColumnDetailParameter.DefaultCellStyle = dataGridViewCellStyle2;
            ColumnDetailParameter.HeaderText = "Parameter";
            ColumnDetailParameter.Name = "ColumnDetailParameter";
            ColumnDetailParameter.Width = 5;
            // 
            // tabControlMachine
            // 
            tabControlMachine.Controls.Add(tabPageDetail);
            tabControlMachine.Controls.Add(tabPageImages);
            tabControlMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControlMachine.Font = new System.Drawing.Font("Calibri", 10F);
            tabControlMachine.Location = new System.Drawing.Point(0, 0);
            tabControlMachine.Multiline = true;
            tabControlMachine.Name = "tabControlMachine";
            tabControlMachine.SelectedIndex = 0;
            tabControlMachine.Size = new System.Drawing.Size(592, 550);
            tabControlMachine.TabIndex = 5;
            tabControlMachine.Visible = false;
            // 
            // DockerManagerView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(splitContainer);
            Name = "DockerManagerView";
            Size = new System.Drawing.Size(975, 550);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(splitContainer)).EndInit();
            splitContainer.ResumeLayout(false);
            panelNewMachine.ResumeLayout(false);
            panelNewMachine.PerformLayout();
            tabPageDetail.ResumeLayout(false);
            panelCommand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(dataGridViewDetail)).EndInit();
            tabControlMachine.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListView listViewMachine;
        private System.Windows.Forms.ImageList imageListMachine;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textBoxMachineName;
        private System.Windows.Forms.Panel panelNewMachine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNewMachine;
        private System.Windows.Forms.TabControl tabControlMachine;
        private System.Windows.Forms.TabPage tabPageDetail;
        private System.Windows.Forms.DataGridView dataGridViewDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDetailParameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEMpty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDetailValue;
        private System.Windows.Forms.Panel panelCommand;
        private System.Windows.Forms.Button buttonImage;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TabPage tabPageImages;
    }
}
