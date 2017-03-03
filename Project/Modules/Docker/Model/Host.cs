namespace Droid_Infra
{
    using Newtonsoft.Json;
    using System;

    [Serializable]
    public class Host
    {
        #region Attribute
        private string _driver;
        private int _ram;
        private int _disk;
        private Engine _engin;
        private Swarm _swarm;
        private Authentication _auth;
        #endregion

        #region Properties
        [JsonProperty("AuthOptions")]
        public Authentication Auth
        {
            get { return _auth; }
            set { _auth = value; }
        }
        [JsonProperty("SwarmOptions")]
        public Swarm Swarm
        {
            get { return _swarm; }
            set { _swarm = value; }
        }
        [JsonProperty("EngineOptions")]
        public Engine Engine
        {
            get { return _engin; }
            set { _engin = value; }
        }
        [JsonProperty("Disk")]
        public int Disk
        {
            get { return _disk; }
            set { _disk = value; }
        }
        [JsonProperty("Memory")]
        public int Ram
        {
            get { return _ram; }
            set { _ram = value; }
        }
        [JsonProperty("Driver")]
        public string Driver
        {
            get { return _driver; }
            set { _driver = value; }
        }        
        #endregion

        #region Constructor
        public Host()
        {
        }
        #endregion
    }
}
