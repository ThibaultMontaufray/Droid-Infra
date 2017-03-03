namespace Droid_Infra
{
    using Newtonsoft.Json;
    using System;
    using System.Runtime.Serialization;
    
    [Serializable]
    public class Machine
    {
        #region Attribute
        private string _name;
        private Driver _driver;
        private string _configVersion;
        private string _driverName;
        private string _storePath;
        private Host _host;
        private Swarm _swarm;
        private Engine _engine;
        private string _state;
        #endregion

        #region Properties
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        public string Name
        {
            get 
            {
                if (_driver != null) return _driver.Name;
                else return _name; 
            }
            set { _name = value; }
        }
        [JsonProperty("HostOptions")]
        public Host Host
        {
            get { return _host; }
            set { _host = value; }
        }
        [JsonProperty("StorePath")]
        public string StorePath
        {
            get { return _storePath; }
            set { _storePath = value; }
        }
        [JsonProperty("DriverName")]
        public string DriverName
        {
            get { return _driverName; }
            set { _driverName = value; }
        }
        [JsonProperty("ConfigVersion")]
        public string ConfigVersion
        {
            get { return _configVersion; }
            set { _configVersion = value; }
        }
        [JsonProperty("Driver")]
        public Driver Driver
        {
            get { return _driver; }
            set { _driver = value; }
        }
        #endregion

        #region Constructor
        public Machine()
        {
            _driver = new Driver();
        }
        #endregion

        #region Methods public
        #endregion
    }
}
