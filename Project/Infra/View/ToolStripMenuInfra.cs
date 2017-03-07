using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tools4Libraries;

namespace Droid_Infra
{
    public class ToolStripMenuInfra : RibbonTab
    {
        #region Enum
        public enum INFRA_MODULE
        {
            DOCKER,
            CLOUD,
            GITHUB,
            JENKINS,
            JIRA,
            SONAR,
            TEAMCITY
        }
        #endregion

        #region Attribute
        public event EventHandlerAction ActionAppened;

        private List<INFRA_MODULE> _infraModules;

        private RibbonPanel _panelDocker;
        private RibbonButton _dockerManage;
        private RibbonButton _dockerInit;
        private RibbonButton _dockerStartStop;
        private RibbonLabel _dockerStatus;

        private RibbonPanel _panelSyncany;
        private RibbonButton _syncanyManage;
        private RibbonButton _syncanyCreate;
        private RibbonButton _syncanyAssociateRepository;
        private RibbonLabel _syncanyStatus;

        private RibbonPanel _panelGitHub;
        private RibbonButton _githubManage;
        private RibbonButton _githubCreateIssue;
        private RibbonButton _githubUserDetail;
        private RibbonLabel _githubDetail;
        
        private RibbonPanel _panelJenkins;
        private RibbonButton _jenkinsManage;

        private RibbonPanel _panelJira;
        private RibbonButton _jiraManage;

        private RibbonPanel _panelSonar;
        private RibbonButton _sonarManage;

        private RibbonPanel _panelTeamCity;
        private RibbonButton _teamcityManage;
        #endregion

        #region Properties
        public List<INFRA_MODULE> InfraModules
        {
            get { return _infraModules; }
            set
            {
                _infraModules = value;
                LoadModules();
            }
        }
        #endregion

        #region Constructor
        public ToolStripMenuInfra()
        {
            InfraModules = new List<INFRA_MODULE>();

            Init();
        }
        #endregion

        #region Methods public
        public void ChangeLanguage()
        {
            //_rbWelcome.Text = GetText.Text("Menu");
        }
        #endregion

        #region Methods private
        private void Init()
        {
            BuildPanelDocker();
            BuildPanelSyncany();
            BuildPanelGitHub();
            BuildPanelJenkins();
            BuildPanelJira();
            BuildPanelSonar();
            BuildPanelTeamCity();
        }
        private void LoadModules()
        {
            if (_panelSyncany != null) _panelSyncany.Visible = _infraModules.Contains(INFRA_MODULE.CLOUD);
            if (_panelDocker != null) _panelDocker.Visible = _infraModules.Contains(INFRA_MODULE.DOCKER);
            if (_panelGitHub != null) _panelGitHub.Visible = _infraModules.Contains(INFRA_MODULE.GITHUB);
            if (_panelJenkins != null) _panelJenkins.Visible = _infraModules.Contains(INFRA_MODULE.JENKINS);
            if (_panelJira != null) _panelJira.Visible = _infraModules.Contains(INFRA_MODULE.JIRA);
            if (_panelSonar != null) _panelSonar.Visible = _infraModules.Contains(INFRA_MODULE.SONAR);
            if (_panelTeamCity != null) _panelTeamCity.Visible = _infraModules.Contains(INFRA_MODULE.TEAMCITY);
        }

