namespace Droid_Infra
{
    using Newtonsoft.Json;
    using System;

    [Serializable]
    public class Authentication
    {
        #region Attribute
        private string _storePath;
        private string _certificatCAPath;
        private string _certificatCARemotePath;
        private string _certificatServerRemotePath;
        private string _certificatServerPath;
        private string _certificatClientPath;
        private string _keyServerPath;
        private string _keyClientPath;
        private string _keyServerRemotePath;
        private string _keyPrivatePath;
        #endregion

        #region Properties
        [JsonProperty("ClientCertPath")]
        public string CertificatClientPath
        {
            get { return _certificatClientPath; }
            set { _certificatClientPath = value; }
        }
        [JsonProperty("PrivateKeyPath")]
        public string KeyPrivatePath
        {
            get { return _keyPrivatePath; }
            set { _keyPrivatePath = value; }
        }
        [JsonProperty("ServerKeyRemotePath")]
        public string KeyServerRemotePath
        {
            get { return _keyServerRemotePath; }
            set { _keyServerRemotePath = value; }
        }
        [JsonProperty("ServerCertRemotePath")]
        public string CertificatServerRemotePath
        {
            get { return _certificatServerRemotePath; }
            set { _certificatServerRemotePath = value; }
        }
        [JsonProperty("ClientKeyPath")]
        public string KeyClientPath
        {
            get { return _keyClientPath; }
            set { _keyClientPath = value; }
        }
        [JsonProperty("ServerKeyPath")]
        public string KeyServerPath
        {
            get { return _keyServerPath; }
            set { _keyServerPath = value; }
        }
        [JsonProperty("ServerCertPath")]
        public string CertificatServerPath
        {
            get { return _certificatServerPath; }
            set { _certificatServerPath = value; }
        }
        [JsonProperty("CaCertRemotePath")]
        public string CertificatCARemotePath
        {
            get { return _certificatCARemotePath; }
            set { _certificatCARemotePath = value; }
        }
        [JsonProperty("CaCertPath")]
        public string CertificatCAPath
        {
            get { return _certificatCAPath; }
            set { _certificatCAPath = value; }
        }
        [JsonProperty("StorePath")]
        public string StorePath
        {
            get { return _storePath; }
            set { _storePath = value; }
        }
        #endregion

        #region Constructor
        #endregion
    }
}
