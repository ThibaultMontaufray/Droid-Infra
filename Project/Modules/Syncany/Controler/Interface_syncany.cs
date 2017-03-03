using System.Collections.Generic;

namespace Droid_Infra
{
    public class Interface_syncany
    {
        #region Attribute
        private string _cloudConfigPath;
        private List<KeyValuePair<string, string>> _cloudRepositories; // path, type of connection
        private string _directoryOriginal;
        private string _directoryToAssociate;
        private string _workingDirectory;

        private string _login;
        private string _password;
        private string _cloudConnectionType;
        #endregion

        // TODO : control daemon and the watch list

        #region Properties
        public string CloudConnectionType
        {
            get { return _cloudConnectionType; }
            set { _cloudConnectionType = value; }
        }
        public List<KeyValuePair<string, string>> CloudRepositories
        {
            get { return _cloudRepositories; }
            set { _cloudRepositories = value; }
        }
        public string CloudConfigPath
        {
            get { return _cloudConfigPath; }
            set { _cloudConfigPath = value; }
        }
        public string DirectoryToAssociate
        {
            get { return _directoryToAssociate; }
            set { _directoryToAssociate = value; }
        }
        public string DirectoryOriginal
        {
            get { return _directoryOriginal; }
            set { _directoryOriginal = value; }
        }
        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string WorkingDirectory
        {
            get { return _workingDirectory; }
            set { _workingDirectory = value; }
        }
        #endregion

        #region Constructor
        public Interface_syncany()
        {
            _login = "demoLog";
            _password = "demoPwd";
            _cloudRepositories = new List<KeyValuePair<string, string>>();
        }
        #endregion

        #region Methods public
        #region ACTIONS
        //public static void ACTION_lancer_syncdocker_130()
        //{
        //    Syncany.SyncanyView syncancyView = new Syncany.SyncanyView();
        //    syncancyView.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        //    syncancyView.ShowDialog();
        //}
        #endregion

        public void GlobalAction(string action)
        {
            switch (action)
            {
                case "createcloud":
                    LaunchCloudCreation();
                    break;
                case "associatedirectory":
                    LaunchAssociateDirectory();
                    break;
            }
        }
        #endregion

        #region Methods private
        private void LaunchCloudCreation()
        {
            if (!string.IsNullOrEmpty(_cloudConfigPath) && !string.IsNullOrEmpty(_directoryOriginal) && !string.IsNullOrEmpty(_cloudConnectionType))
            { 
                SyncanyAdapter.PluginInstall("sftp");
                SyncanyAdapter.Init(_cloudConfigPath, _directoryOriginal, _login, _password, _cloudConnectionType);
                _cloudRepositories.Add(new KeyValuePair<string, string>(_directoryOriginal, _cloudConnectionType));
                Daemon.AddWatch(_directoryOriginal);
            }
        }
        private void LaunchAssociateDirectory()
        {
            if (!string.IsNullOrEmpty(_directoryToAssociate) && !string.IsNullOrEmpty(_cloudConfigPath) && !string.IsNullOrEmpty(_cloudConnectionType) && !_cloudRepositories.Contains(new KeyValuePair<string, string> (_directoryToAssociate, _cloudConnectionType)))
            {
                SyncanyAdapter.Connect(_cloudConfigPath, _directoryToAssociate, _cloudConnectionType);
                _cloudRepositories.Add(new KeyValuePair<string, string>(_directoryToAssociate, _cloudConnectionType));
                Daemon.AddWatch(_directoryToAssociate);
            }
        }
        #endregion
    }
}