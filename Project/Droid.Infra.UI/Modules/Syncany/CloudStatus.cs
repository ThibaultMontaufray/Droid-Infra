using System.Windows.Forms;

namespace Droid.Infra.UI
{
    public partial class CloudStatus : UserControl
    {
        #region Attribute
        private SyncanyAdapter _syncany;
        private string _workingDirectory;
        #endregion

        #region Properties
        public SyncanyAdapter SyncanyAdapter
        {
            get { return _syncany; }
            set { _syncany = value; }
        }
        public string WorkingDirectory
        {
            get { return _workingDirectory; }
            set { _workingDirectory = value; }
        }
        #endregion

        #region Constructor
        public CloudStatus(SyncanyAdapter syncany, string workingDirectory)
        {
            _syncany = syncany;
            _workingDirectory = workingDirectory;

            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public void RefreshData()
        {

        }
        public void ChangeLanguage()
        {

        }
        #endregion

        #region Methods private
        private void Init()
        {
            comboBoxPlugin.Items.Clear();
            comboBoxConnectionAddedRepo.Items.Clear();
            foreach (Plugin plugin in SyncanyCommander.AvalailablePlugins)
            {
                comboBoxPlugin.Items.Add(plugin.Id);
                if (!string.IsNullOrEmpty(plugin.VersionLocal)) comboBoxConnectionAddedRepo.Items.Add(plugin.Id);
            }
            comboBoxPlugin.SelectedItem = "local";
        }
        #endregion

        #region Event
        #endregion
    }
}
