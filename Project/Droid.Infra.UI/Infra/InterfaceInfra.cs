using Droid.Infra.Modules.YouTrack.Controler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Xml;
using System.Xml.Serialization;
using Tools.Utilities.UI;
using Droid.Infra;
using Droid.Infra.UI.Infra.View;

namespace Droid.Infra.UI
{
    [Serializable]
    [XmlRoot("infra")]
    public class InterfaceInfra : GPInterfaceUI
    {
        #region Attribute

        public const string CONFIGFILE = "infra.config";
        
        private InfraAdapter _currentInfraComponent;
        private InfraFarm _infraFarm;
        private new ToolStripMenuInfra _tsm;
        private string _workingDirectory;
        
        private ViewInfraOverview _viewInfraOverview;
        private ViewInfraAdapter _viewInfraAdapter;
        private ViewInfraMonitoring _viewInfraMonitor;
        private ViewInfraNew _viewInfraNew;

        private ViewComputer _viewComputer;

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
        public InfraFarm InfraFarm
        {
            get { return _infraFarm; }
            set { _infraFarm = value; }
        }
        public InfraAdapter CurrentInfraComponent
        {
            get { return _currentInfraComponent; }
            set { _currentInfraComponent = value; }
        }
        public GitHubAdapter GitHubAdapter
        {
            get { return _githubAdapter; }
            set { _githubAdapter = value; }
        }
        //public BitbucketAdapter BitbucketAdapter
        //{
        //    get { return _bitbucketAdapter; }
        //    set { _bitbucketAdapter = value; }
        //}
        public SyncanyAdapter InfraSyncany
        {
            get { return _infraSyncany; }
            set { _infraSyncany = value; }
        }
        //public PostGreAdapter PostGreAdapter
        //{
        //    get { return _postgresqlAdapter; }
        //    set { _postgresqlAdapter = value; }
        //}
        public string WorkingDirectory
        {
            get { return _workingDirectory; }
            set { _workingDirectory = value; }
        }
        //public Boot2Docker Docker
        //{
        //    get { return _docker; }
        //    set { _docker = value; }
        //}
        public ToolStripMenuInfra Tsm
        {
            get { return _tsm; }
            set { _tsm = value as ToolStripMenuInfra; }
        }

        //public ComputerAdapter AdapterComputer
        //{
        //    get { return _computerAdapter; }
        //    set { _computerAdapter = value; }
        //}
        //public DockerAdapter AdapterDocker
        //{
        //    get { return _dockerAdapter; }
        //    set { _dockerAdapter = value; }
        //}
        //public OpenVpnAdapter AdapterOpenVpn
        //{
        //    get { return _openvpnAdapter; }
        //    set { _openvpnAdapter = value; }
        //}
        //public YoutrackAdapter AdapterYoutrack
        //{
        //    get { return _youtrackAdapter; }
        //    set { _youtrackAdapter = value; }
        //}
        //public List<InfraAdapter> Adapters
        //{
        //    get { return _adapters; }
        //    set { _adapters = value; }
        //}
        //public InfraAdapter CurrentAdapter
        //{
        //    get { return _currentAdapter; }
        //    set { _currentAdapter = value; }
        //}
        #endregion

        #region Constructor
        public InterfaceInfra()
        {
            _workingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Servodroid\";
            Init();
        }
        public InterfaceInfra(string workingDirectory)
        {
            _workingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Servodroid\";
            Init();
        }
        #endregion

