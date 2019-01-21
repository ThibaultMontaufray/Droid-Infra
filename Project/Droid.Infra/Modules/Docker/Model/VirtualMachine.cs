namespace Droid.Infra
{
    using Newtonsoft.Json;
    using System;

    [Serializable]
    public class VirtualMachine
    {
        #region Attribute
        private string _name;
        private string _uuid;
        private string _iso;
        private string _state;
        private int _cpu;
        private int _memory;
        private int _vram;
        private string _configFile;
        private string _baseFolder;
        private string _os;
        private int _flag;
        private string _bootOrder;
        private int _dockerPort;
        private int _sshPort;
        private string _serialFile;
        #endregion

        #region Properties
        [JsonProperty("SerialFile")]
        public string SerialFile
        {
            get { return _serialFile; }
            set { _serialFile = value; }
        }
        [JsonProperty("SSHPort")]
        public int SSHPort
        {
            get { return _sshPort; }
            set { _sshPort = value; }
        }
        [JsonProperty("DockerPort")]
        public int DockerPort
        {
            get { return _dockerPort; }
            set { _dockerPort = value; }
        }
        [JsonProperty("BootOrder")]
        public string BootOrder
        {
            get { return _bootOrder; }
            set { _bootOrder = value; }
        }
        [JsonProperty("Flag")]
        public int Flag
        {
            get { return _flag; }
            set { _flag = value; }
        }
        [JsonProperty("OsType")]
        public string OsType
        {
            get { return _os; }
            set { _os = value; }
        }
        [JsonProperty("BaseFolder")]
        public string BaseFolder
        {
            get { return _baseFolder; }
            set { _baseFolder = value; }
        }
        [JsonProperty("CfgFile")]
        public string ConfigFile
        {
            get { return _configFile; }
            set { _configFile = value; }
        }
        [JsonProperty("VRAM")]
        public int VRAM
        {
            get { return _vram; }
            set { _vram = value; }
        }
        [JsonProperty("Memory")]
        public int RAM
        {
            get { return _memory; }
            set { _memory = value; }
        }
        [JsonProperty("CPUs")]
        public int Cpu
        {
            get { return _cpu; }
            set { _cpu = value; }
        }
        [JsonProperty("State")]
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        [JsonProperty("Iso")]
        public string Iso
        {
            get { return _iso; }
            set { _iso = value; }
        }
        [JsonProperty("UUID")]
        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        }
        [JsonProperty("Name")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        #endregion

        #region Constructor
        public VirtualMachine()
        {

        }
        #endregion

        #region Methods public
        #endregion
    }
}
