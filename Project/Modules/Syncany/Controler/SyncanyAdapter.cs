using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Tools4Libraries;

namespace Droid_Infra
{
    public class SyncanyAdapter
    {
        #region Attribute
        private string _cloudConfigPath;
        private List<KeyValuePair<string, string>> _cloudRepositories; // path, type of connection
        private string _directoryOriginal;
        private string _directoryToAssociate;

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
        #endregion

        #region Constructor
        public SyncanyAdapter()
        {
            _login = "demoLog";
            _password = "demoPwd";
            _cloudRepositories = new List<KeyValuePair<string, string>>();
        }
        #endregion

        #region Methods public
        public void CloudCreation()
        {
            if (!string.IsNullOrEmpty(_cloudConfigPath) && !string.IsNullOrEmpty(_directoryOriginal) && !string.IsNullOrEmpty(_cloudConnectionType))
            {
                SyncanyCommander.PluginInstall("sftp");
                SyncanyCommander.Init(_cloudConfigPath, _directoryOriginal, _login, _password, _cloudConnectionType);
                _cloudRepositories.Add(new KeyValuePair<string, string>(_directoryOriginal, _cloudConnectionType));
                Daemon.AddWatch(_directoryOriginal);
            }
        }
        public void AssociateDirectory()
        {
            if (!string.IsNullOrEmpty(_directoryToAssociate) && !string.IsNullOrEmpty(_cloudConfigPath) && !string.IsNullOrEmpty(_cloudConnectionType) && !_cloudRepositories.Contains(new KeyValuePair<string, string>(_directoryToAssociate, _cloudConnectionType)))
            {
                SyncanyCommander.Connect(_cloudConfigPath, _directoryToAssociate, _cloudConnectionType);
                _cloudRepositories.Add(new KeyValuePair<string, string>(_directoryToAssociate, _cloudConnectionType));
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
        #endregion
    }
}