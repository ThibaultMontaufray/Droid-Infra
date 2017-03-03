namespace Droid_Infra
{
    partial class DemoSyncany
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
            Droid_Infra.Interface_syncany interface_syncany1 = new Droid_Infra.Interface_syncany();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoSyncany));
            this.cloudView1 = new Droid_Infra.CloudView();
            this.SuspendLayout();
            // 
            // cloudView1
            // 
            this.cloudView1.BackColor = System.Drawing.Color.Transparent;
            interface_syncany1.CloudConfigPath = null;
            interface_syncany1.CloudConnectionType = null;
            interface_syncany1.CloudRepositories = ((System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>>)(resources.GetObject("interface_syncany1.CloudRepositories")));
            interface_syncany1.DirectoryOriginal = null;
            interface_syncany1.DirectoryToAssociate = null;
            interface_syncany1.Login = null;
            interface_syncany1.Password = null;
            interface_syncany1.WorkingDirectory = null;
            this.cloudView1.InterficeSyncany = interface_syncany1;
            this.cloudView1.Location = new System.Drawing.Point(0, 0);
            this.cloudView1.Name = "cloudView1";
            this.cloudView1.Size = new System.Drawing.Size(719, 336);
            this.cloudView1.TabIndex = 0;
            // 
            // DemoSyncany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(722, 342);
            this.Controls.Add(this.cloudView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DemoSyncany";
            this.Text = "Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private CloudView cloudView1;
    }
}