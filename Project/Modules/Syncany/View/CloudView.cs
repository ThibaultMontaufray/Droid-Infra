
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tools4Libraries;

namespace Droid_Infra
{ 
    public partial class CloudView : UserControlCustom
    {
        #region Attribute
        private SyncanyAdapter _syncany;
        private string _workingDirectory;
        #endregion

        #region Properties
        public string WorkingDirectory
        {
            get { return _workingDirectory; }
            set { _workingDirectory = value; }
        }
        public SyncanyAdapter SyncanyAdapter
        {
            get { return _syncany; }
            set
            {
                _syncany = value;
                RefreshData();
            }
        }
        #endregion

        #region Constructor
        public CloudView()
        {
            _workingDirectory = null;
            _syncany = null;

            InitializeComponent();
            Init();
        }
        public CloudView(SyncanyAdapter syncany, string workingDirectory)
        {
            _workingDirectory = workingDirectory;
            _syncany = syncany;

            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public override void RefreshData()
        {
            textBoxRepoToAssociate.Text = _syncany.DirectoryToAssociate;
            comboBoxConnectionAddedRepo.Text = string.IsNullOrEmpty(_syncany.CloudConnectionType) ? "local" : _syncany.CloudConnectionType;
            
            RefreshDataDirectories();
        }
        public override void ChangeLanguage()
        {

        }
        #endregion

        #region Methods private
        private void Init()
        {
            Tools4Libraries.Log.ApplicationAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Servodroid\Droid-Infra";
            if (_syncany == null) { _syncany = new SyncanyAdapter(); }

            comboBoxConnectionAddedRepo.Items.Clear();
            foreach (Plugin plugin in SyncanyCommander.AvalailablePlugins)
            {
                comboBoxConnectionAddedRepo.Items.Add(plugin.Id);
            }
            comboBoxConnectionAddedRepo.SelectedItem = "local";
        }
        private void AddRepo()
        {
            _syncany.CloudConnectionType = comboBoxConnectionAddedRepo.SelectedItem.ToString().Trim();
            if (!string.IsNullOrEmpty(textBoxRepoToAssociate.Text) && !string.IsNullOrEmpty(_syncany.CloudConnectionType))
            {
                _syncany.DirectoryToAssociate = textBoxRepoToAssociate.Text;
                _syncany.AssociateDirectory();
                RefreshDataDirectories();
            }
        }
        private void RefreshDataDirectories()
        {
            Watch currentWatch;
            DataGridViewRow row;
            List<Watch> watchList = Daemon.WatchList;

            dataGridViewRepo.Rows.Clear();
            foreach (KeyValuePair<string, string> repo in _syncany.CloudRepositories)
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
            _syncany.SaveCloud(_workingDirectory);
        }
        #endregion
    }
}
