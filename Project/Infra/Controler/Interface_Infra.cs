using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Tools4Libraries;

namespace Droid_Infra
{
    public delegate void InterfaceEventHandler();
    public class Interface_infra : GPInterface
    {
        #region Attribute
        public readonly int TOP_OFFSET = 175;
        public event InterfaceEventHandler SheetDisplayRequested;

        private Boot2Docker _docker;
        private ToolStripMenuInfra _tsm;
        private Panel _sheet;
        private string _workingDirectory;
        
        private ViewDocker _viewDocker;

        private PanelCustom _viewSyncanyRepositories;
        private PanelCustom _viewSyncanyCreate;
        private PanelCustom _viewSyncanyManage;

        private GitHubAdapter _githubAdapter;
        private PanelCustom _viewGithubIssue;
        private PanelCustom _viewGithubUserDetail;
        private PanelCustom _viewGithubManage;

        private SyncanyAdapter _infraSyncany;
        private Timer _timer;
        #endregion

        #region Properties
        public GitHubAdapter GitHubAdapter
        {
            get { return _githubAdapter; }
            set { _githubAdapter = value; }
        }
        public SyncanyAdapter InfraSyncany
        {
            get { return _infraSyncany; }
            set { _infraSyncany = value; }
        }
        public string WorkingDirectory
        {
            get { return _workingDirectory; }
            set { _workingDirectory = value; }
        }
        public Boot2Docker Docker
        {
            get { return _docker; }
            set { _docker = value; }
        }
        public Panel Sheet
        {
            get { return _sheet; }
            set { _sheet = value; }
        }
        public ToolStripMenuInfra Tsm
        {
            get { return _tsm; }
            set { _tsm = value as ToolStripMenuInfra; }
        }
        #endregion

        #region Constructor
        public Interface_infra(string workingDirectory)
        {
            _workingDirectory = workingDirectory;
            Init();
        }
        #endregion

        #region Methods public
        #region Methods Public override
        public override void GlobalAction(object sender, EventArgs e)
        {
            ToolBarEventArgs tbea = e as ToolBarEventArgs;
            string action = tbea.EventText;
            GoAction(action);
        }
        public override void Refresh()
        {
            _tsm.RefreshData(this);
        }
        public override void Resize()
        {
            foreach (Control ctrl in _sheet.Controls)
            {
                if (ctrl.Name.Equals("CurrentView"))
                {
                    ctrl.Left = (_sheet.Width / 2) - (ctrl.Width / 2);
                }
            }
        }
        #endregion

        public System.Windows.Forms.RibbonTab BuildToolBar()
        {
            _tsm = new ToolStripMenuInfra();
            _tsm.InfraModules.Add(ToolStripMenuInfra.INFRA_MODULE.CLOUD);
            _tsm.InfraModules.Add(ToolStripMenuInfra.INFRA_MODULE.DOCKER);
            _tsm.InfraModules.Add(ToolStripMenuInfra.INFRA_MODULE.GITHUB);
            _tsm.InfraModules.Add(ToolStripMenuInfra.INFRA_MODULE.JENKINS);
            _tsm.InfraModules.Add(ToolStripMenuInfra.INFRA_MODULE.JIRA);
            _tsm.InfraModules.Add(ToolStripMenuInfra.INFRA_MODULE.SONAR);
            _tsm.InfraModules.Add(ToolStripMenuInfra.INFRA_MODULE.TEAMCITY);
            _tsm.ActionAppened += GlobalAction;
            return _tsm;
        }
        
        #region ACTIONS
        public static void ACTION_lancer_docker_130()
        {
            ViewDocker ddp = new ViewDocker();
            //ddp.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            //ddp.ShowDialog();
        }
        #endregion