        #region Methods public
        public new bool Save()
        {
            try
            {
                if (File.Exists(Path.Combine(_workingDirectory, CONFIGFILE))) { File.Delete(Path.Combine(_workingDirectory, CONFIGFILE)); }
                using (FileStream fs = new FileStream(Path.Combine(_workingDirectory, CONFIGFILE), FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<InfraAdapter>));
                    serializer.Serialize(fs, _infraFarm.Adapters);
                }
                return true;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                return false;
            }
        }
        public System.Windows.Forms.RibbonTab BuildToolBar()
        {
            _tsm = new ToolStripMenuInfra();
            _tsm.ActionAppened += GlobalAction;
            _tsm.RefreshData(this);
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
            Save();
            if(_viewInfraMonitor != null) { _viewInfraMonitor.IsActive = false; }
            action = action.Replace(" ", "_");
            if (!string.IsNullOrEmpty(action))
            {
                if (action.ToLower().StartsWith("computer"))
                {
                    if (_infraFarm.GetAdapter(AdapterType.ComputerAdapter) == null) { _infraFarm.Adapters.Add(InitComputer()); }
                    ((ComputerAdapter)_infraFarm.GetAdapter(AdapterType.ComputerAdapter)).Parent = this;
                    ((ComputerAdapter)_infraFarm.GetAdapter(AdapterType.ComputerAdapter))?.GoAction(action.ToLower().Replace("computer_", string.Empty));
                    return;
                }
                if (action.ToLower().StartsWith("docker"))
                {
                    if (_infraFarm.GetAdapter(AdapterType.DockerAdapter) == null) { _infraFarm.Adapters.Add(InitDocker()); }
                    ((DockerAdapter)_infraFarm.GetAdapter(AdapterType.DockerAdapter))?.GoAction(action.ToLower().Replace("docker_", string.Empty));
                    return;
                }
                if (action.ToLower().StartsWith("bitbucket"))
                {
                    if (_infraFarm.GetAdapter(AdapterType.BitbucketAdapter) == null) { _infraFarm.Adapters.Add(InitBitbucket()); }
                    ((BitbucketAdapter)_infraFarm.GetAdapter(AdapterType.BitbucketAdapter))?.GoAction(action.ToLower().Replace("bitbucket_", string.Empty));
                    return;
                }
                if (action.ToLower().StartsWith("openvpn"))
                {
                    if (_infraFarm.GetAdapter(AdapterType.OpenVpnAdapter) == null) { _infraFarm.Adapters.Add(InitOpenVpn()); }
                    ((OpenVpnAdapter)_infraFarm.GetAdapter(AdapterType.OpenVpnAdapter))?.GoAction(action.ToLower().Replace("openvpn_", string.Empty));
                    return;
                }
                if (action.ToLower().StartsWith("youtrack"))
                {
                    if (_infraFarm.GetAdapter(AdapterType.YoutrackAdapter) == null) { _infraFarm.Adapters.Add(InitYoutrack()); }
                    ((YoutrackAdapter)_infraFarm.GetAdapter(AdapterType.YoutrackAdapter))?.GoAction(action.ToLower().Replace("youtrack_", string.Empty));
                    return;
                }
            }
            switch (action)
            {
                // INFRA
                case "Infra_Home":
                    LaunchInfraMonitor();
                    break;
                case "Infra_Open":
                    LaunchInfraOpen();
                    break;
                case "Infra_Save":
                    LaunchInfraSave();
                    break;
                case "Infra_Setting":
                    LaunchInfraSetting();
                    break;
                case "Infra_Add":
                    LaunchInfraAdd();
                    break;
                case "Infra_Edit":
                    LaunchInfraEdit();
                    break;
                case "Infra_New":
                    LaunchInfraNew();
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
                // POSGRESQL
                case "PostGreSql_Manage":
                    LaunchPostgreManage();
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
        public void AddInfra(string type, string name = null, string url = null)
        {
            if (string.IsNullOrEmpty(type)) { return; }
            InfraAdapter ia = null;

            switch (type.ToLower())
            {
                case "server":
                    ia = new ComputerAdapter(this);
                    break;
                case "sonarqube":
                    ia = new SonarAdapter(this);
                    break;
                case "sql":
                    ia = new SqlAdapter(this);
                    break;
                //case "vpn":
                //    ia = _openvpnAdapter;
                //    break;
                //case "docker":
                //    ia = _dockerAdapter;
                //    break;
                case "team city":
                    ia = new TeamCityAdapter(this);
                    break;
                case "bitbucket":
                    ia = new BitbucketAdapter(this);
                    break;
                case "postgresql":
                    ia = new PostGreAdapter(this);
                    break;
                case "syncany":
                    ia = new SyncanyAdapter(this);
                    break;
                default:
                    break;
            }

            if (ia != null)
            {
                try
                {
                    ia.Name = name != null ? name : ia.GetType().ToString().Split('.')[ia.GetType().ToString().Split('.').Length - 1].Replace("Adapter", string.Empty);
                    ia.Url = url;
                    InfraFarm.Add(ia);
                    //GoAction("Infra_Save");
                }
                catch (Exception e)
                {

                }
            }
        }
        #endregion

        #region Methods private
        private void Init()
        {
            _infraFarm = new InfraFarm();
            
            _sheet = new PanelScrollableCustom();
            _sheet.Name = "SheetInfra";
            _sheet.Dock = DockStyle.Fill;
            _sheet.Resize += _sheet_Resize;

            LoadConfig(null);
            LaunchInfraMonitor();
            
            BuildToolBar();

            _timer = new Timer();
            _timer.Interval = 70000;
            _timer.Tick += _timer_Tick;
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
        private BitbucketAdapter InitBitbucket()
        {
            return new BitbucketAdapter(this);
        }
        private DockerAdapter InitDocker()
        {
            return new DockerAdapter(this);
        }
        private OpenVpnAdapter InitOpenVpn()
        {
            return new OpenVpnAdapter(this);

            //_viewVPNGlobalStatus = new ViewVPNGlobalStatus(new string[0]);
            //_viewVPNAuthentication = new ViewVPNAuthentication();
            //_viewVPNPassword = new ViewVPNPasswd();
            //_viewVPNSelectKey = new ViewVPNSelectPKCS11Key();
            //_viewVPNSettings = new ViewVPNSettings();
            //_viewVPNStatus = new ViewVPNStatus(null);
        }
        private YoutrackAdapter InitYoutrack()
        {
            return new YoutrackAdapter(this);
        }
        private PostGreAdapter InitPostgresql()
        {
            return new PostGreAdapter();
        }
        private ComputerAdapter InitComputer()
        {
            return new ComputerAdapter(this);
        }
        private void LaunchInfraMonitor()
        {
            if (_viewInfraMonitor == null) { _viewInfraMonitor = new ViewInfraMonitoring(this); }
            if (_viewInfraMonitor != null) { _viewInfraMonitor.IsActive = true; }
            LaunchSheet(_viewInfraMonitor, true);
        }
        private void LaunchInfraOpen()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = _workingDirectory;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LoadConfig(ofd.FileName);
            }
            LaunchInfraMonitor();
        }
        private void LaunchInfraSave()
        {
            Save();
        }
        private void LaunchInfraNew()
        {
            if (_viewInfraNew == null)
            {
                _viewInfraNew = new ViewInfraNew(this);
                _viewInfraNew.CreateRequested += _viewInfraNew_CreateRequested;
            }
            LaunchSheet(_viewInfraNew);
        }
        private void LaunchInfraSetting()
        {
            if (_viewInfraOverview == null)
            {
                _viewInfraOverview = new ViewInfraOverview(this);
            }
            LaunchSheet(_viewInfraOverview);
        }
        private void LaunchInfraAdd()
        {
            if (_viewInfraAdapter == null)
            {
                _viewInfraAdapter = new ViewInfraAdapter(this);
                _viewInfraAdapter.OnComponentCancel += _viewInfraEdit_OnComponentCancel;
                _viewInfraAdapter.OnComponentSave += _viewInfraEdit_OnComponentSave;
            }
            //_viewInfraAdapter.CurrentAdapter = new InfraAdapter();
            LaunchSheet(_viewInfraAdapter);
        }
        private void LaunchInfraEdit()
        {
            if (_viewInfraAdapter == null)
            {
                _viewInfraAdapter = new ViewInfraAdapter(this);
                _viewInfraAdapter.OnComponentCancel += _viewInfraEdit_OnComponentCancel;
                _viewInfraAdapter.OnComponentSave += _viewInfraEdit_OnComponentSave;
            }
            _viewInfraAdapter.CurrentAdapter = _infraFarm.CurrentAdapter;
            LaunchSheet(_viewInfraAdapter);
        }
        private void LaunchComputerManage()
        {
            if (_viewComputer == null) _viewComputer = new ViewComputer();
            LaunchSheet(_viewComputer);
        }
        private void LaunchSyncanyManage()
        {
            if (_viewSyncanyManage == null) { InitSyncany(); }
            LaunchSheet(_viewSyncanyManage);
        }
        private void LaunchSyncanyCreate()
        {
            if (_viewSyncanyCreate == null) { InitSyncany(); }
            LaunchSheet(_viewSyncanyCreate);
        }
        private void LaunchSyncanyRepositories()
        {
            if (_viewSyncanyRepositories == null) _viewSyncanyRepositories = new PanelCustom(new CloudRepositories(_infraSyncany, _workingDirectory));
            LaunchSheet(_viewSyncanyRepositories);
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
            if (_viewGithubManage == null) { InitGithub(); }
            LaunchSheet(_viewGithubManage);
        }
        private void LaunchGitHubUserDetail()
        {
            if (_viewGithubUserDetail == null) { InitGithub(); }
            LaunchSheet(_viewGithubUserDetail);
        }
        private void LaunchGithubIssue()
        {
            if (_viewGithubIssue == null) { InitGithub(); }
            LaunchSheet(_viewGithubIssue);
        }
        private void LaunchJiraManage()
        {
            _sheet.Controls.Clear();
        }
        private void LaunchTeamCityManage()
        {
            _sheet.Controls.Clear();
        }
        private void LaunchSonarManage()
        {
            _sheet.Controls.Clear();
        }
        private void LaunchJenkinsManage()
        {
            _sheet.Controls.Clear();
        }
        private void LaunchVPNGlobalStatus()
        {
            _sheet.Controls.Clear();

            //if (_viewVPNGlobalStatus == null) { InitOpenVpn(); }

            //_viewVPNGlobalStatus.Top = TOP_OFFSET;
            //_viewVPNGlobalStatus.RefreshData();
            //_viewVPNGlobalStatus.Left = (_sheet.Width / 2) - (_viewVPNGlobalStatus.Width / 2);
            //_viewVPNGlobalStatus.ChangeLanguage();
            //_viewVPNGlobalStatus.Name = "CurrentView";
            //_sheet.Controls.Add(_viewVPNGlobalStatus);
            //SheetDisplayRequested?.Invoke(null);
        }
        private void LaunchVPNAuthentication()
        {
            _sheet.Controls.Clear();

            //if (_viewVPNAuthentication== null) { InitOpenVpn(); }

            //_viewVPNAuthentication.Top = TOP_OFFSET;
            //_viewVPNAuthentication.RefreshData();
            //_viewVPNAuthentication.Left = (_sheet.Width / 2) - (_viewVPNAuthentication.Width / 2);
            //_viewVPNAuthentication.ChangeLanguage();
            //_viewVPNAuthentication.Name = "CurrentView";
            //_sheet.Controls.Add(_viewVPNAuthentication);
            //SheetDisplayRequested?.Invoke(null);
        }
        private void LaunchVPNPassword()
        {
            _sheet.Controls.Clear();

            //if (_viewVPNPassword == null) { InitOpenVpn(); }

            //_viewVPNPassword.Top = TOP_OFFSET;
            //_viewVPNPassword.RefreshData();
            //_viewVPNPassword.Left = (_sheet.Width / 2) - (_viewVPNPassword.Width / 2);
            //_viewVPNPassword.ChangeLanguage();
            //_viewVPNPassword.Name = "CurrentView";
            //_sheet.Controls.Add(_viewVPNPassword);
            //SheetDisplayRequested?.Invoke(null);
        }
        private void LaunchVPNSelectKey()
        {
            _sheet.Controls.Clear();

            //if (_viewVPNSelectKey == null) { InitOpenVpn(); }

            //_viewVPNSelectKey.Top = TOP_OFFSET;
            //_viewVPNSelectKey.RefreshData();
            //_viewVPNSelectKey.Left = (_sheet.Width / 2) - (_viewVPNSelectKey.Width / 2);
            //_viewVPNSelectKey.ChangeLanguage();
            //_viewVPNSelectKey.Name = "CurrentView";
            //_sheet.Controls.Add(_viewVPNSelectKey);
            //SheetDisplayRequested?.Invoke(null);
        }
        private void LaunchVPNSettings()
        {
            _sheet.Controls.Clear();

            //if (_viewVPNSettings == null) { InitOpenVpn(); }

            //_viewVPNSettings.Top = TOP_OFFSET;
            //_viewVPNSettings.RefreshData();
            //_viewVPNSettings.Left = (_sheet.Width / 2) - (_viewVPNSettings.Width / 2);
            //_viewVPNSettings.ChangeLanguage();
            //_viewVPNSettings.Name = "CurrentView";
            //_sheet.Controls.Add(_viewVPNSettings);
            //SheetDisplayRequested?.Invoke(null);
        }
        private void LaunchVPNStatus()
        {
            _sheet.Controls.Clear();

            //if (_viewVPNStatus == null) { InitOpenVpn(); }

            //_viewVPNStatus.Top = TOP_OFFSET;
            //_viewVPNStatus.RefreshData();
            //_viewVPNStatus.Left = (_sheet.Width / 2) - (_viewVPNStatus.Width / 2);
            //_viewVPNStatus.ChangeLanguage();
            //_viewVPNStatus.Name = "CurrentView";
            //_sheet.Controls.Add(_viewVPNStatus);
            //SheetDisplayRequested?.Invoke(null);
        }
        private void LaunchPostgreManage()
        {
            _sheet.Controls.Clear();

            //if (_viewPostGreSql == null) { InitPostgresql(); }

            //_viewPostGreSql.Top = TOP_OFFSET;
            //_viewPostGreSql.RefreshData();
            //_viewPostGreSql.Left = (_sheet.Width / 2) - (_viewPostGreSql.Width / 2);
            //_viewPostGreSql.ChangeLanguage();
            //_viewPostGreSql.Name = "CurrentView";
            //_sheet.Controls.Add(_viewPostGreSql);
            //SheetDisplayRequested?.Invoke(null);
        }
        
        private void LoadConfig(string filePath)
        {
            try
             {
                if (string.IsNullOrEmpty(filePath)) { filePath = Path.Combine(_workingDirectory, CONFIGFILE); }
                _infraFarm.Clear();

                XmlSerializer ser = new XmlSerializer(typeof(List<InfraAdapter>));
                if (File.Exists(filePath))
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.Open))
                    {
                        _infraFarm.Adapters = ser.Deserialize(fs) as List<InfraAdapter>;
                        foreach (var item in _infraFarm.Adapters)
                        {
                            item.Sheet = this.Sheet;
                            item.Parent = this;
                        }
                    }
                }
                else
                {
                    File.Create(filePath);
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
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
        private void _viewInfraEdit_OnComponentSave(object o)
        {
            InfraAdapter ic = (InfraAdapter)o;
            if (o != null)
            {
                if (_infraFarm.Adapters.Where(c => c.Id.Equals(ic.Id)).Count() != 0)
                {
                    _infraFarm.Adapters.Remove(_infraFarm.Adapters.Where(c => c.Id.Equals(ic.Id)).FirstOrDefault());
                }
                _infraFarm.Adapters.Add(ic);
            }
            _tsm.RefreshData(this);
            LaunchInfraSetting();
        }
        private void _viewInfraEdit_OnComponentCancel(object o)
        {
            LaunchInfraSetting();
        }
        private void _viewInfraNew_CreateRequested(object o)
        {
            LoadConfig(o.ToString());
        }
        #endregion
    }
}