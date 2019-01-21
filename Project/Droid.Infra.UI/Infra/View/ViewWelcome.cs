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
using Droid.Maths;
using System.IO;

namespace Droid.Infra.UI
{
    public partial class ViewWelcome : UserControlCustom
    {
        #region Attribute
        private const int OFFSETX = 50;
        private const int OFFSETY = 50;

        private InterfaceInfra _intInfra;
        private bool _linkRefreshNeeded = false;
        private Timer _timer;
        private bool _initialScanDone = false;

        bool _openvpn = false;
        bool _docker = false;
        bool _postgresql = false;
        bool _bitbucket = false;
        bool _sonarqube = false;
        bool _syncany = false;
        #endregion

        #region Properties
        public InterfaceInfra InterfaceInfra
        {
            get { return _intInfra; }
            set { _intInfra = value; }
        }
        #endregion

        #region Constructor
        public ViewWelcome()
        {
            this.Paint += ViewWelcome_Paint;

            InitializeComponent();
            Init();
        }
        public ViewWelcome(InterfaceInfra intInfra)
        {
            this.Paint += ViewWelcome_Paint;

            _intInfra = intInfra;
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public override void RefreshData()
        {
            Task.Run(() => LoadComponents());
        }
        #endregion

        #region Methods private
        private void Init()
        {
            this.MinimumSize = new Size(800, 600);
            //await LoadComponents();
            this.Resize += ViewWelcome_Resize;

            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += _timer_Tick;
            //_timer.Start();
        }

        private async Task LoadComponents()
        {
            int circleSize = this.Width > this.Height ? this.Height : this.Width;
            List<Point> points;
            int index = 0;
            UserControlCustom ucc;

            try
            {
                if (!_initialScanDone)
                {
                    await Task.Run(() => ScanComputer());
                    _initialScanDone = true; 

                    circleSize = (int)(circleSize * 0.75);
                    if (_intInfra != null)
                    {
                        Control[] _ctrls = new Control[_intInfra.InfraFarm.Adapters.Count + 1];

                        points = Interface_maths.SplitCircle(this.Width / 2, this.Height / 2, circleSize / 2, _intInfra.InfraFarm.Adapters.Count - 1);
                        points.Add(new Point(this.Width / 2, this.Height / 2));
                        points.Reverse();
                        foreach (InfraAdapter component in _intInfra.InfraFarm.Adapters)
                        {
                            try
                            {
                                //ucc = await Task.Run(() => AddComponent(component, points));
                                ucc = AddComponent(component, points);
                                _ctrls[index] = ucc;
                            }
                            catch (Exception exp)
                            {
                                Console.WriteLine(exp.Message);
                            }
                            index++;
                        }
                        this.SuspendLayout();
                        this.Controls.Clear();
                        this.Controls.AddRange(_ctrls);
                        this.ResumeLayout();
                    }
                    _linkRefreshNeeded = true;
                }
                else
                {
                    foreach (Control control in this.Controls)
                    {
                        if (control is UserControlCustom)
                        {
                            foreach (Control c in control.Controls)
                            {
                                if (c is Component)
                                {
                                    ((UserControlCustom)c).RefreshData();
                                }
                            }
                        }
                    }
                }
                LoadLinks();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
        private void ScanComputer()
        {
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)))
            { 
                foreach (string folder in Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)))
                {
                    ResolvePresentInfra(folder);
                }
            }
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Programs)))
            {
                foreach (string folder in Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Programs)))
                {
                    ResolvePresentInfra(folder);
                }
            }
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)))
            {
                foreach (string folder in Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)))
                {
                    ResolvePresentInfra(folder);
                }
            }
            //BuildAdapters();
        }
        private void ResolvePresentInfra(string folder)
        {
            if (folder.ToLower().Contains("openvpn")) { _openvpn = true; }
            if (folder.ToLower().Contains("docker")) { _docker = true; }
            if (folder.ToLower().Contains("postgresql")) { _postgresql = true; }
            if (folder.ToLower().Contains("tortoisehg")) { _bitbucket = true; }
            if (folder.ToLower().Contains("sonarqube")) { _sonarqube = true; }
            if (folder.ToLower().Contains("syncany")) { _syncany = true; }
        }
        private void BuildAdapters()
        {
            //_intInfra.InfraFarm.Clear();
            if (_openvpn) { _intInfra.AddInfra("vpn"); }
            if (_docker) { _intInfra.AddInfra("docker"); }
            if (_postgresql) { _intInfra.AddInfra("postgresql"); }
            if (_bitbucket) { _intInfra.AddInfra("bitbucket"); }
            if (_sonarqube) { _intInfra.AddInfra("sonarqube"); }
            if (_syncany) { _intInfra.AddInfra("syncany"); }
        }
        private void LoadLinks()
        {
            if (_linkRefreshNeeded)
            { 
                using (Graphics g = this.CreateGraphics())
                {
                    for (int i = 0; i < _intInfra.InfraFarm.Adapters.Count; i++)
                    {
                        DrawLink(_intInfra.InfraFarm.Adapters[i].Panel, _intInfra.InfraFarm.Adapters[0].Panel, g, _intInfra.InfraFarm.Adapters[i].Online);
                        //for (int j = i+1; j < _intInfra.InfraFarm.InfraComponents.Count; j++)
                        //{
                        //if (_intInfra.InfraFarm.InfraComponents[i].Online && _intInfra.InfraFarm.InfraComponents[j].Online)
                        //if (_intInfra.InfraFarm.InfraComponents[i].Online && _intInfra.InfraFarm.InfraComponents[0].Online)
                        //{ 
                        //    DrawLink(_intInfra.InfraFarm.InfraComponents[i].Panel, _intInfra.InfraFarm.InfraComponents[0].Panel, g, true);
                        //}
                        //else
                        //{
                        //    DrawLink(_intInfra.InfraFarm.InfraComponents[i].Panel, _intInfra.InfraFarm.InfraComponents[0].Panel, g, false);
                        //}
                        //}
                    }
                }
            }
        }
        private UserControlCustom AddComponent(InfraAdapter component, List<Point> points)
        {
            UserControlCustom ucc;
            Label lblTitle;
            PictureBox pb;
            Component c;
            
            component.RefreshStatus();
            lblTitle = BuildTitle(component);
            pb = BuildPictureBox(component);
            c = BuildComponent(component);
            ucc = BuildPanel(component, lblTitle, pb, points, c);
            component.Panel = ucc;

            return ucc;
        }
        private Label BuildTitle(InfraAdapter component)
        {
            Label lblTitle = new Label();
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Top = 5;
            lblTitle.Left = 31;
            lblTitle.Text = component.Name;
            lblTitle.AutoSize = false;
            lblTitle.Width = 80;
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            return lblTitle;
        }
        private PictureBox BuildPictureBox(InfraAdapter component)
        {
            PictureBox pb = new PictureBox();
            pb.Top = 5;
            pb.Left = 5;
            switch (component.GetType().ToString())
            {
                case "Droid.Infra.BitbucketAdapter":
                    pb.BackgroundImage = Properties.Resources.bitbucket;
                    break;
                case "Droid.Infra.ComputerAdapter":
                    pb.BackgroundImage = Properties.Resources.Serveur;
                    break;
                case "Droid.Infra.DockerAdapter":
                    pb.BackgroundImage = Properties.Resources.docker;
                    break;
                case "Droid.Infra.GitHubAdapter":
                    pb.BackgroundImage = Properties.Resources.github;
                    break;
                case "Droid.Infra.JenkinsAdapter":
                    pb.BackgroundImage = Properties.Resources.jenkins;
                    break;
                case "Droid.Infra.JiraAdapter":
                    pb.BackgroundImage = Properties.Resources.jira;
                    break;
                case "Droid.Infra.ServiceAdapter":
                    pb.BackgroundImage = Properties.Resources.Serveur;
                    break;
                case "Droid.Infra.SonarAdapter":
                    pb.BackgroundImage = Properties.Resources.sonar;
                    break;
                case "Droid.Infra.SqlAdapter":
                    pb.BackgroundImage = Properties.Resources.SQL;
                    break;
                case "Droid.Infra.SyncanyAdapter":
                    pb.BackgroundImage = Properties.Resources.syncany;
                    break;
                case "Droid.Infra.TeamCityAdapter":
                    pb.BackgroundImage = Properties.Resources.teamcity;
                    break;
                case "Droid.Infra.PostGreAdapter":
                    pb.BackgroundImage = Properties.Resources.postgresql;
                    break;
                default:
                    pb.BackgroundImage = Properties.Resources.unknown;
                    break;
            }
            pb.BackgroundImageLayout = ImageLayout.Zoom;
            pb.Width = 22;
            pb.Height = 22;

            return pb;
        }
        private Component BuildComponent(InfraAdapter component)
        {
            Component c;
            switch (component.GetType().ToString())
            {
                case "Droid.Infra.BitbucketAdapter":
                    c = new ComponentBitbucket(component as BitbucketAdapter);
                    break;
                case "Droid.Infra.ComputerAdapter":
                    c = new ComponentComputer((ComputerAdapter) _intInfra.InfraFarm.GetAdapter(AdapterType.ComputerAdapter));
                    break;
                case "Droid.Infra.DockerAdapter":
                    c = new ComponentDocker((DockerAdapter)_intInfra.InfraFarm.GetAdapter(AdapterType.DockerAdapter));
                    break;
                case "Droid.Infra.GitHubAdapter":
                    c = new ComponentGithub();
                    break;
                case "Droid.Infra.JenkinsAdapter":
                    c = new ComponentJenkins();
                    break;
                case "Droid.Infra.JiraAdapter":
                    c = new ComponentJira();
                    break;
                case "Droid.Infra.ServiceAdapter":
                    c = new Component();
                    break;
                case "Droid.Infra.SonarAdapter":
                    c = new ComponentSonar();
                    break;
                case "Droid.Infra.SqlAdapter":
                    c = new ComponentSql();
                    break;
                case "Droid.Infra.SyncanyAdapter":
                    c = new ComponentSyncany();
                    break;
                case "Droid.Infra.PostGreAdapter":
                    c = new ComponentPostGre();
                    break;
                case "Droid.Infra.TeamCityAdapter":
                    c = new ComponentTeamCity();
                    break;
                case "Droid.Infra.OpenVpnAdapter":
                    c = new ComponentVPN((OpenVpnAdapterUI)_intInfra.InfraFarm.GetAdapter(AdapterType.OpenVpnAdapter));
                    break;
                default:
                    c = new Component();
                    break;
            }
            c.Name = component.GetType().ToString();
            c.Top = 31;
            c.Left = 1;
            return c;
        }
        private UserControlCustom BuildPanel(InfraAdapter component, Label lblTitle, PictureBox pb, List<Point> points, Component cpn)
        {
            UserControlCustom p = new UserControlCustom();
            p.Width = 100;
            p.Height = 100;
            p.Top = points[_intInfra.InfraFarm.Adapters.IndexOf(component)].Y - OFFSETY;
            p.Left = points[_intInfra.InfraFarm.Adapters.IndexOf(component)].X - OFFSETX;
            p.BackgroundImage = component.Online ? Properties.Resources.component : Properties.Resources.componentOffline;
            p.Controls.Add(lblTitle);
            p.Controls.Add(pb);
            p.Controls.Add(cpn);
            p.Name = component.Name;

            return p;
        }
        private void DrawLink(Control p1, Control p2, Graphics g, bool connected)
        {
            if (p1 == null || p2 == null) { return; }
            Color col = connected ? Color.GreenYellow : Color.Gray;
            int offset = 5;
            int bezier = 50;
            int x1 = 0, x2 = 0, y1 = 0, y2 = 0; // point coord
            int x3 = 0, x4 = 0, y3 = 0, y4 = 0; // bezier coord

            // Panel 1
            if (p2.Top - p1.Top > offset) { y1 = p1.Top + p1.Height; y3 = y1 + bezier; }
            else if (p1.Top - p2.Top > offset) { y1 = p1.Top + p1.Height/2; y3 = y1 - bezier; }
            else { y1 = p1.Top + p1.Height / 2; y3 = y1; }

            if (p2.Left - p1.Left > offset) { x1 = p1.Left + p1.Width; x3 = x1 + bezier; }
            else if (p1.Left - p2.Left > offset) { x1 = p1.Left + p1.Width/2; x3 = x1 - bezier; }
            else { x1 = p1.Left + p1.Width / 2; x3 = x1; }

            // Panel 2
            if (p1.Top - p2.Top > offset) { y2 = p2.Top + p2.Height; y4 = y2 + bezier; }
            else if (p2.Top - p1.Top > offset) { y2 = p2.Top + p2.Height/2; y4 = y2 - bezier; }
            else { y2 = p2.Top + p2.Height / 2; y4 = y2; }

            if (p1.Left - p2.Left > offset) { x2 = p2.Left + p2.Width; x4 = x2 + bezier; }
            else if (p2.Left - p1.Left > offset) { x2 = p2.Left + p2.Width/2; x4 = x2 - bezier; }
            else { x2 = p2.Left + p2.Width / 2; x4 = x2; }

            // bezier adjust
            if ((p1.Left - p2.Left > offset) && (p1.Top - p2.Top > offset)) { y3 = y1; x4 = x2; }
            if ((p2.Left - p1.Left > offset) && (p2.Top - p1.Top > offset)) { y4 = y2; x3 = x1; }
            if ((p1.Left - p2.Left > offset) && (p2.Top - p1.Top > offset)) { y3 = y1; y4 = y2; }
            if ((p2.Left - p1.Left > offset) && (p1.Top - p2.Top > offset)) { x3 = x1; x4 = x2; }

            // dirty fix :
            x1 = p1.Left + p1.Width / 2;
            x2 = p2.Left + p2.Width / 2;
            y1 = p1.Top + p1.Height / 2;
            y2 = p2.Top + p2.Height / 2;

            g.DrawBezier(new Pen(col, 2), new Point(x1, y1), new Point(x3, y3), new Point(x4, y4), new Point(x2, y2));
            //g.DrawRectangle(new Pen(Color.Yellow, 4), new Rectangle(new Point(x1, y1), new Size(2, 2)));
            //g.DrawRectangle(new Pen(Color.Green, 4), new Rectangle(new Point(x2, y2), new Size(2, 2)));
            //g.DrawRectangle(new Pen(Color.Orange, 4), new Rectangle(new Point(x3, y3), new Size(2, 2)));
            //g.DrawRectangle(new Pen(Color.Purple, 4), new Rectangle(new Point(x4, y4), new Size(2, 2)));
        }
        #endregion

        #region Event
        private void ViewWelcome_Resize(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void ViewWelcome_Paint(object sender, PaintEventArgs e)
        {
            LoadLinks();
        }
        private async void _timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();
            await LoadComponents();
            _timer.Start();
        }
        #endregion
    }
}
