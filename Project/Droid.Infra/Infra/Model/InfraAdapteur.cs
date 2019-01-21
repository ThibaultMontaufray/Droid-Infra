using Droid.Infra.Modules.YouTrack.Controler;
using System;
using System.Net.NetworkInformation;
using System.Xml.Serialization;
using Tools.Utilities;

namespace Droid.Infra
{
    #region Enum
    public enum AdapterType
    {
        BitbucketAdapter,
        ComputerAdapter,
        DockerAdapter,
        GitHubAdapter,
        JenkinsAdapter,
        JiraAdapter,
        SonarAdapter,
        SyncanyAdapter,
        TeamCityAdapter,
        SqlAdapter,
        OpenVpnAdapter,
        PostGreAdapter,
        YoutrackAdapter,
        MysqlAdapter
    }
    #endregion
    
    [XmlInclude(typeof(MysqlAdapter))]
    [XmlInclude(typeof(BitbucketAdapter))]
    [XmlInclude(typeof(ComputerAdapter))]
    [XmlInclude(typeof(DockerAdapter))]
    [XmlInclude(typeof(GitHubAdapter))]
    [XmlInclude(typeof(JenkinsAdapter))]
    [XmlInclude(typeof(JiraAdapter))]
    [XmlInclude(typeof(SonarAdapter))]
    [XmlInclude(typeof(SyncanyAdapter))]
    [XmlInclude(typeof(TeamCityAdapter))]
    [XmlInclude(typeof(SqlAdapter))]
    //[XmlInclude(typeof(OpenVpnAdapter))]
    [XmlInclude(typeof(PostGreAdapter))]
    [XmlInclude(typeof(YoutrackAdapter))]    
    [Serializable]
    public abstract class InfraAdapter : GPInterface
    {
        #region Enum
        public enum TECHNO
        {
            BITBUCKET,
            DOCKER,
            GITHUB,
            JENKINS,
            JIRA,
            MYSQL,
            OPENVPN,
            POSTGRE,
            SERVER,
            SONARQUBE,
            SYNCANY,
            TEAMCITY,
            YOUTRACK
        }
        public enum ENV
        {
            NONE,
            DEV,
            TEST,
            CI,
            QUAL,
            DEPLOY,
            BACKUP,
            PREPROD,
            PROD
        }
        #endregion

        #region Attributes
        //public new event InterfaceEventHandler SheetDisplayRequested;
        [XmlIgnore]
        protected InterfaceInfra _parent;
        protected string _url;
        protected string _name;
        protected bool _online;
        protected int _id;
        protected TECHNO _techno;
        protected ENV _env;
        protected string _domain;
        protected string _ip;
        protected string _port;
        protected string _login;
        protected string _password;
        protected string _token;
        protected AdapterType _type;

        protected string MONITORINGHTML = @"<div class='smallWindow {0}' id='{1}' style='{2}'>
                        <ul>
                            <li class='componentTitle'>{3} </li>
                            <li>&nbsp;</li>
                        </ul>
                   <div class='circle-ripple'></div>
	</div>
";
        #endregion

        #region Properties
        public AdapterType Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public TECHNO Techno
        {
            get { return _techno; }
            set { _techno = value; }
        }
        public string Token
        {
            get { return _token; }
            set { _token = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }
        public string Port
        {
            get { return _port; }
            set { _port = value; }
        }
        public string Ip
        {
            get { return _ip; }
            set { _ip = value; }
        }
        public string Domain
        {
            get { return _domain; }
            set { _domain = value; }
        }
        public ENV Env
        {
            get { return _env; }
            set { _env = value; }
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
        public virtual bool Online
        {
            get
            {
                return _online;
            }
        }
        [XmlIgnore]
        public InterfaceInfra Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }
        [XmlIgnore]
        public virtual string MonitoringPanel
        {
            get
            {
                return BuildPanelCustom();
            }
        }
        #endregion

        #region Constructor
        public InfraAdapter()
        {
            System.Random ra = new Random((int)DateTime.Now.Ticks);
            _id = ra.Next();
            RefreshConnection();
        }
        #endregion

        #region Methods public
        public void RefreshStatus()
        {
            RefreshConnection();
        }
        public override void GoAction(string action)
        {
        }
        #endregion

        #region Methods protected
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
                    string url = Droid.Web.Web.GetPingDomain(_url);
                    PingReply pr = ping.Send(url);

                    _online =  pr.Status == IPStatus.Success;
                }
                catch
                {
                    _online = false;
                }
            }
        }
        protected abstract string BuildPanelCustom();

        //protected virtual string BuildPanelCustom()
        //{
        //    string html = string.Format(MONITORINGHTML, Online? "componentOnline" : "componentOffline", _name);
        //    return html;
        //}
        //protected void LaunchSheet(UserControlCustom control)
        //{
        //    if (_parent != null)
        //    { 
        //        _parent.Sheet.Controls.Clear();
        //        if (control != null)
        //        { 
        //            control.Top = _parent.TOP_OFFSET;
        //            control.RefreshData();
        //            control.Left = (_parent.Sheet.Width / 2) - (control.Width / 2);
        //            control.ChangeLanguage();
        //            control.Refresh();
        //            control.Name = "CurrentView";

        //            _parent.Sheet.Controls.Add(control);
        //        }
        //        SheetDisplayRequested?.Invoke(null);
        //    }
        //}
        #endregion
    }
}
