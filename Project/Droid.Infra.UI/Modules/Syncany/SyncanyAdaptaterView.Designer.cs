namespace Droid.Infra.UI.Syncany
{
    partial class SyncanyAdaptaterView
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
            this.buttonInit = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonRestores = new System.Windows.Forms.Button();
            this.buttonPlugin = new System.Windows.Forms.Button();
            this.textBoxPlugin = new System.Windows.Forms.TextBox();
            this.textBoxRestores = new System.Windows.Forms.TextBox();
            this.textBoxConnect = new System.Windows.Forms.TextBox();
            this.buttonListPlugins = new System.Windows.Forms.Button();
            this.dataGridViewPlugins = new System.Windows.Forms.DataGridView();
            this.buttonDaemon = new System.Windows.Forms.Button();
            this.labelDaemonStatus = new System.Windows.Forms.Label();
            this.labelDaemonPID = new System.Windows.Forms.Label();
            this.buttonDaemonStart = new System.Windows.Forms.Button();
            this.buttonDaemonStop = new System.Windows.Forms.Button();
            this.textBoxRepoPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlugins)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInit
            // 
            this.buttonInit.Location = new System.Drawing.Point(12, 12);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(150, 23);
            this.buttonInit.TabIndex = 0;
            this.buttonInit.Text = "Init";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(12, 41);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(150, 23);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(12, 70);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(150, 23);
            this.buttonDown.TabIndex = 2;
            this.buttonDown.Text = "Down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 99);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(150, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(12, 128);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(150, 23);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect to :";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonRestores
            // 
            this.buttonRestores.Location = new System.Drawing.Point(12, 157);
            this.buttonRestores.Name = "buttonRestores";
            this.buttonRestores.Size = new System.Drawing.Size(150, 23);
            this.buttonRestores.TabIndex = 5;
            this.buttonRestores.Text = "Restores :";
            this.buttonRestores.UseVisualStyleBackColor = true;
            this.buttonRestores.Click += new System.EventHandler(this.buttonRestores_Click);
            // 
            // buttonPlugin
            // 
            this.buttonPlugin.Location = new System.Drawing.Point(12, 186);
            this.buttonPlugin.Name = "buttonPlugin";
            this.buttonPlugin.Size = new System.Drawing.Size(150, 23);
            this.buttonPlugin.TabIndex = 6;
            this.buttonPlugin.Text = "Install plugin :";
            this.buttonPlugin.UseVisualStyleBackColor = true;
            this.buttonPlugin.Click += new System.EventHandler(this.buttonPlugin_Click);
            // 
            // textBoxPlugin
            // 
            this.textBoxPlugin.Location = new System.Drawing.Point(168, 188);
            this.textBoxPlugin.Name = "textBoxPlugin";
            this.textBoxPlugin.Size = new System.Drawing.Size(369, 20);
            this.textBoxPlugin.TabIndex = 7;
            // 
            // textBoxRestores
            // 
            this.textBoxRestores.Location = new System.Drawing.Point(168, 159);
            this.textBoxRestores.Name = "textBoxRestores";
            this.textBoxRestores.Size = new System.Drawing.Size(369, 20);
            this.textBoxRestores.TabIndex = 8;
            // 
            // textBoxConnect
            // 
            this.textBoxConnect.Location = new System.Drawing.Point(168, 130);
            this.textBoxConnect.Name = "textBoxConnect";
            this.textBoxConnect.Size = new System.Drawing.Size(369, 20);
            this.textBoxConnect.TabIndex = 9;
            // 
            // buttonListPlugins
            // 
            this.buttonListPlugins.Location = new System.Drawing.Point(387, 99);
            this.buttonListPlugins.Name = "buttonListPlugins";
            this.buttonListPlugins.Size = new System.Drawing.Size(150, 23);
            this.buttonListPlugins.TabIndex = 10;
            this.buttonListPlugins.Text = "List available plugins";
            this.buttonListPlugins.UseVisualStyleBackColor = true;
            this.buttonListPlugins.Click += new System.EventHandler(this.buttonListPlugins_Click);
            // 
            // dataGridViewPlugins
            // 
            this.dataGridViewPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPlugins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlugins.Location = new System.Drawing.Point(543, 99);
            this.dataGridViewPlugins.Name = "dataGridViewPlugins";
            this.dataGridViewPlugins.Size = new System.Drawing.Size(630, 109);
            this.dataGridViewPlugins.TabIndex = 11;
            // 
            // buttonDaemon
            // 
            this.buttonDaemon.Location = new System.Drawing.Point(543, 70);
            this.buttonDaemon.Name = "buttonDaemon";
            this.buttonDaemon.Size = new System.Drawing.Size(150, 23);
            this.buttonDaemon.TabIndex = 12;
            this.buttonDaemon.Text = "Daemon details";
            this.buttonDaemon.UseVisualStyleBackColor = true;
            this.buttonDaemon.Click += new System.EventHandler(this.buttonDaemon_Click);
            // 
            // labelDaemonStatus
            // 
            this.labelDaemonStatus.AutoSize = true;
            this.labelDaemonStatus.Location = new System.Drawing.Point(731, 60);
            this.labelDaemonStatus.Name = "labelDaemonStatus";
            this.labelDaemonStatus.Size = new System.Drawing.Size(87, 13);
            this.labelDaemonStatus.TabIndex = 13;
            this.labelDaemonStatus.Text = "Daemon status : ";
            // 
            // labelDaemonPID
            // 
            this.labelDaemonPID.AutoSize = true;
            this.labelDaemonPID.Location = new System.Drawing.Point(731, 31);
            this.labelDaemonPID.Name = "labelDaemonPID";
            this.labelDaemonPID.Size = new System.Drawing.Size(77, 13);
            this.labelDaemonPID.TabIndex = 14;
            this.labelDaemonPID.Text = "Daemon PID : ";
            // 
            // buttonDaemonStart
            // 
            this.buttonDaemonStart.Location = new System.Drawing.Point(543, 12);
            this.buttonDaemonStart.Name = "buttonDaemonStart";
            this.buttonDaemonStart.Size = new System.Drawing.Size(150, 23);
            this.buttonDaemonStart.TabIndex = 15;
            this.buttonDaemonStart.Text = "Daemon start";
            this.buttonDaemonStart.UseVisualStyleBackColor = true;
            this.buttonDaemonStart.Click += new System.EventHandler(this.buttonDaemonStart_Click);
            // 
            // buttonDaemonStop
            // 
            this.buttonDaemonStop.Location = new System.Drawing.Point(543, 41);
            this.buttonDaemonStop.Name = "buttonDaemonStop";
            this.buttonDaemonStop.Size = new System.Drawing.Size(150, 23);
            this.buttonDaemonStop.TabIndex = 16;
            this.buttonDaemonStop.Text = "Daemon stop";
            this.buttonDaemonStop.UseVisualStyleBackColor = true;
            this.buttonDaemonStop.Click += new System.EventHandler(this.buttonDaemonStop_Click);
            // 
            // textBoxRepoPath
            // 
            this.textBoxRepoPath.Location = new System.Drawing.Point(168, 14);
            this.textBoxRepoPath.Name = "textBoxRepoPath";
            this.textBoxRepoPath.Size = new System.Drawing.Size(369, 20);
            this.textBoxRepoPath.TabIndex = 17;
            // 
            // SyncanyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 217);
            this.Controls.Add(this.textBoxRepoPath);
            this.Controls.Add(this.buttonDaemonStop);
            this.Controls.Add(this.buttonDaemonStart);
            this.Controls.Add(this.labelDaemonPID);
            this.Controls.Add(this.labelDaemonStatus);
            this.Controls.Add(this.buttonDaemon);
            this.Controls.Add(this.dataGridViewPlugins);
            this.Controls.Add(this.buttonListPlugins);
            this.Controls.Add(this.textBoxConnect);
            this.Controls.Add(this.textBoxRestores);
            this.Controls.Add(this.textBoxPlugin);
            this.Controls.Add(this.buttonPlugin);
            this.Controls.Add(this.buttonRestores);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonInit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SyncanyView";
            this.Text = "Syncany";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlugins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonRestores;
        private System.Windows.Forms.Button buttonPlugin;
        private System.Windows.Forms.TextBox textBoxPlugin;
        private System.Windows.Forms.TextBox textBoxRestores;
        private System.Windows.Forms.TextBox textBoxConnect;
        private System.Windows.Forms.Button buttonListPlugins;
        private System.Windows.Forms.DataGridView dataGridViewPlugins;
        private System.Windows.Forms.Button buttonDaemon;
        private System.Windows.Forms.Label labelDaemonStatus;
        private System.Windows.Forms.Label labelDaemonPID;
        private System.Windows.Forms.Button buttonDaemonStart;
        private System.Windows.Forms.Button buttonDaemonStop;
        private System.Windows.Forms.TextBox textBoxRepoPath;
    }
}