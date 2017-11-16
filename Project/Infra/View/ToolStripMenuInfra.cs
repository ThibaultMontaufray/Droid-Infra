using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tools4Libraries;

namespace Droid_Infra
{
    public class ToolStripMenuInfra : TSM
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
            TEAMCITY,
            BITBUCKET,
            VPN
        }
        #endregion

        #region Attribute
        public event EventHandlerAction ActionAppened;

        private List<INFRA_MODULE> _infraModules;

        private RibbonPanel _panelInfra;
        private RibbonButton _infraHome;
        private RibbonButton _infraOpen;
        private RibbonButton _infraSave;
        private RibbonButton _infraAdd;

        private RibbonPanel _panelComputer;
        private RibbonButton _computerManage;

        private RibbonPanel _panelDocker;
        private RibbonButton _dockerManage;
        private RibbonButton _dockerInit;
        private RibbonButton _dockerStartStop;
        private RibbonLabel _dockerStatus;

        private RibbonPanel _panelSyncany;
        private RibbonButton _syncanyManage;
        private RibbonButton _syncanyCreate;
        private RibbonButton _syncanyAssociateRepository;
        private RibbonButton _syncanySynchro;

        private RibbonPanel _panelVPN;
        private RibbonButton _vpnGlobalStatus;
        private RibbonButton _vpnAuthentication;
        private RibbonButton _vpnPassword;
        private RibbonButton _vpnSelectPKCS11Key;
        private RibbonButton _vpnSettings;
        private RibbonButton _vpnStatus;

        private RibbonPanel _panelBitbucket;
        private RibbonButton _bitbucketManage;

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
        public new void ChangeLanguage()
        {
            //_rbWelcome.Text = GetText.Text("Menu");
        }
        public void RefreshData(Interface_infra intInf)
        {
            _syncanySynchro.Image = intInf.InfraSyncany.SynchronisationRunning ? Tools4Libraries.Resources.ResourceIconSet32Default.control_pause : Tools4Libraries.Resources.ResourceIconSet32Default.control_play;
            _syncanySynchro.SmallImage = intInf.InfraSyncany.SynchronisationRunning ? Tools4Libraries.Resources.ResourceIconSet16Default.control_pause : Tools4Libraries.Resources.ResourceIconSet16Default.control_play;
        }
        #endregion

        #region Methods private
        private void Init()
        {
            BuildPanelInfra();
            BuildPanelComputer();
            BuildPanelDocker();
            BuildPanelSyncany();
            BuildPanelGitHub();
            BuildPanelBitbucket();
            BuildPanelJenkins();
            BuildPanelJira();
            BuildPanelSonar();
            BuildPanelTeamCity();
            BuildPanelVPN();

            this.Text = GetText.Text("Infra");
        }
        private void LoadModules()
        {
            if (_panelSyncany != null) _panelSyncany.Visible = _infraModules.Contains(INFRA_MODULE.CLOUD);
            if (_panelDocker != null) _panelDocker.Visible = _infraModules.Contains(INFRA_MODULE.DOCKER);
            if (_panelGitHub != null) _panelGitHub.Visible = _infraModules.Contains(INFRA_MODULE.GITHUB);
            if (_panelBitbucket != null) _panelBitbucket.Visible = _infraModules.Contains(INFRA_MODULE.BITBUCKET);
            if (_panelJenkins != null) _panelJenkins.Visible = _infraModules.Contains(INFRA_MODULE.JENKINS);
            if (_panelJira != null) _panelJira.Visible = _infraModules.Contains(INFRA_MODULE.JIRA);
            if (_panelSonar != null) _panelSonar.Visible = _infraModules.Contains(INFRA_MODULE.SONAR);
            if (_panelTeamCity != null) _panelTeamCity.Visible = _infraModules.Contains(INFRA_MODULE.TEAMCITY);
            if (_panelVPN != null) _panelVPN.Visible = _infraModules.Contains(INFRA_MODULE.VPN);
        }

        private void BuildPanelInfra()
        {
            _infraHome = new RibbonButton();
            _infraHome.Name = "Home";
            _infraHome.Text = GetText.Text(_infraHome.Name);
            _infraHome.Image = Tools4Libraries.Resources.ResourceIconSet32Default.large_tiles;
            _infraHome.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.large_tiles;
            _infraHome.MaxSizeMode = RibbonElementSizeMode.Large;
            _infraHome.Click += _infra_Click;

            _infraOpen = new RibbonButton();
            _infraOpen.Name = "Open";
            _infraOpen.Text = GetText.Text(_infraOpen.Name);
            _infraOpen.Image = Tools4Libraries.Resources.ResourceIconSet32Default.layer_open;
            _infraOpen.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.layer_open;
            _infraOpen.MaxSizeMode = RibbonElementSizeMode.Large;
            _infraOpen.Click += _infra_Click;

            _infraSave = new RibbonButton();
            _infraSave.Name = "Save";
            _infraSave.Text = GetText.Text(_infraSave.Name);
            _infraSave.Image = Tools4Libraries.Resources.ResourceIconSet32Default.layer_save;
            _infraSave.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.layer_save;
            _infraSave.MaxSizeMode = RibbonElementSizeMode.Large;
            _infraSave.Click += _infra_Click;

            _infraAdd = new RibbonButton();
            _infraAdd.Name = "Add";
            _infraAdd.Text = GetText.Text(_infraAdd.Name);
            _infraAdd.Image = Tools4Libraries.Resources.ResourceIconSet32Default.layer_add;
            _infraAdd.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.layer_add;
            _infraAdd.MaxSizeMode = RibbonElementSizeMode.Large;
            _infraAdd.Click += _infra_Click;

            _panelInfra = new RibbonPanel(GetText.Text("Infra"));
            _panelInfra.Items.Add(_infraHome);
            _panelInfra.Items.Add(_infraOpen);
            _panelInfra.Items.Add(_infraSave);
            _panelInfra.Items.Add(_infraAdd);
            this.Panels.Add(_panelInfra);

        }
        private void BuildPanelComputer()
        {
            _computerManage = new RibbonButton("Manage");
            _computerManage.Image = Tools4Libraries.Resources.ResourceIconSet32Default.computer;
            _computerManage.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.computer;
            _computerManage.MaxSizeMode = RibbonElementSizeMode.Large;
            _computerManage.Click += _computerManage_Click;

            _panelComputer = new RibbonPanel("Computer");
            _panelComputer.Items.Add(_computerManage);
            this.Panels.Add(_panelComputer);
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

            _syncanySynchro = new RibbonButton("Synchro");
            _syncanySynchro.Image = Tools4Libraries.Resources.ResourceIconSet32Default.control_pause;
            _syncanySynchro.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.control_pause;
            _syncanySynchro.MaxSizeMode = RibbonElementSizeMode.Medium;
            _syncanySynchro.Click += _SyncanyClick;
            
            _panelSyncany = new RibbonPanel("Cloud");
            _panelSyncany.Items.Add(_syncanyManage);
            _panelSyncany.Items.Add(_syncanyCreate);
            _panelSyncany.Items.Add(_syncanyAssociateRepository);
            _panelSyncany.Items.Add(_syncanySynchro);
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
        private void BuildPanelBitbucket()
        {
            _bitbucketManage = new RibbonButton("Manage");
            _bitbucketManage.Image = Properties.Resources.bitbucket;
            _bitbucketManage.SmallImage = Properties.Resources.bitbucket;
            _bitbucketManage.Click += _BitbucketClick;

            _panelBitbucket = new RibbonPanel("Bitbucket");
            _panelBitbucket.Items.Add(_bitbucketManage);
            this.Panels.Add(_panelBitbucket);
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
        private void BuildPanelVPN()
        {
            _vpnGlobalStatus = new RibbonButton("Global status");
            _vpnGlobalStatus.Image = Properties.Resources.VPN;
            _vpnGlobalStatus.SmallImage = Properties.Resources.VPN;
            _vpnGlobalStatus.Click += _vpnClick;

            _vpnAuthentication = new RibbonButton("Authentication");
            _vpnAuthentication.Image = Tools4Libraries.Resources.ResourceIconSet32Default.action_log;
            _vpnAuthentication.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.action_log;
            _vpnAuthentication.Click += _vpnClick;
            _vpnAuthentication.MaxSizeMode = RibbonElementSizeMode.Medium;

            _vpnPassword = new RibbonButton("Password");
            _vpnPassword.Image = Tools4Libraries.Resources.ResourceIconSet32Default.change_password;
            _vpnPassword.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.change_password;
            _vpnPassword.Click += _vpnClick;
            _vpnPassword.MaxSizeMode = RibbonElementSizeMode.Medium;

            _vpnSelectPKCS11Key = new RibbonButton("Select key");
            _vpnSelectPKCS11Key.Image = Tools4Libraries.Resources.ResourceIconSet32Default.key;
            _vpnSelectPKCS11Key.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.key;
            _vpnSelectPKCS11Key.Click += _vpnClick;
            _vpnSelectPKCS11Key.MaxSizeMode = RibbonElementSizeMode.Medium;

            _vpnSettings = new RibbonButton("Settings");
            _vpnSettings.Image = Tools4Libraries.Resources.ResourceIconSet32Default.setting_tools;
            _vpnSettings.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.setting_tools;
            _vpnSettings.Click += _vpnClick;
            _vpnSettings.MaxSizeMode = RibbonElementSizeMode.Medium;

            _vpnStatus = new RibbonButton("Status");
            _vpnStatus.Image = Tools4Libraries.Resources.ResourceIconSet32Default.connect;
            _vpnStatus.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.connect;
            _vpnStatus.Click += _vpnClick;
            _vpnStatus.MaxSizeMode = RibbonElementSizeMode.Medium;

            _panelVPN = new RibbonPanel("VPN");
            _panelVPN.Items.Add(_vpnGlobalStatus);
            _panelVPN.Items.Add(_vpnAuthentication);
            //_panelVPN.Items.Add(_vpnPassword);
            _panelVPN.Items.Add(_vpnSelectPKCS11Key);
            _panelVPN.Items.Add(_vpnSettings);
            //_panelVPN.Items.Add(_vpnStatus);
            this.Panels.Add(_panelVPN);
        }
        #endregion

        #region Event
        private void _infra_Click(object sender, EventArgs e)
        {
            if (sender is RibbonButton)
            {
                if (ActionAppened != null) ActionAppened(this, new ToolBarEventArgs("Infra_" + ((RibbonButton)sender).Text));
            }
        }
        private void _computerManage_Click(object sender, EventArgs e)
        {
            if (sender is RibbonButton)
            {
                if (ActionAppened != null) ActionAppened(this, new ToolBarEventArgs("Computer_" + ((RibbonButton)sender).Text));
            }
        }
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
        private void _BitbucketClick(object sender, EventArgs e)
        {
            if (sender is RibbonButton)
            {
                if (ActionAppened != null) ActionAppened(this, new ToolBarEventArgs("Bitbucket_" + ((RibbonButton)sender).Text));
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
        private void _vpnClick(object sender, EventArgs e)
        {
            if (sender is RibbonButton)
            {
                if (ActionAppened != null) ActionAppened(this, new ToolBarEventArgs("VPN_" + ((RibbonButton)sender).Text));
            }
        }
        #endregion
    }
}
