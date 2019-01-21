using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools.Utilities;
using CodeBucket.Client;

namespace Droid.Infra.UI
{
    public partial class ViewBitbucketManage : UserControlCustom
    {
        #region Attributes
        private BitbucketAdapter _adapter;
        #endregion

        #region Properties
        public BitbucketAdapter Adapter
        {
            get { return _adapter; }
            set { _adapter = value; }
        }
        #endregion

        #region Constructor
        public ViewBitbucketManage(BitbucketAdapter adapter)
        {
            _adapter = adapter;
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public override void RefreshData()
        {
            var v1 = _adapter.Teams;
            var v = _adapter.Repositories;
            if (_adapter.CurrentRepo != null)
            {
                LoadRepo(_adapter.CurrentRepo);
            }
            LoadTeam();
        }
        public void LoadRepo(Repository repo)
        {
            _adapter.CurrentRepo = repo;
            _repoPanel.RefreshData();
        }
        #endregion

        #region Methods private
        private void Init()
        {
            _repoPanel.Adapter = _adapter;
        }
        private ContextMenuStrip GetContextMenuMain()
        {
            ContextMenuStrip docMenu = new ContextMenuStrip();
            docMenu.Items.Add(new ToolStripMenuItem("Refresh"));
            docMenu.ItemClicked += DocMenuRoot_ItemClicked;
            return docMenu;
        }
        private ContextMenuStrip GetContextMenuOwner()
        {
            ContextMenuStrip docMenu = new ContextMenuStrip();
            docMenu.Items.Add(new ToolStripMenuItem("Refresh"));
            docMenu.Items.Add(new ToolStripMenuItem("Add repository"));
            docMenu.ItemClicked += DocMenuOwner_ItemClicked;
            return docMenu;
        }
        private ContextMenuStrip GetContextMenuRepository()
        {
            ContextMenuStrip docMenu = new ContextMenuStrip();
            docMenu.Items.Add(new ToolStripMenuItem("Refresh"));
            docMenu.Items.Add(new ToolStripMenuItem("Create branch"));
            docMenu.Items.Add(new ToolStripMenuItem("Push"));
            docMenu.ItemClicked += DocMenuRepo_ItemClicked;
            return docMenu;
        }
        private void LoadTeam()
        {
            treeViewTeam.Nodes.Clear();

            TreeNode nodeTeam = null;
            TreeNode nodeRepo = null;
            TreeNode rootNode = new TreeNode("Default");
            rootNode.ContextMenuStrip = GetContextMenuMain();
            treeViewTeam.Nodes.Add(rootNode);

            if (_adapter != null && _adapter.Teams != null && _adapter.Teams.Values != null)
            {
                foreach (var owner in _adapter.Repositories.GroupBy(r => r.Owner).ToList())
                {
                    foreach (var repo in owner)
                    {
                        if (nodeTeam == null || nodeTeam.Text != owner.Key.Username)
                        {
                            nodeTeam = new TreeNode(owner.Key.Username);
                            nodeTeam.Tag = owner.Key;
                            nodeTeam.ContextMenuStrip = GetContextMenuOwner();
                            rootNode.Nodes.Add(nodeTeam);
                        }
                        nodeRepo = new TreeNode(repo.Name);
                        nodeRepo.Tag = repo;
                        nodeRepo.ContextMenuStrip = GetContextMenuRepository();
                        nodeTeam.Nodes.Add(nodeRepo);
                    }
                }
            }
            treeViewTeam.ExpandAll();
        }
        private void LoadRepository()
        {
            _adapter.CurrentRepo = (Repository)treeViewTeam.SelectedNode.Tag;
            _adapter.CurrentTeam = (User)treeViewTeam.SelectedNode.Parent.Tag;
            tabControlRepo.SelectedTab.Text = _adapter.CurrentRepo.Name;
            _repoPanel.RefreshData();
        }
        #endregion

        #region Event
        private void DocMenuRoot_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Refresh")
            {
                _adapter.RefreshAllRepo();
            }
        }
        private void DocMenuOwner_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ContextMenuStrip cms = sender as ContextMenuStrip;
            if (e.ClickedItem.Text == "Refresh")
            {
                _adapter.RefreshRepo(treeViewTeam.SelectedNode.Text);
            }
            else if (e.ClickedItem.Text == "Add repository")
            {
                _adapter.GoAction("add");
            }
        }
        private void DocMenuRepo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ContextMenuStrip cms = sender as ContextMenuStrip;
            if (e.ClickedItem.Text == "Refresh")
            {
                _adapter.RefreshRepo(treeViewTeam.SelectedNode.Text);
            }
            else if (e.ClickedItem.Text == "Create branch")
            {
                _adapter.GoAction("createbranch");
            }
            else if (e.ClickedItem.Text == "Push")
            {
                _adapter.Push();
            }
        }
        private void ViewBitBucketLogin1_ConnectionRequest(object o)
        {
            string[] connectionTab = o as string[];
            _adapter.Connect(connectionTab[0], connectionTab[1]);
        }
        private void ViewBitBucketUser1_RepoSelected(object o)
        {
            LoadRepo(o as Repository);
        }
        private void treeViewTeam_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewTeam.SelectedNode.Tag is Repository)
            {
                LoadRepository();
            }
        }
        #endregion
    }
}
