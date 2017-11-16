using System;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Droid_Infra
{
    [Serializable]
    public abstract class InfraAdapteur
    {
        #region Attributes
        protected string _url;
        protected string _name;
        protected Panel _panel;
        protected bool _online;
        #endregion

        #region Properties
        public bool Online
        {
            get
            {
                return _online;
            }
        }
        public string Url 
        {
            get { return _url; }
            set { _url = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [XmlIgnore]
        public Panel Panel
        {
            get { return _panel; }
            set { _panel = value; }
        }
        #endregion

        #region Constructor
        public InfraAdapteur()
        {
            RefreshConnection();
        }
        #endregion

        #region Methods public
        public void RefreshStatus()
        {
            RefreshConnection();
        }
        #endregion

        #region Methods protected
        protected string CleanUrl()
        {
            string cleanUrl = _url;
            if (!string.IsNullOrEmpty(_url))
            {
                string[] tab = _url.Split('/');
                if (tab.Length > 2)
                {
                    cleanUrl = tab[2];
                }
            }
            return cleanUrl;
        }
        protected void RefreshConnection()
        {
            if (string.IsNullOrEmpty(_url))
            {
                _online = false;
            }
            else
            { 
                try
                {
                    Ping ping = new Ping();
                    PingReply pr = ping.Send(CleanUrl());

                    _online =  pr.Status == IPStatus.Success;
                }
                catch
                {
                    _online = false;
                }
            }
        }
        #endregion
    }
}
