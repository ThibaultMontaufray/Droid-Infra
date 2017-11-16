using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Tools4Libraries;

namespace Droid_Infra
{
    [Serializable]
    [XmlRoot("infra")]
    public class Interface_infra : GPInterface
    {
        #region Attribute
        public event InterfaceEventHandler SheetDisplayRequested;

        public readonly int TOP_OFFSET = 150;
        public const string CONFIGFILE = "infra.config";

        private Boot2Docker _docker;
        private ToolStripMenuInfra _tsm;
        private string _workingDirectory;

        private ViewInfraAdd _viewInfraAdd;

        private ViewComputer _viewComputer;
        private ViewWelcome _viewWelcome;
        private ViewDocker _viewDocker;

        private PanelCustom _viewSyncanyRepositories;
        private PanelCustom _viewSyncanyCreate;
        private PanelCustom _viewSyncanyManage;

        private GitHubAdapter _githubAdapter;
        private PanelCustom _viewGithubIssue;
        private PanelCustom _viewGithubUserDetail;
        private PanelCustom _viewGithubManage;

        private BitbucketAdapter _bitbucketAdapter;
        private PanelCustom _viewBitbucket;

        private SyncanyAdapter _infraSyncany;
        private Timer _timer;
        private InfraAdapteur _currentInfraComponent;
        private InfraFarm _infraFarm;

        private VPNAdapter _vpnAdapter;
        private ViewVPNGlobalStatus _viewVPNGlobalStatus;
        private ViewVPNAuthentication _viewVPNAuthentication;
        private ViewVPNPasswd _viewVPNPassword;
        private ViewVPNSelectPKCS11Key _viewVPNSelectKey;
        private ViewVPNSettings _viewVPNSettings;
        private ViewVPNStatus _viewVPNStatus;
        #endregion