        public void GoAction(string action)
        {
            switch (action)
            {
                // SYNCANY
                case "Syncany_Manage":
                    LaunchSyncanyManage();
                    break;
                case "Syncany_Create":
                    LaunchSyncanyCreate();
                    break;
                case "Syncany_Folder":
                    LaunchSyncanyRepositories();
                    break;
                case "Syncany_Load":
                    LaunchSyncanyLoad();
                    break;
                case "Syncany_Save":
                    LaunchSyncanySave();
                    break;
                case "Syncany_Synchro":
                    LaunchSyncanySynchro();
                    break;
                // DOCKER
                case "Docker_Manage":
                    break;
                case "Docker_Init":
                    LaunchDockerInit();
                    break;
                case "Docker_Start":
                    LaunchDockerStart();
                    break;
                // GITHUB
                case "Github_Manage":
                    LaunchGithubManage();
                    break;
                case "Github_Create issue":
                    LaunchGithubIssue();
                    break;
                case "Github_User detail":
                    LaunchGitHubUserDetail();
                    break;
                // JENKINS
                case "Jenkins_Manage":
                    LaunchJenkinsManage();
                    break;
                // SONAR
                case "Sonar_Manage":
                    LaunchSonarManage();
                    break;
                // JIRA
                case "Jira_Manage":
                    LaunchJiraManage();
                    break;
                // TEAMCITY
                case "TeamCity_Manage":
                    LaunchTeamCityManage();
                    break;
            }
        }
        #endregion

        #region Methods private
        private void Init()
        {
            _sheet = new Panel();
            _sheet.BackgroundImage = Properties.Resources.ShieldTileBg;
            _sheet.BackgroundImageLayout = ImageLayout.Tile;
            _sheet.Dock = DockStyle.Fill;
            _sheet.Resize += _sheet_Resize;

            InitSyncany();
            InitGithub();
            InitDocker();

            BuildToolBar();

            _timer = new Timer();
            _timer.Interval = 20000;
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }
        private void InitSyncany()
        {
            _infraSyncany = new SyncanyAdapter();

            _viewSyncanyRepositories = new PanelCustom(new CloudRepositories(_infraSyncany, _workingDirectory));
            _viewSyncanyRepositories.Name = "CurrentView";
            
            _viewSyncanyCreate = new PanelCustom(new CloudCreate(_infraSyncany, _workingDirectory));
            _viewSyncanyCreate.Name = "CurrentView";

            _viewSyncanyManage = new PanelCustom(new CloudManage(_infraSyncany, _workingDirectory));
            _viewSyncanyManage.Name = "CurrentView";
        }
        private void InitGithub()
        {
            _githubAdapter = new GitHubAdapter();
            _githubAdapter.RepoUser = "ThibaultMontaufray";
            _githubAdapter.User = Properties.Settings.Default.User;
            _githubAdapter.Password = Properties.Settings.Default.Password;
            _githubAdapter.LogUser();

            GitHubIssue gitHubIssue = new GitHubIssue(this);
            gitHubIssue.Repositories = new List<string>() { "Booking", "Financial", "People", "Infra" };
            _viewGithubIssue = new PanelCustom(gitHubIssue);
            _viewGithubIssue.Name = "CurrentView";

            GitHubUserDetail githubUserDetail = new GitHubUserDetail(this);
            _viewGithubUserDetail = new PanelCustom(githubUserDetail);
            _viewGithubUserDetail.Name = "CurrentView";

            GithubManage githubManage = new GithubManage(this);
            _viewGithubManage = new PanelCustom(githubManage);
            _viewGithubManage.Name = "CurrentView";
        }
        private void InitDocker()
        {
            _docker = new Boot2Docker();
            _viewDocker = new ViewDocker();
            _viewDocker.Name = "CurrentView";
        }