        private void BuildPanelDocker()
        {
            _dockerManage = new RibbonButton("Manage");
            _dockerManage.Image = Properties.Resources.docker;
            _dockerManage.SmallImage = Properties.Resources.docker;
            _dockerManage.Click += _DockerClick;

            _dockerInit = new RibbonButton("Init");
            _dockerInit.Image = Tools4Libraries.Resources.ResourceIconSet32Default.recycle;
            _dockerInit.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.recycle;
            _dockerInit.MaxSizeMode = RibbonElementSizeMode.Medium;
            _dockerInit.Click += _DockerClick;

            _dockerStartStop = new RibbonButton("Start");
            _dockerStartStop.Image = Tools4Libraries.Resources.ResourceIconSet32Default.stopwatch_start;
            _dockerStartStop.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.stopwatch_start;
            _dockerStartStop.MaxSizeMode = RibbonElementSizeMode.Medium;
            _dockerStartStop.Click += _DockerClick;

            _dockerStatus = new RibbonLabel();
            _dockerStatus.Text = "Status : nknow";
            _dockerStatus.MaxSizeMode = RibbonElementSizeMode.Medium;

            _panelDocker = new RibbonPanel("Docker");
            _panelDocker.Items.Add(_dockerManage);
            _panelDocker.Items.Add(_dockerInit);
            _panelDocker.Items.Add(_dockerStartStop);
            _panelDocker.Items.Add(_dockerStatus);
            this.Panels.Add(_panelDocker);
        }
        private void BuildPanelSyncany()
        {
            _syncanyManage = new RibbonButton("Manage");
            _syncanyManage.Image = Properties.Resources.syncany;
            _syncanyManage.SmallImage = Properties.Resources.syncany;
            _syncanyManage.Click += _SyncanyClick;

            _syncanyCreate = new RibbonButton("Create");
            _syncanyCreate.Image = Tools4Libraries.Resources.ResourceIconSet32Default.weather_clouds;
            _syncanyCreate.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.weather_clouds;
            _syncanyCreate.MaxSizeMode = RibbonElementSizeMode.Medium;
            _syncanyCreate.Click += _SyncanyClick;

            _syncanyAssociateRepository = new RibbonButton("Folder");
            _syncanyAssociateRepository.Image = Tools4Libraries.Resources.ResourceIconSet32Default.network_folder;
            _syncanyAssociateRepository.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.network_folder;
            _syncanyAssociateRepository.MaxSizeMode = RibbonElementSizeMode.Medium;
            _syncanyAssociateRepository.Click += _SyncanyClick;

            _syncanyStatus = new RibbonLabel();
            _syncanyStatus.Text = "Status unknow";
            _syncanyStatus.MaxSizeMode = RibbonElementSizeMode.Medium;

            _panelSyncany = new RibbonPanel("Cloud");
            _panelSyncany.Items.Add(_syncanyManage);
            _panelSyncany.Items.Add(_syncanyCreate);
            _panelSyncany.Items.Add(_syncanyAssociateRepository);
            _panelSyncany.Items.Add(_syncanyStatus);
            this.Panels.Add(_panelSyncany);
        }
        private void BuildPanelGitHub()
        {
            _githubManage = new RibbonButton("Manage");
            _githubManage.Image = Properties.Resources.github;
            _githubManage.SmallImage = Properties.Resources.github;
            _githubManage.Click += _GithubClick;

            _githubCreateIssue = new RibbonButton("Create issue");
            _githubCreateIssue.Image = Tools4Libraries.Resources.ResourceIconSet32Default.wishlist_add;
            _githubCreateIssue.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.wishlist_add;
            _githubCreateIssue.MaxSizeMode = RibbonElementSizeMode.Medium;
            _githubCreateIssue.Click += _GithubClick;

            _githubUserDetail = new RibbonButton("User detail");
            _githubUserDetail.Image = Tools4Libraries.Resources.ResourceIconSet32Default.report_user;
            _githubUserDetail.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.report_user;
            _githubUserDetail.MaxSizeMode = RibbonElementSizeMode.Medium;
            _githubUserDetail.Click += _GithubClick;

            _githubDetail = new RibbonLabel();
            _githubDetail.Text = "Detail : no synchro";
            _githubDetail.MaxSizeMode = RibbonElementSizeMode.Medium;

            _panelGitHub = new RibbonPanel("GitHub");
            _panelGitHub.Items.Add(_githubManage);
            _panelGitHub.Items.Add(_githubCreateIssue);
            _panelGitHub.Items.Add(_githubUserDetail);
            _panelGitHub.Items.Add(_githubDetail);
            this.Panels.Add(_panelGitHub);
        }
        private void BuildPanelJenkins()
        {
            _jenkinsManage = new RibbonButton("Manage");
            _jenkinsManage.Image = Properties.Resources.jenkins;
            _jenkinsManage.SmallImage = Properties.Resources.jenkins;
            _jenkinsManage.Click += _JenkinsClick;

            _panelJenkins = new RibbonPanel("Jenkins");
            _panelJenkins.Items.Add(_jenkinsManage);
            this.Panels.Add(_panelJenkins);
        }
        private void BuildPanelJira()
        {
            _jiraManage = new RibbonButton("Manage");
            _jiraManage.Image = Properties.Resources.jira;
            _jiraManage.SmallImage = Properties.Resources.jira;
            _jiraManage.Click += _JiraClick;

            _panelJira = new RibbonPanel("Jira");
            _panelJira.Items.Add(_jiraManage);
            this.Panels.Add(_panelJira);
        }
        private void BuildPanelSonar()
        {
            _sonarManage = new RibbonButton("Manage");
            _sonarManage.Image = Properties.Resources.sonar;
            _sonarManage.SmallImage = Properties.Resources.sonar;
            _sonarManage.Click += _SonarClick;

            _panelSonar = new RibbonPanel("Sonar");
            _panelSonar.Items.Add(_sonarManage);
            this.Panels.Add(_panelSonar);
        }
        private void BuildPanelTeamCity()
        {
            _teamcityManage = new RibbonButton("Manage");
            _teamcityManage.Image = Properties.Resources.teamcity;
            _teamcityManage.SmallImage = Properties.Resources.teamcity;
            _teamcityManage.Click += _TeamCityClick;

            _panelTeamCity = new RibbonPanel("TeamCity");
            _panelTeamCity.Items.Add(_teamcityManage);
            this.Panels.Add(_panelTeamCity);
        }
        #endregion