        #region Properties
        public InfraFarm InfraFarm
        {
            get { return _infraFarm; }
            set { _infraFarm = value; }
        }
        public InfraAdapteur CurrentInfraComponent
        {
            get { return _currentInfraComponent; }
            set { _currentInfraComponent = value; }
        }
        public GitHubAdapter GitHubAdapter
        {
            get { return _githubAdapter; }
            set { _githubAdapter = value; }
        }
        public BitbucketAdapter BitbucketAdapter
        {
            get { return _bitbucketAdapter; }
            set { _bitbucketAdapter = value; }
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
        public new Panel Sheet
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
        public Interface_infra()
        {
            _workingDirectory = Tools4Libraries.Params.ConfigFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Servodroid\";
            Init();
        }
        public Interface_infra(string workingDirectory)
        {
            _workingDirectory = string.IsNullOrEmpty(workingDirectory) ? Tools4Libraries.Params.ConfigFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Servodroid\" : workingDirectory;
            Init();
        }
        #endregion

        #region Methods public
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
        public override void GoAction(string action)
        {
            switch (action)
            {
                // INFRA
                case "Infra_Home":
                    LaunchInfraHome();
                    break;
                case "Infra_Open":
                    LaunchInfraOpen();
                    break;
                case "Infra_Save":
                    LaunchInfraSave();
                    break;
                case "Infra_Add":
                    LaunchInfraAdd();
                    break;
                // COMPUTER
                case "Computer_Manage":
                    LaunchComputerManage();
                    break;
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
                // BITBUCKET
                case "Bitbucket_Manage":
                    LaunchBitbucketManage();
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
                // VPN
                case "VPN_Global status":
                    LaunchVPNGlobalStatus();
                    break;
                case "VPN_Authentication":
                    LaunchVPNAuthentication();
                    break;
                case "VPN_Password":
                    LaunchVPNPassword();
                    break;
                case "VPN_Select key":
                    LaunchVPNSelectKey();
                    break;
                case "VPN_Settings":
                    LaunchVPNSettings();
                    break;
                case "VPN_Status":
                    LaunchVPNStatus();
                    break;
            }
        }
        #endregion

        #region Methods private
        private void Init()
        {
            _infraFarm = new InfraFarm();
            LoadConfig(null);

            _sheet = new Panel();
            _sheet.Name = "SheetInfra";
            _sheet.BackgroundImage = Properties.Resources.ShieldTileBg;
            _sheet.BackgroundImageLayout = ImageLayout.Tile;
            _sheet.Dock = DockStyle.Fill;
            _sheet.Resize += _sheet_Resize;

            _viewWelcome = new ViewWelcome(this);
            _viewWelcome.Name = "CurrentView";
            _viewWelcome.Top = TOP_OFFSET;
            _viewWelcome.RefreshData();
            _viewWelcome.Left = (_sheet.Width / 2) - (_viewWelcome.Width / 2);
            _viewWelcome.ChangeLanguage();
            _sheet.Controls.Add(_viewWelcome);
            if (SheetDisplayRequested != null) SheetDisplayRequested(null);
            
            //InitSyncany();
            //InitGithub();
            //InitDocker();

            BuildToolBar();

            _timer = new Timer();
            _timer.Interval = 20000;
            _timer.Tick += _timer_Tick;
            //_timer.Start();

            LaunchWelcomeView();
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
        private void InitBitbucket()
        {
            _bitbucketAdapter = new BitbucketAdapter();

            _viewBitbucket = new PanelCustom(new ViewBitbucket(_bitbucketAdapter));
            _viewBitbucket.Name = "CurrentView";
        }
        private void InitDocker()
        {
            _docker = new Boot2Docker();
            _viewDocker = new ViewDocker();
            _viewDocker.Name = "CurrentView";
        }
        private void InitVPN()
        {
            _vpnAdapter = new VPNAdapter();

            _viewVPNGlobalStatus = new ViewVPNGlobalStatus(new string[0]);
            _viewVPNAuthentication = new ViewVPNAuthentication();
            _viewVPNPassword = new ViewVPNPasswd();
            _viewVPNSelectKey = new ViewVPNSelectPKCS11Key();
            _viewVPNSettings = new ViewVPNSettings();
            _viewVPNStatus = new ViewVPNStatus(null);
        }

        private void LaunchWelcomeView()
        {
            _sheet.Controls.Clear();

            if (_viewWelcome == null) { _viewWelcome = new ViewWelcome(this); }

            _viewWelcome.Top = TOP_OFFSET;
            _viewWelcome.RefreshData();
            _viewWelcome.Left = (_sheet.Width / 2) - (_viewWelcome.Width / 2);
            _viewWelcome.ChangeLanguage();
            _viewWelcome.Name = "CurrentView";
            _sheet.Controls.Add(_viewWelcome);
            if (SheetDisplayRequested != null) SheetDisplayRequested(null);
        }
        private void LaunchInfraHome()
        {
            LaunchWelcomeView();
        }
        private void LaunchInfraOpen()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = _workingDirectory;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LoadConfig(ofd.FileName);
            }
            LaunchWelcomeView();
        }
        private void LaunchInfraSave()
        {
            //XmlSerializer ser = new XmlSerializer(typeof(List<InfraAdapteur>));
            //using (FileStream fs = new FileStream(Path.Combine(_workingDirectory, CONFIGFILE), FileMode.Create))
            //{
            //    ser.Serialize(fs, _infraComponents);
            //}

            //FileStream fs = new FileStream(Path.Combine(_workingDirectory, CONFIGFILE), FileMode.OpenOrCreate);
            //System.Xml.Serialization.XmlSerializer s = new System.Xml.Serialization.XmlSerializer(typeof(Interface_infra));
            //s.Serialize(fs, this);

            using (FileStream fs = new FileStream(Path.Combine(_workingDirectory, CONFIGFILE), FileMode.OpenOrCreate))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(InfraFarm));
                serializer.Serialize(fs, _infraFarm);
            }
        }
        private void LaunchInfraAdd()
        {
            _sheet.Controls.Clear();

            if (_viewInfraAdd == null) { _viewInfraAdd = new ViewInfraAdd(this); }

            _viewInfraAdd.Top = TOP_OFFSET;
            _viewInfraAdd.RefreshData();
            _viewInfraAdd.Left = (_sheet.Width / 2) - (_viewInfraAdd.Width / 2);
            _viewInfraAdd.ChangeLanguage();
            _viewInfraAdd.Name = "CurrentView";
            _sheet.Controls.Add(_viewInfraAdd);
            SheetDisplayRequested?.Invoke(null);
        }
        private void LaunchComputerManage()
        {
            _sheet.Controls.Clear();

            if (_viewComputer == null) _viewComputer = new ViewComputer();

            _viewComputer.Top = TOP_OFFSET;
            _viewComputer.RefreshData();
            _viewComputer.Left = (_sheet.Width / 2) - (_viewComputer.Width / 2);
            _viewComputer.ChangeLanguage();
            _viewComputer.Name = "CurrentView";
            _sheet.Controls.Add(_viewComputer);
            SheetDisplayRequested?.Invoke(null);
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
            _viewDocker.Name = "CurrentView";
            _sheet.Controls.Add(_viewDocker);
            SheetDisplayRequested?.Invoke(null);
        }
        private void LaunchSyncanyManage()
        {
            _sheet.Controls.Clear();

            if (_viewSyncanyManage == null) { InitSyncany(); }

            _viewSyncanyManage.Top = TOP_OFFSET;
            _viewSyncanyManage.RefreshData();
            _viewSyncanyManage.Left = (_sheet.Width / 2) - (_viewSyncanyManage.Width / 2);
            _viewSyncanyManage.ChangeLanguage();
            _viewSyncanyManage.Name = "CurrentView";
            _sheet.Controls.Add(_viewSyncanyManage);
            SheetDisplayRequested?.Invoke(null);
        }
        private void LaunchSyncanyCreate()
        {
            _sheet.Controls.Clear();

            if (_viewSyncanyCreate == null) { InitSyncany(); }

            _viewSyncanyCreate.Top = TOP_OFFSET;
            _viewSyncanyCreate.RefreshData();
            _viewSyncanyCreate.Left = (_sheet.Width / 2) - (_viewSyncanyCreate.Width / 2);
            _viewSyncanyCreate.ChangeLanguage();
            _viewSyncanyCreate.Name = "CurrentView";
            _sheet.Controls.Add(_viewSyncanyCreate);
            SheetDisplayRequested?.Invoke(null);
        }
        private void LaunchSyncanyRepositories()
        {
            _sheet.Controls.Clear();

            if (_viewSyncanyRepositories == null) _viewSyncanyRepositories = new PanelCustom(new CloudRepositories(_infraSyncany, _workingDirectory));

            _viewSyncanyRepositories.Top = TOP_OFFSET;
            _viewSyncanyRepositories.RefreshData();
            _viewSyncanyRepositories.Left = (_sheet.Width / 2) - (_viewSyncanyRepositories.Width / 2);
            _viewSyncanyRepositories.ChangeLanguage();
            _viewSyncanyRepositories.Name = "CurrentView";
            _sheet.Controls.Add(_viewSyncanyRepositories);
            SheetDisplayRequested?.Invoke(null);
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
        private void LaunchBitbucketManage()
        {
            _sheet.Controls.Clear();

            if (_viewBitbucket == null) { InitBitbucket(); }

            _viewBitbucket.Top = TOP_OFFSET;
            _viewBitbucket.RefreshData();
            _viewBitbucket.Left = (_sheet.Width / 2) - (_viewBitbucket.Width / 2);
            _viewBitbucket.ChangeLanguage();
            _viewBitbucket.Name = "CurrentView";
            _sheet.Controls.Add(_viewBitbucket);
            SheetDisplayRequested?.Invoke(null);
        }
        private void LaunchGithubManage()
        {
            _sheet.Controls.Clear();

            if (_viewGithubManage == null) { InitGithub(); }

            _viewGithubManage.Top = TOP_OFFSET;
            _viewGithubManage.RefreshData();
            _viewGithubManage.Left = (_sheet.Width / 2) - (_viewGithubManage.Width / 2);
            _viewGithubManage.ChangeLanguage();
            _viewGithubManage.Name = "CurrentView";
            _sheet.Controls.Add(_viewGithubManage);
            SheetDisplayRequested?.Invoke(null);
        }
        private void LaunchGitHubUserDetail()
        {
            _sheet.Controls.Clear();
            
            if (_viewGithubUserDetail == null) { InitGithub(); }

            _viewGithubUserDetail.Top = TOP_OFFSET;
            _viewGithubUserDetail.RefreshData();
            _viewGithubUserDetail.Left = (_sheet.Width / 2) - (_viewGithubUserDetail.Width / 2);
            _viewGithubUserDetail.ChangeLanguage();
            _viewGithubUserDetail.Name = "CurrentView";
            _sheet.Controls.Add(_viewGithubUserDetail);
            SheetDisplayRequested?.Invoke(null);
        }
        private void LaunchGithubIssue()
        {
            _sheet.Controls.Clear();

            if (_viewGithubIssue == null) { InitGithub(); }

            _viewGithubIssue.Top = TOP_OFFSET;
            _viewGithubIssue.RefreshData();
            _viewGithubIssue.Left = (_sheet.Width / 2) - (_viewGithubIssue.Width / 2);
            _viewGithubIssue.ChangeLanguage();
            _viewGithubIssue.Name = "CurrentView";
            _sheet.Controls.Add(_viewGithubIssue);
            SheetDisplayRequested?.Invoke(null);
        }
        private void LaunchJiraManage()
        {
            _sheet.Controls.Clear();
            SheetDisplayRequested?.Invoke(null);
        }
        private void LaunchTeamCityManage()
        {
            _sheet.Controls.Clear();
            SheetDisplayRequested?.Invoke(null);
        }
        private void LaunchSonarManage()
        {
            _sheet.Controls.Clear();
            SheetDisplayRequested?.Invoke(null);
        }
        private void LaunchJenkinsManage()
        {
            _sheet.Controls.Clear();
            SheetDisplayRequested?.Invoke(null);
        }
        private void LaunchVPNGlobalStatus()
        {
            _sheet.Controls.Clear();

            if (_viewVPNGlobalStatus == null) { InitVPN(); }

            _viewVPNGlobalStatus.Top = TOP_OFFSET;
            _viewVPNGlobalStatus.RefreshData();
            _viewVPNGlobalStatus.Left = (_sheet.Width / 2) - (_viewVPNGlobalStatus.Width / 2);
            _viewVPNGlobalStatus.ChangeLanguage();
            _viewVPNGlobalStatus.Name = "CurrentView";
            _sheet.Controls.Add(_viewVPNGlobalStatus);
            SheetDisplayRequested?.Invoke(null);
        }
        private void LaunchVPNAuthentication()
        {
            _sheet.Controls.Clear();

            if (_viewVPNAuthentication== null) { InitVPN(); }

            _viewVPNAuthentication.Top = TOP_OFFSET;
            _viewVPNAuthentication.RefreshData();
            _viewVPNAuthentication.Left = (_sheet.Width / 2) - (_viewVPNAuthentication.Width / 2);
            _viewVPNAuthentication.ChangeLanguage();
            _viewVPNAuthentication.Name = "CurrentView";
            _sheet.Controls.Add(_viewVPNAuthentication);
            SheetDisplayRequested?.Invoke(null);
        }
        private void LaunchVPNPassword()
        {
            _sheet.Controls.Clear();

            if (_viewVPNPassword == null) { InitVPN(); }

            _viewVPNPassword.Top = TOP_OFFSET;
            _viewVPNPassword.RefreshData();
            _viewVPNPassword.Left = (_sheet.Width / 2) - (_viewVPNPassword.Width / 2);
            _viewVPNPassword.ChangeLanguage();
            _viewVPNPassword.Name = "CurrentView";
            _sheet.Controls.Add(_viewVPNPassword);
            SheetDisplayRequested?.Invoke(null);
        }
        private void LaunchVPNSelectKey()
        {
            _sheet.Controls.Clear();

            if (_viewVPNSelectKey == null) { InitVPN(); }

            _viewVPNSelectKey.Top = TOP_OFFSET;
            _viewVPNSelectKey.RefreshData();
            _viewVPNSelectKey.Left = (_sheet.Width / 2) - (_viewVPNSelectKey.Width / 2);
            _viewVPNSelectKey.ChangeLanguage();
            _viewVPNSelectKey.Name = "CurrentView";
            _sheet.Controls.Add(_viewVPNSelectKey);
            SheetDisplayRequested?.Invoke(null);
        }
        private void LaunchVPNSettings()
        {
            _sheet.Controls.Clear();

            if (_viewVPNSettings == null) { InitVPN(); }

            _viewVPNSettings.Top = TOP_OFFSET;
            _viewVPNSettings.RefreshData();
            _viewVPNSettings.Left = (_sheet.Width / 2) - (_viewVPNSettings.Width / 2);
            _viewVPNSettings.ChangeLanguage();
            _viewVPNSettings.Name = "CurrentView";
            _sheet.Controls.Add(_viewVPNSettings);
            SheetDisplayRequested?.Invoke(null);
        }
        private void LaunchVPNStatus()
        {
            _sheet.Controls.Clear();

            if (_viewVPNStatus == null) { InitVPN(); }

            _viewVPNStatus.Top = TOP_OFFSET;
            _viewVPNStatus.RefreshData();
            _viewVPNStatus.Left = (_sheet.Width / 2) - (_viewVPNStatus.Width / 2);
            _viewVPNStatus.ChangeLanguage();
            _viewVPNStatus.Name = "CurrentView";
            _sheet.Controls.Add(_viewVPNStatus);
            SheetDisplayRequested?.Invoke(null);
        }

        private void LoadConfig(string filePath)
        {
            if (string.IsNullOrEmpty(filePath)) { filePath = Path.Combine(_workingDirectory, CONFIGFILE); }
            _infraFarm.Clear();

            XmlSerializer ser = new XmlSerializer(typeof(InfraFarm));
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                _infraFarm.Clear();
                _infraFarm = ser.Deserialize(fs) as InfraFarm;
            }
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