        private void LaunchDockerInit()
        {
            _docker.Init();
        }
        private void LaunchDockerStatus()
        {
            _docker.RefreshStatus();
        }
        private void LaunchDockerStart()
        {
            _docker.Start();
        }
        private void LaunchDockerStop()
        {
            _docker.Stop();
        }
        private void LaunchDockerManage()
        {
            _sheet.Controls.Clear();

            if (_viewDocker == null) _viewDocker = new ViewDocker();

            _viewDocker.Dock = DockStyle.Fill;
            _sheet.Controls.Add(_viewDocker);
            if (SheetDisplayRequested != null) SheetDisplayRequested();
        }
        private void LaunchSyncanyManage()
        {
            _sheet.Controls.Clear();

            if (_viewSyncanyManage == null) { InitSyncany(); }

            _viewSyncanyManage.Top = TOP_OFFSET;
            _viewSyncanyManage.RefreshData();
            _viewSyncanyManage.Left = (_sheet.Width / 2) - (_viewSyncanyManage.Width / 2);
            _viewSyncanyManage.ChangeLanguage();
            _sheet.Controls.Add(_viewSyncanyManage);
            if (SheetDisplayRequested != null) SheetDisplayRequested();
        }
        private void LaunchSyncanyCreate()
        {
            _sheet.Controls.Clear();

            if (_viewSyncanyCreate == null) { InitSyncany(); }

            _viewSyncanyCreate.Top = TOP_OFFSET;
            _viewSyncanyCreate.RefreshData();
            _viewSyncanyCreate.Left = (_sheet.Width / 2) - (_viewSyncanyCreate.Width / 2);
            _viewSyncanyCreate.ChangeLanguage();
            _sheet.Controls.Add(_viewSyncanyCreate);
            if (SheetDisplayRequested != null) SheetDisplayRequested();
        }
        private void LaunchSyncanyRepositories()
        {
            _sheet.Controls.Clear();

            if (_viewSyncanyRepositories == null) _viewSyncanyRepositories = new PanelCustom(new CloudRepositories(_infraSyncany, _workingDirectory));

            _viewSyncanyRepositories.Top = TOP_OFFSET;
            _viewSyncanyRepositories.RefreshData();
            _viewSyncanyRepositories.Left = (_sheet.Width / 2) - (_viewSyncanyRepositories.Width / 2);
            _viewSyncanyRepositories.ChangeLanguage();
            _sheet.Controls.Add(_viewSyncanyRepositories);
            if (SheetDisplayRequested != null) SheetDisplayRequested();
        }
        private void LaunchSyncanyLoad()
        {
            _infraSyncany.LoadCloud(_workingDirectory);
        }
        private void LaunchSyncanySave()
        {
            _infraSyncany.SaveCloud(_workingDirectory);
        }
        private void LaunchSyncanySynchro()
        {
            if (_infraSyncany.SynchronisationRunning)
            {
                _infraSyncany.SuspendSynchro();
            }
            else
            {
                _infraSyncany.ResumeSynchro();
            }
            _timer.Stop();
            _tsm.RefreshData(this);
            _timer.Start();
        }
        private void LaunchGithubManage()
        {
            _sheet.Controls.Clear();

            if (_viewGithubManage == null) { InitGithub(); }

            _viewGithubManage.Top = TOP_OFFSET;
            _viewGithubManage.RefreshData();
            _viewGithubManage.Left = (_sheet.Width / 2) - (_viewGithubManage.Width / 2);
            _viewGithubManage.ChangeLanguage();
            _sheet.Controls.Add(_viewGithubManage);
            if (SheetDisplayRequested != null) SheetDisplayRequested();
        }
        private void LaunchGitHubUserDetail()
        {
            _sheet.Controls.Clear();
            
            if (_viewGithubUserDetail == null) { InitGithub(); }

            _viewGithubUserDetail.Top = TOP_OFFSET;
            _viewGithubUserDetail.RefreshData();
            _viewGithubUserDetail.Left = (_sheet.Width / 2) - (_viewGithubUserDetail.Width / 2);
            _viewGithubUserDetail.ChangeLanguage();
            _sheet.Controls.Add(_viewGithubUserDetail);
            if (SheetDisplayRequested != null) SheetDisplayRequested();
        }
        private void LaunchGithubIssue()
        {
            _sheet.Controls.Clear();

            if (_viewGithubIssue == null) { InitGithub(); }

            _viewGithubIssue.Top = TOP_OFFSET;
            _viewGithubIssue.RefreshData();
            _viewGithubIssue.Left = (_sheet.Width / 2) - (_viewGithubIssue.Width / 2);
            _viewGithubIssue.ChangeLanguage();
            _sheet.Controls.Add(_viewGithubIssue);
            if (SheetDisplayRequested != null) SheetDisplayRequested();
        }

        private void LaunchJiraManage()
        {
            _sheet.Controls.Clear();
            if (SheetDisplayRequested != null) SheetDisplayRequested();
        }

        private void LaunchTeamCityManage()
        {
            _sheet.Controls.Clear();
            if (SheetDisplayRequested != null) SheetDisplayRequested();
        }

        private void LaunchSonarManage()
        {
            _sheet.Controls.Clear();
            if (SheetDisplayRequested != null) SheetDisplayRequested();
        }

        private void LaunchJenkinsManage()
        {
            _sheet.Controls.Clear();
            if (SheetDisplayRequested != null) SheetDisplayRequested();
        }
        #endregion

        #region Event
        private void _timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();
            _tsm.RefreshData(this);
            _timer.Start();
        }
        private void _sheet_Resize(object sender, EventArgs e)
        {
            Resize();
        }
        #endregion
    }
}