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
        private PanelCustom _viewSyncanyManage;
        private PanelCustom _viewSyncanyCreate;
        private GitHubIssue _viewGithubIssue;

        private SyncanyAdapter _infraSyncany;
        #endregion

        #region Properties
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
                case "Syncany_Manage":
                    LaunchSyncanyManage();
                    break;
                case "Syncany_Create":
                    LaunchSyncanyCreate();
                    break;
                case "Syncany_Folder":
                    break;
                case "Syncany_Load":
                    LaunchSyncanyLoad();
                    break;
                case "Syncany_Save":
                    LaunchSyncanySave();
                    break;
                case "Docker_Manage":
                    LaunchDockerManage();
                    break;
                case "Docker_Init":
                    LaunchDockerInit();
                    //LaunchDockerStatus();
                    break;
                case "Docker_Start":
                    LaunchDockerStart();
                    //LaunchDockerStop();
                    break;
                case "Github_Manage":
                    LaunchGithubManage();
                    break;
                case "Github_Create issue":
                    LaunchGithubIssue();
                    break;
                case "Github_User detail":
                    break;
                case "Jenkins_Manage":
                    LaunchJenkinsManage();
                    break;
                case "Sonar_Manage":
                    LaunchSonarManage();
                    break;
                case "Jira_Manage":
                    LaunchJiraManage();
                    break;
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

            _docker = new Boot2Docker();
            _viewDocker = new ViewDocker();
            _viewDocker.Name = "CurrentView";
            
            _infraSyncany = new SyncanyAdapter();
            _viewSyncanyManage = new PanelCustom(new CloudView(_infraSyncany, _workingDirectory));
            _viewSyncanyManage.Name = "CurrentView";
            _viewSyncanyCreate = new PanelCustom(new CloudCreate(_infraSyncany, _workingDirectory));
            _viewSyncanyCreate.Name = "CurrentView";

            _viewGithubIssue = new GitHubIssue();
            _viewGithubIssue.User = Properties.Settings.Default.User;
            _viewGithubIssue.Password = Properties.Settings.Default.Password;
            _viewGithubIssue.Repositories = new List<string>() { "Booking", "Financial", "People", "Infra" };

            BuildToolBar();
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

            if (_viewSyncanyManage == null) _viewSyncanyManage = new PanelCustom(new CloudView(_infraSyncany, _workingDirectory));

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

            if (_viewSyncanyCreate == null) _viewSyncanyCreate = new PanelCustom(new CloudCreate(_infraSyncany, _workingDirectory));

            _viewSyncanyCreate.Top = TOP_OFFSET;
            _viewSyncanyCreate.RefreshData();
            _viewSyncanyCreate.Left = (_sheet.Width / 2) - (_viewSyncanyCreate.Width / 2);
            _viewSyncanyCreate.ChangeLanguage();
            _sheet.Controls.Add(_viewSyncanyCreate);
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
        private void LaunchGithubManage()
        {
            _sheet.Controls.Clear();
            if (SheetDisplayRequested != null) SheetDisplayRequested();
        }

        private void LaunchGithubIssue()
        {
            _sheet.Controls.Clear();

            if (_viewGithubIssue == null)
            {
                _viewGithubIssue = new GitHubIssue();
                _viewGithubIssue.User = Properties.Settings.Default.User;
                _viewGithubIssue.Password = Properties.Settings.Default.Password;
                _viewGithubIssue.Repositories = new List<string>() { "Booking", "Financial", "People", "Infra" };
            }

            _viewGithubIssue.Top = TOP_OFFSET;
            _viewGithubIssue.Left = (_sheet.Width / 2) - (_viewGithubIssue.Width / 2);
            //_viewGithubIssue.ChangeLanguage();
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
        private void _sheet_Resize(object sender, EventArgs e)
        {
            Resize();
        }
        #endregion
    }
}