
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Droid_Infra
{ 
    public partial class CloudView : UserControl
    {
        #region Attribute
        private Interface_syncany _intSyn;
        #endregion

        #region Properties
        public Interface_syncany InterficeSyncany
        {
            get { return _intSyn; }
            set
            {
                _intSyn = value;
                RefreshData();
            }
        }
        #endregion

        #region Constructor
        public CloudView()
        {
            InitializeComponent();
            Init();
        }
        public CloudView(Interface_syncany intSyn)
        {
            _intSyn = intSyn;

            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public void RefreshData()
        {
            textBoxConfigPath.Text = _intSyn.CloudConfigPath;
            textBoxOriginPath.Text = _intSyn.DirectoryOriginal;
            textBoxRepoToAssociate.Text = _intSyn.DirectoryToAssociate;
            comboBoxConnectionAddedRepo.Text = _intSyn.CloudConnectionType;
            comboBoxConnectionType.Text = _intSyn.CloudConnectionType;
            RefreshDataDirectories();
        }
        #endregion

        #region Methods private
        private void Init()
        {
            Tools4Libraries.Log.ApplicationAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Servodroid\Droid-Deployer";
            _intSyn = new Interface_syncany();

            comboBoxConnectionType.Items.Clear();
            comboBoxConnectionAddedRepo.Items.Clear();
            foreach (Plugin plugin in SyncanyAdapter.AvalailablePlugins)
            {
                comboBoxConnectionType.Items.Add(plugin.Id);
                comboBoxConnectionAddedRepo.Items.Add(plugin.Id);
            }
        }
        private void CreateCloud()
        {
            _intSyn.CloudConnectionType = comboBoxConnectionType.SelectedItem.ToString().Trim();
            if (!string.IsNullOrEmpty(textBoxConfigPath.Text) && !string.IsNullOrEmpty(textBoxOriginPath.Text) && !string.IsNullOrEmpty(_intSyn.CloudConnectionType))
            {
                _intSyn.CloudConfigPath = textBoxConfigPath.Text;
                _intSyn.DirectoryOriginal = textBoxOriginPath.Text;

                _intSyn.GlobalAction("createcloud");
                RefreshDataDirectories();
            }
        }
        private void AddRepo()
        {
            _intSyn.CloudConnectionType = comboBoxConnectionAddedRepo.SelectedItem.ToString().Trim();
            if (!string.IsNullOrEmpty(textBoxRepoToAssociate.Text) && !string.IsNullOrEmpty(_intSyn.CloudConnectionType))
            {
                _intSyn.DirectoryToAssociate = textBoxRepoToAssociate.Text;
                _intSyn.GlobalAction("associatedirectory");
                RefreshDataDirectories();
            }
        }
        private void RefreshDataDirectories()
        {
            Watch currentWatch;
            DataGridViewRow row;
            List<Watch> watchList = Daemon.WatchList;

            dataGridViewRepo.Rows.Clear();
            foreach (KeyValuePair<string, string> repo in _intSyn.CloudRepositories)
            {
                List<Watch> watchListTmp = watchList.Where(w => w.Path.Equals(repo.Key)).ToList();
                if (watchListTmp.Count > 0)
                {
                    currentWatch = watchListTmp[0];

                    dataGridViewRepo.Rows.Add();
                    row = dataGridViewRepo.Rows[dataGridViewRepo.Rows.Count - 1];

                    row.Cells[ColumnEnabled.Index].Value = currentWatch != null;
                    row.Cells[ColumnPath.Index].Value = repo.Key;
                    row.Cells[ColumnTypeName.Index].Value = repo.Value;

                    switch (repo.Value.ToLower())
                    {
                        case "azure":
                            row.Cells[ColumnIcon.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.network;
                            break;
                        case "dropbox":
                            row.Cells[ColumnIcon.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.network;
                            break;
                        case "flickr":
                            row.Cells[ColumnIcon.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.flickr;
                            break;
                        case "ftp":
                            row.Cells[ColumnIcon.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.ftp;
                            break;
                        case "gui":
                            row.Cells[ColumnIcon.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.network;
                            break;
                        case "local":
                            row.Cells[ColumnIcon.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.folder;
                            break;
                        case "raid0":
                            row.Cells[ColumnIcon.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.cd;
                            break;
                        case "s3":
                            row.Cells[ColumnIcon.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.network;
                            break;
                        case "samba":
                            row.Cells[ColumnIcon.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.network;
                            break;
                        case "sftp":
                            row.Cells[ColumnIcon.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.network;
                            break;
                        case "swift":
                            row.Cells[ColumnIcon.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.network;
                            break;
                        case "webdav":
                            row.Cells[ColumnIcon.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.drive_web;
                            break;
                        default:
                            row.Cells[ColumnIcon.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.network;
                            break;
                    }
                }
            }
        }
        #endregion

        #region Event
        private void buttonBrowseConfigPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxConfigPath.Text = fbd.SelectedPath;
            }
        }
        private void buttonBrowseOriginPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxOriginPath.Text = fbd.SelectedPath;
            }
        }
        private void buttonCreateCloud_Click(object sender, EventArgs e)
        {
            CreateCloud();
        }
        private void buttonBrowseAddRepository_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxRepoToAssociate.Text = fbd.SelectedPath;
            }
        }
        private void buttonAddRepo_Click(object sender, EventArgs e)
        {
            AddRepo();
        }
        #endregion
    }
}
