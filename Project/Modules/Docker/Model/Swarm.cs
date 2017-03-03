namespace Droid_Infra
{
    using Newtonsoft.Json;
    using System;

    [Serializable]
    public class Swarm
    {
        #region Attribute
        private string _url;
        #endregion

        #region Properties
        [JsonProperty("Host")]
        public string URL
        {
            get { return _url; }
            set { _url = value; }
        }
        #endregion

        #region Constructor
        public Swarm()
        {

        }
        #endregion
    }
}
