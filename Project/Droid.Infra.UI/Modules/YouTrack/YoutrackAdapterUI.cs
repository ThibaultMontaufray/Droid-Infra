
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTrackSharp;
using YouTrackSharp.Projects;
using YouTrackSharp.Issues;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Xml.Serialization;
using Droid.Web;

namespace Droid.Infra.Modules.YouTrack.Controler
{
    public class YoutrackAdapterUI : InfraAdapter
    {
        #region Attributes
        private UsernamePasswordConnection _connector;
        private IssuesService _issueService;
        private ProjectsService _projectsService;

        private ViewYoutrackManage _viewManage;
        private ViewYoutrackTicket _viewTicket;
        private ViewYoutrackConnect _viewConnect;

        private List<Project> _projects;
        private List<Issue> _issues;
        private Issue _currentIssue;
        #endregion

        #region Properties
        [XmlIgnore]
        public UsernamePasswordConnection Connector
        {
            get { return _connector; }
            set { _connector = value; }
        }
        [XmlIgnore]
        public string ProjectName
        {
            get { return _url; }
            set { _url = value; }
        }
        [XmlIgnore]
        public List<Issue> Issues
        {
            get { return _issues; }
            set { _issues = value; }
        }
        [XmlIgnore]
        public List<Project> Projects
        {
            get { return _projects; }
            set { _projects = value; }
        }
        [XmlIgnore]
        public Issue CurrentIssue
        {
            get { return _currentIssue; }
            set { _currentIssue = value; }
        }
        public override bool Online
        {
            get { 
                try
                {
                    Task t = Task.Run(() => {
                        Ping ping = new Ping();
                        string url = Droid.Web.Web.GetPingDomain(_url);
                        PingReply reply = ping.Send(url);
                        if (reply.Status == IPStatus.Success)
                        {
                            Connection();
                            _connector?.GetBuildNumber();
                        }
                        else
                        {
                            _connector = null;
                        }
                    });
                    TimeSpan ts = TimeSpan.FromMilliseconds(3000);
                    if (!t.Wait(ts))
                    {
                        return false;
                    }
                    else
                    {
                        return _connector != null;
                    }
                }
                catch (Exception exp)
                {
                    return false;
                }
            }
        }
        #endregion

        #region Constructor
        public YoutrackAdapterUI()
        {
            _techno = TECHNO.YOUTRACK;
            _type = AdapterType.YoutrackAdapter;
            Init();
        }
        public YoutrackAdapterUI(InterfaceInfra parent)
        {
            _techno = TECHNO.YOUTRACK;
            _type = AdapterType.YoutrackAdapter;
            _parent = parent;
            Init();
        }
        #endregion

        #region ACTION
        [Description("french[connecter(login, mot_de_passe, lien)];english[connection(login, password, link)]")]
        public bool ACTION_connection(string login, string password, string link)
        {
            _login = login;
            _password = password;
            _url = link;
            Connection();
            return Online;
        }
        [Description("french[creer_ticket()];english[create_ticket()]")]
        public void ACTION_create_ticket()
        {

        }
        #endregion

        #region Mehtods public
        public override void GoAction(string action)
        {
            switch (action)
            {
                case "manage":
                    LaunchManage();
                    break;
                case "inspect":
                    LaunchInspect();
                    break;
                case "create_ticket":
                    LaunchCreateTicket();
                    break;
                case "connection":
                    LaunchConnect();
                    break;
            }
        }
        public async void RefreshDataAsync()
        {
            try
            {
                await RefreshProject();
                await RefreshIssue();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public async Task<List<Issue>> GetProjectIssues(Project project)
        {
            var issuesForCurrentProject = await _issueService.GetIssuesInProject(project.ShortName, take:1000);
            _issues =issuesForCurrentProject.ToList();
            return _issues;
        }
        #endregion

        #region Methods private
        private void Init()
        {
            _projects = new List<Project>();
            _issues = new List<Issue>();

            _url = "https://bugtrack.bimandco.com/";
            _login = "tmontaufray@bimandco.com";
            _password = "Androi7#!";
        }
        private void LaunchManage()
        {
            if (Online)
            { 
                if (_viewManage == null) { _viewManage = new ViewYoutrackManage(); }
                _viewManage.Adapter = this;
                LaunchSheet(_viewManage);
            }
            else
            {
                LaunchConnect();
            }
        }
        private void LaunchInspect()
        {
            if (_viewTicket == null) { _viewTicket = new ViewYoutrackTicket(); }
            _viewTicket.CurrentIssue = _currentIssue;
            LaunchSheet(_viewTicket);
        }
        private void LaunchCreateTicket()
        {
            if (Online)
            {
                if (_viewTicket == null) { _viewTicket = new ViewYoutrackTicket(); }
                _viewTicket.CurrentIssue = new Issue();
                LaunchSheet(_viewTicket);
            }
            else
            {
                LaunchConnect();
            }
        }
        private void LaunchConnect()
        {
            if (_viewConnect == null) { _viewConnect = new ViewYoutrackConnect(this); }
            LaunchSheet(_viewConnect);
        }

        private void Connection()
        {
            if (!string.IsNullOrEmpty(_login) && !string.IsNullOrEmpty(_password) && !string.IsNullOrEmpty(_url))
            {
                if (!string.IsNullOrEmpty(_url) && !string.IsNullOrEmpty(_login) && !string.IsNullOrEmpty(_password))
                {
                    try
                    {
                        Ping ping = new Ping();
                        string url = Droid.Web.Web.GetPingDomain(_url);
                        PingReply reply = ping.Send(url);
                        
                        if (reply.Status == IPStatus.Success)
                        {
                            _connector = new UsernamePasswordConnection(_url, _login, _password);
                        }
                    }
                    catch (Exception e)
                    {
                        _connector = null;
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }
        private async Task RefreshIssue()
        {
            if (_issueService == null) { _issueService = _connector.CreateIssuesService(); }
            var issuesForCurrentUser = await _issueService.GetIssues();
            _issues = issuesForCurrentUser.ToList();
        }
        private async Task RefreshProject()
        {
            if (_projectsService == null) { _projectsService = _connector.CreateProjectsService(); }
            var projectsForCurrentUser = await _projectsService.GetAccessibleProjects();
            _projects = projectsForCurrentUser.ToList();
        }
        protected override string BuildPanelCustom()
        {
            RefreshDataAsync();
            string html = string.Format(MONITORINGHTML, Online ? "componentOnline" : "componentOffline", "id123", "styleposition", (string.IsNullOrEmpty(_name) ? _techno.ToString() : _name));

            string detail = "<li>&nbsp;</li>";
            detail += "<li> - Issues : " + _issues.Count + "</li>";
            detail += "<li> - Projects : " + _projects.Count + "</li>";
            return html.Replace("<li>&nbsp;</li>", detail);
        }
        #endregion

        #region Event
        #endregion
    }
}
