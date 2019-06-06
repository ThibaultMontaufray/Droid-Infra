using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tools.Utilities;
using Tools.Utilities.UI;
using Droid.Infra;

namespace Droid.Infra.UI
{
    public class ToolStripMenuInfra : Tools.Utilities.UI.TSM
    {
        #region Enum
        //public enum INFRA_MODULE
        //{
        //    DOCKER,
        //    CLOUD,
        //    GITHUB,
        //    JENKINS,
        //    JIRA,
        //    SONAR,
        //    TEAMCITY,
        //    BITBUCKET,
        //    VPN,
        //    POSTGRESQL,
        //    YOUTRACK
        //}
        #endregion

        #region Attribute
        public event EventHandlerAction ActionAppened;

        private RibbonPanel _panelInfra;
        private RibbonButton _infraHome;
        private RibbonButton _infraOpen;
        private RibbonButton _infraSave;
        private RibbonButton _infraNew;
        private RibbonButton _infraSettings;
        private RibbonButton _infraAdd;

        private RibbonPanel _panelComputer;
        private RibbonButton _computerManage;

        private RibbonPanel _panelDocker;
        private RibbonButton _dockerManage;
        private RibbonButton _dockerMap;
        private RibbonButton _dockerCompose;
        private RibbonButton _dockerImages;
        private RibbonButton _dockerContainers;
        private RibbonButton _dockerNetworks;

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
        private RibbonButton _bitbucketConnection;
        private RibbonButton _bitbucketAdd;
        private RibbonButton _bitbucketSetting;

        private RibbonPanel _panelGitHub;
        private RibbonButton _githubManage;
        private RibbonButton _githubCreateIssue;
        private RibbonButton _githubUserDetail;
        private RibbonLabel _githubDetail;
        
        private RibbonPanel _panelJenkins;
        private RibbonButton _jenkinsManage;

        private RibbonPanel _panelYoutrack;
        private RibbonButton _youtrackManage;
        private RibbonButton _youtrackConnection;
        private RibbonButton _youtrackCreateTicket;

        private RibbonPanel _panelJira;
        private RibbonButton _jiraManage;

        private RibbonPanel _panelSonar;
        private RibbonButton _sonarManage;

        private RibbonPanel _panelTeamCity;
        private RibbonButton _teamcityManage;

        private RibbonPanel _panelPostgresql;
        private RibbonButton _postgresqlManage;
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public ToolStripMenuInfra()
        {
            Init();
        }
        #endregion

        #region Methods public
        public new void ChangeLanguage()
        {
            //_rbWelcome.Text = GetText.Text("Menu");
        }
        public void RefreshData(InterfaceInfra intInf)
        {
            //this.Panels.Clear();
            
            if (_panelInfra == null) { BuildPanelInfra(); }

            foreach (var adapter in intInf.InfraFarm.Adapters)
            {
                switch (adapter.Type)
                {
                    case AdapterType.BitbucketAdapter:
                        if (_panelBitbucket == null) { BuildPanelBitbucket(); }
                        break;
                    case AdapterType.ComputerAdapter:
                        if (_panelComputer == null) { BuildPanelComputer(); }
                        break;
                    case AdapterType.DockerAdapter:
                        if (_panelDocker == null) { BuildPanelDocker(); }
                        break;
                    case AdapterType.GitHubAdapter:
                        if (_panelGitHub == null) { BuildPanelGitHub(); }
                        break;
                    case AdapterType.JenkinsAdapter:
                        if (_panelJenkins == null) { BuildPanelJenkins(); }
                        break;
                    case AdapterType.JiraAdapter:
                        if (_panelJira == null) { BuildPanelJira(); }
                        break;
                    case AdapterType.SonarAdapter:
                        if (_panelSonar == null) { BuildPanelSonar(); }
                        break;
                    case AdapterType.SyncanyAdapter:
                        if (_panelSyncany == null) { BuildPanelSyncany(); }
                        break;
                    case AdapterType.TeamCityAdapter:
                        if (_panelTeamCity == null) { BuildPanelTeamCity(); }
                        break;
                    case AdapterType.OpenVpnAdapter:
                        if (_panelVPN == null) { BuildPanelVPN(); }
                        break;
                    case AdapterType.PostGreAdapter:
                        if (_panelPostgresql == null) { BuildPanelPostGreSql(); }
                        break;
                    case AdapterType.YoutrackAdapter:
                        if (_panelYoutrack == null) { BuildPanelYoutrack(); }
                        break;
                    case AdapterType.SqlAdapter:
                    case AdapterType.MysqlAdapter:
                    default:
                        break;
                }
            }

            //_syncanySynchro.Image = intInf.InfraSyncany.SynchronisationRunning ? Tools.Utilities.UI.Resources.ResourceIconSet32Default.control_pause : Tools.Utilities.UI.Resources.ResourceIconSet32Default.control_play;
            //_syncanySynchro.SmallImage = intInf.InfraSyncany.SynchronisationRunning ? Tools.Utilities.UI.Resources.ResourceIconSet16Default.control_pause : Tools.Utilities.UI.Resources.ResourceIconSet16Default.control_play;
        }
        #endregion

