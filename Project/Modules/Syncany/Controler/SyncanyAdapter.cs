using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Tools4Libraries;

namespace Droid_Infra
{
    [Serializable]
    [XmlType("parameters")]
    public class SyncanyAdapter
    {
        #region Attribute
        private string _cloudConfigPath;
        private List<string> _cloudRepositories; // path, type of connection
        private string _directoryOriginal;
        private string _directoryToAssociate;

        private string _login;
        private string _password;
        private string _cloudConnectionType;
        private Timer _timer;
        private DateTime _lastSynchronisation;
        #endregion

        // TODO : control daemon and the watch list

        #region Properties
        //[XmlArray("CloudRepositories")]
        //[XmlArrayItem("key", typeof(string))]
        //[XmlArrayItem("value", typeof(string))]
        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public List<string> CloudRepositories
        {
            get { return _cloudRepositories; }
            set { _cloudRepositories = value; }
        }
        public string CloudConnectionType
        {
            get { return _cloudConnectionType; }
            set { _cloudConnectionType = value; }
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
        public DateTime LastSynchronisation
        {
            get { return _lastSynchronisation; }
        }
        public bool SynchronisationRunning
        {
            get { return _timer.Enabled; }
        }
        #endregion

        #region Constructor
        public SyncanyAdapter()
        {
            _login = "demoLog";
            _password = "demoPwd";
            _cloudRepositories = new List<string>();

            _lastSynchronisation = DateTime.MinValue;

            _timer = new Timer();
            _timer.Interval = 60000 * 7; // every 7 minutes
            _timer.Tick += _timer_Tick; ;
            _timer.Start();
        }
        #endregion

        #region Methods public
        public void Synchronize()
        {
            ProcessSynchronisation();
        }
        public void SuspendSynchro()
        {
            _timer.Stop();
        }
        public void ResumeSynchro()
        {
            _timer.Start();
        }
        public void CloudCreation()
        {
            if (!string.IsNullOrEmpty(_cloudConfigPath) && !string.IsNullOrEmpty(_directoryOriginal) && !string.IsNullOrEmpty(_cloudConnectionType))
            {
                SyncanyCommander.PluginInstall("sftp");
                SyncanyCommander.Init(_cloudConfigPath, _directoryOriginal, _login, _password, _cloudConnectionType);
                string newRepo = string.Format("{0}|local", _directoryOriginal);
                if (!_cloudRepositories.Contains(newRepo)) { _cloudRepositories.Add(newRepo); }
                Daemon.AddWatch(_directoryOriginal);
            }
        }
        public void AssociateDirectory()
        {
            if (!string.IsNullOrEmpty(_directoryToAssociate) && !string.IsNullOrEmpty(_cloudConfigPath) && !string.IsNullOrEmpty(_cloudConnectionType) && !_cloudRepositories.Contains(_directoryToAssociate))
            {
                SyncanyCommander.Connect(_cloudConfigPath, _directoryToAssociate, _cloudConnectionType);
                string newRepo = string.Format("{0}|{1}", _directoryToAssociate, _cloudConnectionType);
                if (!_cloudRepositories.Contains(newRepo)) { _cloudRepositories.Add(newRepo); }
                Daemon.AddWatch(_directoryToAssociate);
            }
        }
        public void SaveCloud(string workingDirectory)
        {
            string serializedObject = string.Empty;

            XmlSerializer xsSubmit = new XmlSerializer(typeof(SyncanyAdapter));
            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, this);
                    serializedObject = sww.ToString();
                }
            }

            using (StreamWriter sw = new StreamWriter(Path.Combine(workingDirectory, "syncany.xml"), false))
            {
                sw.Write(serializedObject);
            }
        }
        public void LoadCloud(string workingDirectory)
        {
            SyncanyAdapter interfaceTmp;
            string fileData = string.Empty;

            interfaceTmp = new SyncanyAdapter();

            if (File.Exists(Path.Combine(workingDirectory, "syncany.xml")))
            {
                using (StreamReader sr = new StreamReader(Path.Combine(workingDirectory, "syncany.xml")))
                {
                    fileData = sr.ReadToEnd();
                }
                XmlSerializer xsSubmit = new XmlSerializer(typeof(SyncanyAdapter));
                using (var sww = new StringReader(fileData))
                {
                    using (XmlReader reader = XmlReader.Create(sww))
                    {
                        try
                        {
                            interfaceTmp = (SyncanyAdapter)xsSubmit.Deserialize(reader);
                        }
                        catch (Exception exp)
                        {
                            Log.Write("[ ERR 0800 ] Cannot load syncany xml file : " + exp.Message);
                            interfaceTmp = new SyncanyAdapter();
                        }
                    }
                }
            }
            else
            {
                interfaceTmp = new SyncanyAdapter();
            }
            Import(interfaceTmp, this);
        }
        #endregion

        #region Methods private
        private void Import(SyncanyAdapter src, SyncanyAdapter target)
        {
            target._cloudConfigPath = src._cloudConfigPath;
            target._cloudRepositories = src.CloudRepositories;
            target._directoryOriginal = src.DirectoryOriginal;
            target._directoryToAssociate = src.DirectoryToAssociate;
            target._login = src.Login;
            target._password = src.Password;
            target._cloudConnectionType = src.CloudConnectionType;
        }
        private async void ProcessSynchronisation()
        {
            Task<bool> taskSync = TaskSynchro();
            bool result = await taskSync;
        }
        private async Task<bool> TaskSynchro()
        {
            Task<bool> res1 = PushAll();
            bool r1 = await res1;
            
            Task<bool> res2 = PullAll();
            bool r2 = await res2;

            _lastSynchronisation = _lastSynchronisation < DateTime.Now ? DateTime.Now : _lastSynchronisation;

            return true;
        }
        private async Task<bool> PushAll()
        {
            foreach (var repo in _cloudRepositories)
            {
                SyncanyCommander.Up(repo.Split('|')[0]);
            }
            return true;
        }
        private async Task<bool> PullAll()
        {
            foreach (var repo in _cloudRepositories)
            {
                SyncanyCommander.Down(repo.Split('|')[0]);
            }
            return true;
        }
        #endregion

        #region Event
        private void _timer_Tick(object sender, EventArgs e)
        {
            ProcessSynchronisation();
        }
        #endregion
    }
}