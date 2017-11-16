using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools4Libraries;
using Droid_Maths;

namespace Droid_Infra
{
    public partial class ViewWelcome : UserControlCustom
    {
        #region Attribute
        private const int OFFSETX = 50;
        private const int OFFSETY = 50;

        private Interface_infra _intInfra;
        private bool _linkRefreshNeeded = false;
        private Timer _timer;
        #endregion

        #region Properties
        public Interface_infra InterfaceInfra
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
        public ViewWelcome(Interface_infra intInfra)
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
            //LoadComponents();
        }
        #endregion

        #region Methods private
        private async void Init()
        {
            this.MinimumSize = new Size(800, 600);
            //await LoadComponents();
            this.Resize += ViewWelcome_Resize;

            _timer = new Timer();
            _timer.Interval = 10000;
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

        private async Task LoadComponents()
        {
            int circleSize = this.Width > this.Height ? this.Height : this.Width;
            List<Point> points;
            int index = 0;
            Panel p;

            circleSize = (int)(circleSize * 0.75);
            if (_intInfra != null)
            {
                Control[] _ctrls = new Control[_intInfra.InfraFarm.InfraComponents.Count];
                points = Interface_maths.SplitCircle(this.Width / 2, this.Height / 2, circleSize / 2, _intInfra.InfraFarm.InfraComponents.Count);
                foreach (InfraAdapteur component in _intInfra.InfraFarm.InfraComponents)
                {
                    p = await Task.Run(() => AddComponent(component, points));
                    _ctrls[index] = p;
                    index++;
                }
                this.SuspendLayout();
                this.Controls.Clear();
                this.Controls.AddRange(_ctrls);
                this.ResumeLayout();
            }

            _linkRefreshNeeded = true;
            LoadLinks();
        }
        private void LoadLinks()
        {
            if (_linkRefreshNeeded)
            { 
                using (Graphics g = this.CreateGraphics())
                {
                    for (int i = 0; i < _intInfra.InfraFarm.InfraComponents.Count-1; i++)
                    {
                        for (int j = i+1; j < _intInfra.InfraFarm.InfraComponents.Count; j++)
                        {
                            if (_intInfra.InfraFarm.InfraComponents[i].Online && _intInfra.InfraFarm.InfraComponents[j].Online)
                            { 
                                DrawLink(_intInfra.InfraFarm.InfraComponents[i].Panel, _intInfra.InfraFarm.InfraComponents[j].Panel, g, true);
                            }
                        }
                    }
                }
            }
        }
        private Panel AddComponent(InfraAdapteur component, List<Point> points)
        {
            Panel p;
            Label lblTitle;
            PictureBox pb;
            Component c;
            
            component.RefreshStatus();
            lblTitle = BuildTitle(component);
            pb = BuildPictureBox(component);
            c = BuildComponent(component);
            p = BuildPanel(component, lblTitle, pb, points, c);
            component.Panel = p;

            return p;
        }
        private Label BuildTitle(InfraAdapteur component)
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
        private PictureBox BuildPictureBox(InfraAdapteur component)
        {
            PictureBox pb = new PictureBox();
            pb.Top = 5;
            pb.Left = 5;
            switch (component.GetType().ToString())
            {
                case "Droid_Infra.BitbucketAdapter":
                    pb.BackgroundImage = Properties.Resources.bitbucket;
                    break;
                case "Droid_Infra.ComputerAdapter":
                    pb.BackgroundImage = Properties.Resources.Serveur;
                    break;
                case "Droid_Infra.DockerAdapter":
                    pb.BackgroundImage = Properties.Resources.docker;
                    break;
                case "Droid_Infra.GitHubAdapter":
                    pb.BackgroundImage = Properties.Resources.github;
                    break;
                case "Droid_Infra.JenkinsAdapter":
                    pb.BackgroundImage = Properties.Resources.jenkins;
                    break;
                case "Droid_Infra.JiraAdapter":
                    pb.BackgroundImage = Properties.Resources.jira;
                    break;
                case "Droid_Infra.ServiceAdapter":
                    pb.BackgroundImage = Properties.Resources.Serveur;
                    break;
                case "Droid_Infra.SonarAdapter":
                    pb.BackgroundImage = Properties.Resources.sonar;
                    break;
                case "Droid_Infra.SqlAdapter":
                    pb.BackgroundImage = Properties.Resources.SQL;
                    break;
                case "Droid_Infra.SyncanyAdapter":
                    pb.BackgroundImage = Properties.Resources.syncany;
                    break;
                case "Droid_Infra.TeamCityAdapter":
                    pb.BackgroundImage = Properties.Resources.teamcity;
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
        private Component BuildComponent(InfraAdapteur component)
        {
            Component c;
            switch (component.GetType().ToString())
            {
                case "Droid_Infra.BitbucketAdapter":
                    c = new ComponentBitbucket(component as BitbucketAdapter);
                    break;
                case "Droid_Infra.ComputerAdapter":
                    c = new ComponentComputer();
                    break;
                case "Droid_Infra.DockerAdapter":
                    c = new ComponentDocekr();
                    break;
                case "Droid_Infra.GitHubAdapter":
                    c = new ComponentGithub();
                    break;
                case "Droid_Infra.JenkinsAdapter":
                    c = new ComponentJenkins();
                    break;
                case "Droid_Infra.JiraAdapter":
                    c = new ComponentJira();
                    break;
                case "Droid_Infra.ServiceAdapter":
                    c = new Component();
                    break;
                case "Droid_Infra.SonarAdapter":
                    c = new ComponentSonar();
                    break;
                case "Droid_Infra.SqlAdapter":
                    c = new ComponentSql();
                    break;
                case "Droid_Infra.SyncanyAdapter":
                    c = new ComponentSyncany();
                    break;
                case "Droid_Infra.TeamCityAdapter":
                    c = new ComponentTeamCity();
                    break;
                default:
                    c = new Component();
                    break;
            }
            c.Top = 31;
            c.Left = 1;
            return c;
        }
        private Panel BuildPanel(InfraAdapteur component, Label lblTitle, PictureBox pb, List<Point> points, Component cpn)
        {
            Panel p = new Panel();
            p.Width = 100;
            p.Height = 100;
            p.Top = points[_intInfra.InfraFarm.InfraComponents.IndexOf(component)].Y - OFFSETY;
            p.Left = points[_intInfra.InfraFarm.InfraComponents.IndexOf(component)].X - OFFSETX;
            p.BackgroundImage = component.Online ? Properties.Resources.component : Properties.Resources.componentOffline;
            p.Controls.Add(lblTitle);
            p.Controls.Add(pb);
            p.Controls.Add(cpn);

            return p;
        }
        private void DrawLink(Panel p1, Panel p2, Graphics g, bool connected)
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
