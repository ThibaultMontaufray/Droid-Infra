using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools.Utilities;
using Droid.Infra.Modules.YouTrack.Controler;

namespace Droid.Infra.UI
{
    public delegate void ViewInfraSettingEventHandler(object o);
    public partial class ViewInfraAdapter : UserControlCustom
    {
        #region Attributes
        public event ViewInfraSettingEventHandler OnComponentCancel;
        public event ViewInfraSettingEventHandler OnComponentSave;

        private InterfaceInfra _intInfra;
        private InfraAdapter _currentAdapter;
        #endregion

        #region Properties
        public InfraAdapter CurrentAdapter
        {
            get { return _currentAdapter; }
            set { _currentAdapter = value; }
        }
        public InterfaceInfra IntInfra
        {
            get { return _intInfra; }
            set { _intInfra = value; }
        }
        #endregion

        #region Constructor
        public ViewInfraAdapter(InterfaceInfra intInfra)
        {
            _intInfra = intInfra;
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public override void RefreshData()
        {
            if (_currentAdapter != null)
            {
                textBoxDomain.Text = _currentAdapter.Domain;
                textBoxLogin.Text =_currentAdapter.Login;
                textBoxPassword.Text = _currentAdapter.Password;
                textBoxToken.Text = _currentAdapter.Token;
                textBoxName.Text = _currentAdapter.Name;
                textBoxIp.Text = _currentAdapter.Ip;
                textBoxPort.Text = _currentAdapter.Port;
                comboBoxEnv.Text =_currentAdapter.Env.ToString();
                comboBoxInfra.Text = _currentAdapter.Techno.ToString();
            }
        }
        #endregion

        #region Methods private
        private void Init()
        {
            pictureBoxTechno.BackgroundImageLayout = ImageLayout.Zoom;
            InitEnv();
            InitTechno();
        }
        private void InitEnv()
        {
            comboBoxEnv.Items.Clear();
            comboBoxEnv.Items.AddRange(Enum.GetValues(typeof(InfraAdapter.ENV)).Cast<object>().ToArray());
            comboBoxEnv.SelectedIndex = 0;
        }
        private void InitTechno()
        {
            comboBoxInfra.Items.Clear();
            comboBoxInfra.Items.AddRange(Enum.GetValues(typeof(InfraAdapter.TECHNO)).Cast<object>().ToArray());
            comboBoxInfra.SelectedIndex = 0;
        }
        private void SetIconTechno()
        {
            switch (comboBoxInfra.SelectedItem.ToString())
            {
                case "BITBUCKET":
                    pictureBoxTechno.BackgroundImage = Properties.Resources.bitbucket;
                    break;
                case "DOCKER":
                    pictureBoxTechno.BackgroundImage = Properties.Resources.docker;
                    break;
                case "GITHUB":
                    pictureBoxTechno.BackgroundImage = Properties.Resources.github;
                    break;
                case "JENKINS":
                    pictureBoxTechno.BackgroundImage = Properties.Resources.jenkins;
                    break;
                case "JIRA":
                    pictureBoxTechno.BackgroundImage = Properties.Resources.jira;
                    break;
                case "MYSQL":
                    pictureBoxTechno.BackgroundImage = Properties.Resources.mysql2;
                    break;
                case "OPENVPN":
                    pictureBoxTechno.BackgroundImage = Properties.Resources.VPN;
                    break;
                case "POSTGRE":
                    pictureBoxTechno.BackgroundImage = Properties.Resources.postgresql;
                    break;
                case "SERVER":
                    pictureBoxTechno.BackgroundImage = Properties.Resources.Serveur;
                    break;
                case "SONARQUBE":
                    pictureBoxTechno.BackgroundImage = Properties.Resources.sonar;
                    break;
                case "TEAMCITY":
                    pictureBoxTechno.BackgroundImage = Properties.Resources.teamcity;
                    break;
                case "YOUTRACK":
                    pictureBoxTechno.BackgroundImage = Properties.Resources.youtrack;
                    break;
                default:
                    pictureBoxTechno.BackgroundImage = Properties.Resources.unknown;
                    break;
            }
        }
        private void Save()
        {
            switch (comboBoxInfra.SelectedItem.ToString())
            {
                case "BITBUCKET":
                    _currentAdapter = new BitbucketAdapter(_intInfra);
                    break;
                case "DOCKER":
                    _currentAdapter = new DockerAdapter(_intInfra);
                    break;
                case "GITHUB":
                    _currentAdapter = new GitHubAdapter(_intInfra);
                    break;
                case "JENKINS":
                    _currentAdapter = new JenkinsAdapter(_intInfra);
                    break;
                case "JIRA":
                    _currentAdapter = new JiraAdapter(_intInfra);
                    break;
                case "MYSQL":
                    _currentAdapter = new MysqlAdapter(_intInfra);
                    break;
                case "OPENVPN":
                    _currentAdapter = new OpenVpnAdapterUI(_intInfra);
                    break;
                case "POSTGRE":
                    _currentAdapter = new PostGreAdapter(_intInfra);
                    break;
                case "SERVER":
                    _currentAdapter = new ComputerAdapter(_intInfra);
                    break;
                case "SONARQUBE":
                    _currentAdapter = new SonarAdapter(_intInfra);
                    break;
                case "TEAMCITY":
                    _currentAdapter = new TeamCityAdapter(_intInfra);
                    break;
                case "YOUTRACK":
                    _currentAdapter = new YoutrackAdapter(_intInfra);
                    break;
                default:
                    //_currentAdapter = new InfraAdapter();
                    break;
            }
            _currentAdapter.Domain = textBoxDomain.Text;
            _currentAdapter.Login = textBoxLogin.Text;
            _currentAdapter.Password = textBoxPassword.Text;
            _currentAdapter.Token = textBoxToken.Text;
            _currentAdapter.Name = textBoxName.Text;
            _currentAdapter.Ip = textBoxIp.Text;
            _currentAdapter.Port = textBoxPort.Text;
            _currentAdapter.Env = (InfraAdapter.ENV)Enum.Parse(typeof(InfraAdapter.ENV), comboBoxEnv.Text);
            _currentAdapter.Techno = (InfraAdapter.TECHNO)Enum.Parse(typeof(InfraAdapter.TECHNO), comboBoxInfra.Text);
            OnComponentSave?.Invoke(_currentAdapter);
        }
        #endregion

        #region Event
        private void comboBoxInfra_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetIconTechno();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            OnComponentCancel?.Invoke(null);
        }
        #endregion
    }
}
