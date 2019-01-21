//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Drawing;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Droid.Infra.UI
//{
//    public partial class ViewSyncany : UserControl
//    {
//        #region Attribute
//        private System.ComponentModel.IContainer components = null;
//        private CloudView cloudView1;
//        private Tools4Libraries.PanelCustom panelCustom1;

//        private SyncanyAdapter _syncany;
//        private string _workingDirectory;
//        #endregion

//        #region Properties
//        public string WorkingDirectory
//        {
//            get { return _workingDirectory; }
//            set { _workingDirectory = value; }
//        }
//        public SyncanyAdapter SyncanyAdapter
//        {
//            get { return _syncany; }
//            set { _syncany = value; }
//        }
//        #endregion

//        #region Constructor
//        public ViewSyncany(SyncanyAdapter syncany, string workingDirectory)
//        {
//            InitializeComponent();
//            InitializeComponentCustom();
//        }
//        #endregion

//        #region Methods public
//        #endregion

//        #region Methods protected
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//        #endregion

//        #region Methods private
//        private void InitializeComponent()
//        {
//            Droid.Infra.SyncanyAdapter syncanyAdapter1 = new Droid.Infra.SyncanyAdapter();
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSyncany));
//            this.panelCustom1 = new Tools4Libraries.PanelCustom();
//            this.cloudView1 = new Droid.Infra.CloudView();
//            this.SuspendLayout();
//            // 
//            // panelCustom1
//            // 
//            this.panelCustom1.BackColor = System.Drawing.Color.Transparent;
//            this.panelCustom1.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.panelCustom1.Location = new System.Drawing.Point(0, 0);
//            this.panelCustom1.Name = "panelCustom1";
//            this.panelCustom1.Size = new System.Drawing.Size(770, 390);
//            this.panelCustom1.TabIndex = 1;
//            // 
//            // cloudView1
//            // 
//            this.cloudView1.BackColor = System.Drawing.Color.Transparent;
//            this.cloudView1.Location = new System.Drawing.Point(0, 0);
//            this.cloudView1.Name = "cloudView1";
//            this.cloudView1.Size = new System.Drawing.Size(760, 380);
//            syncanyAdapter1.CloudConfigPath = null;
//            syncanyAdapter1.CloudConnectionType = null;
//            syncanyAdapter1.CloudRepositories = ((System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>>)(resources.GetObject("syncanyAdapter1.CloudRepositories")));
//            syncanyAdapter1.DirectoryOriginal = null;
//            syncanyAdapter1.DirectoryToAssociate = null;
//            syncanyAdapter1.Login = "demoLog";
//            syncanyAdapter1.Password = "demoPwd";
//            this.cloudView1.SyncanyAdapter = syncanyAdapter1;
//            this.cloudView1.TabIndex = 0;
//            this.cloudView1.WorkingDirectory = null;
//            // 
//            // ViewSyncany
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackColor = System.Drawing.Color.Transparent;
//            this.Controls.Add(this.panelCustom1);
//            this.Name = "ViewSyncany";
//            this.Size = new System.Drawing.Size(770, 390);
//            this.ResumeLayout(false);

//        }
//        private void InitializeComponentCustom()
//        {
//            panelCustom1.panelMiddle.Controls.Add(this.cloudView1);
//        }
//        #endregion
//    }
//}
