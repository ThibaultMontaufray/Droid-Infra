
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tools4Libraries;

namespace Droid_Infra
{ 
    public partial class CloudCreate : UserControlCustom
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
        public CloudCreate()
        {
            _workingDirectory = null;
            _syncany = null;

            InitializeComponent();
            Init();
        }
        public CloudCreate(SyncanyAdapter syncany, string workingDirectory)
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
            textBoxConfigPath.Text = string.IsNullOrEmpty(_syncany.CloudConfigPath) ? Path.Combine(_workingDirectory, "Config") : _syncany.CloudConfigPath;
            textBoxOriginPath.Text = string.IsNullOrEmpty(_syncany.DirectoryOriginal) ? Path.Combine(_workingDirectory, "Cloud") : _syncany.DirectoryOriginal;
            comboBoxConnectionType.Text = string.IsNullOrEmpty(_syncany.CloudConnectionType) ? "local" : _syncany.CloudConnectionType;

            buttonCreate.Enabled = string.IsNullOrEmpty(_syncany.CloudConfigPath);
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

            comboBoxConnectionType.Items.Clear();
            foreach (Plugin plugin in SyncanyCommander.AvalailablePlugins)
            {
                comboBoxConnectionType.Items.Add(plugin.Id);
            }
            comboBoxConnectionType.SelectedItem = "local";
        }
        private void CreateCloud()
        {
            _syncany.CloudConnectionType = comboBoxConnectionType.SelectedItem.ToString().Trim();
            if (!string.IsNullOrEmpty(textBoxConfigPath.Text) && !string.IsNullOrEmpty(textBoxOriginPath.Text) && !string.IsNullOrEmpty(_syncany.CloudConnectionType))
            {
                _syncany.CloudConfigPath = textBoxConfigPath.Text;
                _syncany.DirectoryOriginal = textBoxOriginPath.Text;

                if (!Directory.Exists(_workingDirectory)) { Directory.CreateDirectory(_workingDirectory); }
                if (!Directory.Exists(_syncany.CloudConfigPath)) { Directory.CreateDirectory(_syncany.CloudConfigPath); }
                if (!Directory.Exists(_syncany.DirectoryOriginal)) { Directory.CreateDirectory(_syncany.DirectoryOriginal); }

                _syncany.CloudCreation();
            }
        }
        #endregion

        #region Event
        private void buttonBrowseConfigPath_Click_1(object sender, EventArgs e)
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
            _syncany.SaveCloud(_workingDirectory);
        }
        #endregion
    }
}
