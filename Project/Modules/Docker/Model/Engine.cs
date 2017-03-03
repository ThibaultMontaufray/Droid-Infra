namespace Droid_Infra
{
    using Newtonsoft.Json;
    using System;

    [Serializable]
    public class Engine
    {
        #region Attribute
        private string _arbitraryFlags;

        [JsonProperty("StorePath")]
        public string ArbitraryFlag
        {
            get { return _arbitraryFlags; }
            set { _arbitraryFlags = value; }
        }
        
//"ArbitraryFlags": [],
//"Dns": null,
//"GraphDir": "",
//"Env": [],
//"Ipv6": false,
//"InsecureRegistry": [],
//"Labels": [],
//"LogLevel": "",
//"StorageDriver": "",
//"SelinuxEnabled": false,
//"TlsCaCert": "",
//"TlsCert": "",
//"TlsKey": "",
//"TlsVerify": true,
//"RegistryMirror": [],
//"InstallURL": "https://get.docker.com"
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public Engine()
        {
        }
        #endregion
    }
}
