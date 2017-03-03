namespace Droid_Infra
{
    partial class ViewDocker
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
            Droid_Infra.DockerMachine dockerMachine1 = new Droid_Infra.DockerMachine();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDocker));
            dockerManagerView1 = new Droid_Infra.DockerManagerView();
            SuspendLayout();
            // 
            // dockerManagerView1
            // 
            dockerManagerView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dockerManagerView1.DockerMachine = dockerMachine1;
            dockerManagerView1.Location = new System.Drawing.Point(0, 0);
            dockerManagerView1.Name = "dockerManagerView1";
            dockerManagerView1.Size = new System.Drawing.Size(1008, 561);
            dockerManagerView1.TabIndex = 0;
            // 
            // DEMO
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1008, 561);
            Controls.Add(dockerManagerView1);
            //FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            Name = "DEMO";
            Text = "DEMO Docker";
            ResumeLayout(false);

        }

        #endregion

        private DockerManagerView dockerManagerView1;

    }
}