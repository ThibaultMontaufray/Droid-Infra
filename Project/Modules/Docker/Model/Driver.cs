namespace Droid_Infra
{
    using Newtonsoft.Json;
    using System;

    [Serializable]
    public class Driver
    {
        #region Attribute
        private string _ip;
        private string _sshUser;
        private int _sshPort;
        private string _name;
        private string _caCertPath;
        private string _pKeyPath;
        private bool _swarmMaster;
        private string _swarmHost;
        private string _swarmDiscovery;
        private int _cpu;
        private int _ram;
        private int _distSize;
        private string _url;
        private string _importVm;
        private string _hostOnlyCIDR;
        #endregion

        #region Properties
        [JsonProperty("HostOnlyCIDR")]
        public string HostOnlyCIDR
        {
            get { return _hostOnlyCIDR; }
            set { _hostOnlyCIDR = value; }
        }
        [JsonProperty("Boot2DockerImportVM")]
        public string ImportVam
        {
            get { return _importVm; }
            set { _importVm = value; }
        }
        [JsonProperty("Boot2DockerUrl")]
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }
        [JsonProperty("DiskSize")]
        public int DiskSize
        {
            get { return _distSize; }
            set { _distSize = value; }
        }
        [JsonProperty("Memory")]
        public int Ram
        {
            get { return _ram; }
            set { _ram = value; }
        }
        [JsonProperty("CPU")]
        public int Cpu
        {
            get { return _cpu; }
            set { _cpu = value; }
        }
        [JsonProperty("SwarmDiscovery")]
        public string SwarmDiscovery
        {
            get { return _swarmDiscovery; }
            set { _swarmDiscovery = value; }
        }
        [JsonProperty("SwarmHost")]
        public string SwarmHost
        {
            get { return _swarmHost; }
            set { _swarmHost = value; }
        }
        [JsonProperty("SwarmMaster")]
        public bool SwarmMaster
        {
            get { return _swarmMaster; }
            set { _swarmMaster = value; }
        }
        [JsonProperty("PrivateKeyPath")]
        public string PrivateKeyPath
        {
            get { return _pKeyPath; }
            set { _pKeyPath = value; }
        }
        [JsonProperty("CaCertPath")]
        public string CertificatPath
        {
            get { return _caCertPath; }
            set { _caCertPath = value; }
        }
        [JsonProperty("MachineName")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [JsonProperty("SSHPort")]
        public int SshPort
        {
            get { return _sshPort; }
            set { _sshPort = value; }
        }
        [JsonProperty("SSHUser")]
        public string SshUser
        {
            get { return _sshUser; }
            set { _sshUser = value; }
        }
        [JsonProperty("IPAddress")]
        public string IP
        {
            get { return _ip; }
            set { _ip = value; }
        }
        #endregion

        #region Constructor
        public Driver()
        {

        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        #endregion
    }
}