        #region Event
        private void _SyncanyClick(object sender, EventArgs e)
        {
            if (sender is RibbonButton)
            {
                if (ActionAppened != null) ActionAppened(this, new ToolBarEventArgs("Syncany_" + ((RibbonButton)sender).Text));
            }
        }
        private void _DockerClick(object sender, EventArgs e)
        {
            if (sender is RibbonButton)
            {
                if (ActionAppened != null) ActionAppened(this, new ToolBarEventArgs("Docker_" + ((RibbonButton)sender).Text));
            }
        }
        private void _GithubClick(object sender, EventArgs e)
        {
            if (sender is RibbonButton)
            {
                if (ActionAppened != null) ActionAppened(this, new ToolBarEventArgs("Github_" + ((RibbonButton)sender).Text));
            }
        }
        private void _JenkinsClick(object sender, EventArgs e)
        {
            if (sender is RibbonButton)
            {
                if (ActionAppened != null) ActionAppened(this, new ToolBarEventArgs("Jenkins_" + ((RibbonButton)sender).Text));
            }
        }
        private void _JiraClick(object sender, EventArgs e)
        {
            if (sender is RibbonButton)
            {
                if (ActionAppened != null) ActionAppened(this, new ToolBarEventArgs("Jira_" + ((RibbonButton)sender).Text));
            }
        }
        private void _SonarClick(object sender, EventArgs e)
        {
            if (sender is RibbonButton)
            {
                if (ActionAppened != null) ActionAppened(this, new ToolBarEventArgs("Sonar_" + ((RibbonButton)sender).Text));
            }
        }
        private void _TeamCityClick(object sender, EventArgs e)
        {
            if (sender is RibbonButton)
            {
                if (ActionAppened != null) ActionAppened(this, new ToolBarEventArgs("TeamCity_" + ((RibbonButton)sender).Text));
            }
        }
        #endregion
    }
}