        #region Methods private
        private void Init()
        {
            BuildPanelInfra();
            //BuildPanelComputer();
            //BuildPanelDocker();
            ////BuildPanelSyncany();
            ////BuildPanelGitHub();
            //BuildPanelBitbucket();
            ////BuildPanelJenkins();
            ////BuildPanelJira();
            ////BuildPanelSonar();
            //BuildPanelTeamCity();
            //BuildPanelYoutrack();
            //BuildPanelVPN();
            //BuildPanelPostGreSql();

            this.Text = GetText.Text("Infra");
        }
        
        private void BuildPanelInfra()
        {
            _infraHome = new RibbonButton();
            _infraHome.Name = "Home";
            _infraHome.Text = GetText.Text(_infraHome.Name);
            _infraHome.Image = Tools.Utilities.UI.Resources.ResourceIconSet32Default.application_view_tile;
            _infraHome.SmallImage = Tools.Utilities.UI.Resources.ResourceIconSet16Default.application_view_tile;
            _infraHome.MaxSizeMode = RibbonElementSizeMode.Large;
            _infraHome.Click += _infra_Click;

            _infraOpen = new RibbonButton();
            _infraOpen.Name = "Open";
            _infraOpen.Text = GetText.Text(_infraOpen.Name);
            _infraOpen.Image = Tools.Utilities.UI.Resources.ResourceIconSet32Default.layer_open;
            _infraOpen.SmallImage = Tools.Utilities.UI.Resources.ResourceIconSet16Default.layer_open;
            _infraOpen.MaxSizeMode = RibbonElementSizeMode.Medium;
            _infraOpen.Click += _infra_Click;

            _infraSave = new RibbonButton();
            _infraSave.Name = "Save";
            _infraSave.Text = GetText.Text(_infraSave.Name);
            _infraSave.Image = Tools.Utilities.UI.Resources.ResourceIconSet32Default.layer_save;
            _infraSave.SmallImage = Tools.Utilities.UI.Resources.ResourceIconSet16Default.layer_save;
            _infraSave.MaxSizeMode = RibbonElementSizeMode.Medium;
            _infraSave.Click += _infra_Click;

            _infraNew = new RibbonButton();
            _infraNew.Name = "New";
            _infraNew.Text = GetText.Text(_infraNew.Name);
            _infraNew.Image = Tools.Utilities.UI.Resources.ResourceIconSet32Default.layer_create;
            _infraNew.SmallImage = Tools.Utilities.UI.Resources.ResourceIconSet16Default.layer_create;
            _infraNew.MaxSizeMode = RibbonElementSizeMode.Medium;
            _infraNew.Click += _infra_Click;

            _infraSettings = new RibbonButton();
            _infraSettings.Name = "Setting";
            _infraSettings.Text = GetText.Text(_infraSettings.Name);
            _infraSettings.Image = Tools.Utilities.UI.Resources.ResourceIconSet32Default.layers;
            _infraSettings.SmallImage = Tools.Utilities.UI.Resources.ResourceIconSet16Default.layers;
            _infraSettings.MaxSizeMode = RibbonElementSizeMode.Large;
            _infraSettings.Click += _infra_Click;

            _infraAdd = new RibbonButton();
            _infraAdd.Name = "Add";
            _infraAdd.Text = GetText.Text(_infraAdd.Name);
            _infraAdd.Image = Tools.Utilities.UI.Resources.ResourceIconSet32Default.layer_add;
            _infraAdd.SmallImage = Tools.Utilities.UI.Resources.ResourceIconSet16Default.layer_add;
            _infraAdd.MaxSizeMode = RibbonElementSizeMode.Large;
            _infraAdd.Click += _infra_Click;

            _panelInfra = new RibbonPanel(GetText.Text("Infra"));
            _panelInfra.Items.Add(_infraOpen);
            _panelInfra.Items.Add(_infraSave);
            _panelInfra.Items.Add(_infraNew);
            _panelInfra.Items.Add(_infraSettings);
            _panelInfra.Items.Add(_infraHome);
            _panelInfra.Items.Add(_infraAdd);
            this.Panels.Add(_panelInfra);

        }
        private void BuildPanelComputer()
        {
            _computerManage = new RibbonButton("Manage");
            _computerManage.Image = Tools.Utilities.UI.Resources.ResourceIconSet32Default.computer;
            _computerManage.SmallImage = Tools.Utilities.UI.Resources.ResourceIconSet16Default.computer;
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
            _dockerManage.SmallImage = Properties.Resources.docker_small;
            _dockerManage.MinSizeMode = RibbonElementSizeMode.Large;
            _dockerManage.Click += _DockerClick;

            //_dockerInit = new RibbonButton("Init");
            //_dockerInit.Image = Tools.Utilities.UI.Resources.ResourceIconSet32Default.recycle;
            //_dockerInit.SmallImage = Tools.Utilities.UI.Resources.ResourceIconSet16Default.recycle;
            //_dockerInit.MaxSizeMode = RibbonElementSizeMode.Medium;
            //_dockerInit.Click += _DockerClick;

            //_dockerStartStop = new RibbonButton("Start");
            //_dockerStartStop.Image = Tools.Utilities.UI.Resources.ResourceIconSet32Default.stopwatch_start;
            //_dockerStartStop.SmallImage = Tools.Utilities.UI.Resources.ResourceIconSet16Default.stopwatch_start;
            //_dockerStartStop.MaxSizeMode = RibbonElementSizeMode.Medium;
            //_dockerStartStop.Click += _DockerClick;
            //_dockerSelectMachine
            
            _dockerCompose = new RibbonButton("Compose");
            _dockerCompose.Image = Properties.Resources.docker_compose;
            _dockerCompose.SmallImage = Properties.Resources.docker_compose_small;
            _dockerCompose.Click += _DockerClick;

            _dockerMap = new RibbonButton("Monitor");
            _dockerMap.Image = Properties.Resources.docker_monitor;
            _dockerMap.SmallImage = Properties.Resources.docker_monitor;
            _dockerMap.Click += _DockerClick;

            _dockerImages = new RibbonButton("Images");
            _dockerImages.Image = Properties.Resources.docker_image;
            _dockerImages.SmallImage = Properties.Resources.docker_image_small;
            _dockerImages.MaxSizeMode = RibbonElementSizeMode.Medium;
            _dockerImages.Click += _DockerClick;

            _dockerContainers = new RibbonButton("Containers");
            _dockerContainers.Image = Properties.Resources.docker_container;
            _dockerContainers.SmallImage = Properties.Resources.docker_container_small;
            _dockerContainers.MaxSizeMode = RibbonElementSizeMode.Medium;
            _dockerContainers.Click += _DockerClick;
            
            _dockerNetworks = new RibbonButton("Networks");
            _dockerNetworks.Image = Properties.Resources.docker_network;
            _dockerNetworks.SmallImage = Properties.Resources.docker_network_small;
            _dockerNetworks.MaxSizeMode = RibbonElementSizeMode.Medium;
            _dockerNetworks.Click += _DockerClick;

            //_dockerStatus = new RibbonLabel();
            //_dockerStatus.Text = "Status : nknow";
            //_dockerStatus.MaxSizeMode = RibbonElementSizeMode.Medium;

            _panelDocker = new RibbonPanel("Docker");
            _panelDocker.Items.Add(_dockerManage);
            _panelDocker.Image = Properties.Resources.docker;
            //_panelDocker.Items.Add(_dockerInit);
            //_panelDocker.Items.Add(_dockerStartStop);
            //_panelDocker.Items.Add(_dockerStatus);
            _panelDocker.Items.Add(_dockerCompose);
            _panelDocker.Items.Add(_dockerMap);
            _panelDocker.Items.Add(_dockerImages);
            _panelDocker.Items.Add(_dockerContainers);
            _panelDocker.Items.Add(_dockerNetworks);
            this.Panels.Add(_panelDocker);
        }
        private void BuildPanelSyncany()
        {
            _syncanyManage = new RibbonButton("Manage");
            _syncanyManage.Image = Properties.Resources.syncany;
            _syncanyManage.SmallImage = Properties.Resources.syncany;
            _syncanyManage.Click += _SyncanyClick;

            _syncanyCreate = new RibbonButton("Create");
            _syncanyCreate.Image = Tools.Utilities.UI.Resources.ResourceIconSet32Default.weather_clouds;
            _syncanyCreate.SmallImage = Tools.Utilities.UI.Resources.ResourceIconSet16Default.weather_clouds;
            _syncanyCreate.MaxSizeMode = RibbonElementSizeMode.Medium;
            _syncanyCreate.Click += _SyncanyClick;

            _syncanyAssociateRepository = new RibbonButton("Folder");
            _syncanyAssociateRepository.Image = Tools.Utilities.UI.Resources.ResourceIconSet32Default.network_folder;
            _syncanyAssociateRepository.SmallImage = Tools.Utilities.UI.Resources.ResourceIconSet16Default.network_folder;
            _syncanyAssociateRepository.MaxSizeMode = RibbonElementSizeMode.Medium;
            _syncanyAssociateRepository.Click += _SyncanyClick;

            _syncanySynchro = new RibbonButton("Synchro");
            _syncanySynchro.Image = Tools.Utilities.UI.Resources.ResourceIconSet32Default.control_pause;
            _syncanySynchro.SmallImage = Tools.Utilities.UI.Resources.ResourceIconSet16Default.control_pause;
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
            _githubCreateIssue.Image = Tools.Utilities.UI.Resources.ResourceIconSet32Default.wishlist_add;
            _githubCreateIssue.SmallImage = Tools.Utilities.UI.Resources.ResourceIconSet16Default.wishlist_add;
            _githubCreateIssue.MaxSizeMode = RibbonElementSizeMode.Medium;
            _githubCreateIssue.Click += _GithubClick;

            _githubUserDetail = new RibbonButton("User detail");
            _githubUserDetail.Image = Tools.Utilities.UI.Resources.ResourceIconSet32Default.report_user;
            _githubUserDetail.SmallImage = Tools.Utilities.UI.Resources.ResourceIconSet16Default.report_user;
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

            _bitbucketConnection = new RibbonButton("Connection");
            _bitbucketConnection.Image = Tools.Utilities.UI.Resources.ResourceIconSet32Default.report_key;
            _bitbucketConnection.SmallImage = Tools.Utilities.UI.Resources.ResourceIconSet16Default.report_key;
            _bitbucketConnection.MaxSizeMode = RibbonElementSizeMode.Medium;
            _bitbucketConnection.MinSizeMode = RibbonElementSizeMode.Medium;
            _bitbucketConnection.Click += _BitbucketClick;

            _bitbucketAdd = new RibbonButton("Add");
            _bitbucketAdd.Image = Tools.Utilities.UI.Resources.ResourceIconSet32Default.report_add;
            _bitbucketAdd.SmallImage = Tools.Utilities.UI.Resources.ResourceIconSet16Default.report_add;
            _bitbucketAdd.MaxSizeMode = RibbonElementSizeMode.Medium;
            _bitbucketAdd.MinSizeMode = RibbonElementSizeMode.Medium;
            _bitbucketAdd.Click += _BitbucketClick;

            _bitbucketSetting = new RibbonButton("Setting");
            _bitbucketSetting.Image = Tools.Utilities.UI.Resources.ResourceIconSet32Default.report_magnify;
            _bitbucketSetting.SmallImage = Tools.Utilities.UI.Resources.ResourceIconSet16Default.report_magnify;
            _bitbucketSetting.MaxSizeMode = RibbonElementSizeMode.Medium;
            _bitbucketSetting.Click += _BitbucketClick;

            _panelBitbucket = new RibbonPanel("Bitbucket");
            _panelBitbucket.Items.Add(_bitbucketManage);
            _panelBitbucket.Items.Add(_bitbucketConnection);
            _panelBitbucket.Items.Add(_bitbucketAdd);
            _panelBitbucket.Items.Add(_bitbucketSetting);
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
        private void BuildPanelYoutrack()
        {
            _youtrackManage = new RibbonButton("Manage");
            _youtrackManage.Image = Properties.Resources.youtrack;
            _youtrackManage.SmallImage = Properties.Resources.youtrack;
            _youtrackManage.Click += _youtrackClick;

            _youtrackConnection = new RibbonButton("Connection");
            _youtrackConnection.Image = Tools.Utilities.UI.Resources.ResourceIconSet32Default.application_key;
            _youtrackConnection.SmallImage = Tools.Utilities.UI.Resources.ResourceIconSet16Default.application_key; ;
            _youtrackConnection.MaxSizeMode = RibbonElementSizeMode.Medium;
            _youtrackConnection.Click += _youtrackClick;

            _youtrackCreateTicket = new RibbonButton("Create ticket");
            _youtrackCreateTicket.Image = Tools.Utilities.UI.Resources.ResourceIconSet32Default.note_add;
            _youtrackCreateTicket.SmallImage = Tools.Utilities.UI.Resources.ResourceIconSet16Default.note_add;
            _youtrackCreateTicket.MaxSizeMode = RibbonElementSizeMode.Medium;
            _youtrackCreateTicket.Click += _youtrackClick;

            _panelYoutrack = new RibbonPanel("Youtrack");
            _panelYoutrack.Items.Add(_youtrackManage);
            _panelYoutrack.Items.Add(_youtrackConnection);
            _panelYoutrack.Items.Add(_youtrackCreateTicket);
            this.Panels.Add(_panelYoutrack);
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
            _vpnGlobalStatus = new RibbonButton("Manage");
            _vpnGlobalStatus.Image = Properties.Resources.VPN;
            _vpnGlobalStatus.SmallImage = Properties.Resources.VPN;
            _vpnGlobalStatus.Click += _vpnClick;

            _vpnAuthentication = new RibbonButton("Authentication");
            _vpnAuthentication.Image = Tools.Utilities.UI.Resources.ResourceIconSet32Default.action_log;
            _vpnAuthentication.SmallImage = Tools.Utilities.UI.Resources.ResourceIconSet16Default.action_log;
            _vpnAuthentication.Click += _vpnClick;
            _vpnAuthentication.MaxSizeMode = RibbonElementSizeMode.Medium;

            _vpnPassword = new RibbonButton("Password");
            _vpnPassword.Image = Tools.Utilities.UI.Resources.ResourceIconSet32Default.change_password;
            _vpnPassword.SmallImage = Tools.Utilities.UI.Resources.ResourceIconSet16Default.change_password;
            _vpnPassword.Click += _vpnClick;
            _vpnPassword.MaxSizeMode = RibbonElementSizeMode.Medium;

            _vpnSelectPKCS11Key = new RibbonButton("Select key");
            _vpnSelectPKCS11Key.Image = Tools.Utilities.UI.Resources.ResourceIconSet32Default.key;
            _vpnSelectPKCS11Key.SmallImage = Tools.Utilities.UI.Resources.ResourceIconSet16Default.key;
            _vpnSelectPKCS11Key.Click += _vpnClick;
            _vpnSelectPKCS11Key.MaxSizeMode = RibbonElementSizeMode.Medium;

            _vpnSettings = new RibbonButton("Settings");
            _vpnSettings.Image = Tools.Utilities.UI.Resources.ResourceIconSet32Default.setting_tools;
            _vpnSettings.SmallImage = Tools.Utilities.UI.Resources.ResourceIconSet16Default.setting_tools;
            _vpnSettings.Click += _vpnClick;
            _vpnSettings.MaxSizeMode = RibbonElementSizeMode.Medium;

            _vpnStatus = new RibbonButton("Status");
            _vpnStatus.Image = Tools.Utilities.UI.Resources.ResourceIconSet32Default.connect;
            _vpnStatus.SmallImage = Tools.Utilities.UI.Resources.ResourceIconSet16Default.connect;
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
        private void BuildPanelPostGreSql()
        {
            _postgresqlManage = new RibbonButton("Manage");
            _postgresqlManage.Image = Properties.Resources.postgresql;
            _postgresqlManage.SmallImage = Properties.Resources.postgresql;
            _postgresqlManage.Click += _postgresqlClick;
            
            _panelPostgresql = new RibbonPanel("PostGreSql");
            _panelPostgresql.Items.Add(_postgresqlManage);
            this.Panels.Add(_panelPostgresql);
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
        private void _postgresqlClick(object sender, EventArgs e)
        {
            if (sender is RibbonButton)
            {
                if (ActionAppened != null) ActionAppened(this, new ToolBarEventArgs("PostGreSql_" + ((RibbonButton)sender).Text));
            }
        }
        private void _youtrackClick(object sender, EventArgs e)
        {
            if (sender is RibbonButton)
            {
                if (ActionAppened != null) ActionAppened(this, new ToolBarEventArgs("Youtrack_" + ((RibbonButton)sender).Text));
            }
        }
        #endregion
    }
}
