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
using System.IO;
using Droid.Web;
using System.Reflection;

namespace Droid.Infra.UI.Infra.View
{
    public partial class ViewInfraMonitoring : UserControlCustom
    {
        #region Attributes

        #region CONST
        private const string PAGE = @"";
        #endregion

        private DroidWebBrowserPage _webPage;
        private InterfaceInfra _intInfra;
        private Timer _timer;
        #endregion

        #region Properties
        public InterfaceInfra IntInfra
        {
            get { return _intInfra; }
            set { _intInfra = value; }
        }
        #endregion

        #region Constructor
        public ViewInfraMonitoring()
        {
            InitializeComponent();
            Init();
        }
        public ViewInfraMonitoring(InterfaceInfra intInfra)
        {
            _intInfra = intInfra;
            InitializeComponent();
            Init();
        }
        ~ViewInfraMonitoring()
        {
            _webPage.SuspendLayout();
            _webPage.Dispose();
        }
        #endregion

        #region Methods public
        public override void RefreshData()
        {
            try
            {
                if (_isActive)
                { 
                    BuildMonitorHtml();
                    _webPage?.RefreshData();
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
            }
        }
        #endregion

        #region Methods private
        private void Init()
        {
            BuildWeb();

            _webPage = new Web.DroidWebBrowserPage();
            _webPage.Dock = DockStyle.Fill;
            _webPage.ChangeUrlPanel(false);
            _webPage.File = Path.Combine(_intInfra.WorkingDirectory, "Web", "app.html");
            this.Controls.Add(_webPage);
            //this.Load += ViewInfraMonitoring_Load;
            //_webBrowser.DocumentCompleted += _webBrowser_DocumentCompleted;
            //_webBrowser.ScriptErrorsSuppressed = true;

            this.Resize += ViewMonitoring_Resize;
            RefreshData();

            _timer = new Timer();
            _timer.Interval = 2000;
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }
        private void BuildWeb()
        {
            if (_intInfra != null)
            {
                if (!Directory.Exists(Path.Combine(_intInfra.WorkingDirectory, "Web")))
                {
                    Directory.CreateDirectory(Path.Combine(_intInfra.WorkingDirectory, "Web"));
                }
                if (!Directory.Exists(Path.Combine(_intInfra.WorkingDirectory, "Web", "css")))
                {
                    Directory.CreateDirectory(Path.Combine(_intInfra.WorkingDirectory, "Web", "css"));
                }
                if (!Directory.Exists(Path.Combine(_intInfra.WorkingDirectory, "Web", "js")))
                {
                    Directory.CreateDirectory(Path.Combine(_intInfra.WorkingDirectory, "Web", "js"));
                }
                if (!Directory.Exists(Path.Combine(_intInfra.WorkingDirectory, "Web", "img")))
                {
                    Directory.CreateDirectory(Path.Combine(_intInfra.WorkingDirectory, "Web", "img"));
                }
                if (!File.Exists(Path.Combine(_intInfra.WorkingDirectory, "Web", "img", "ShieldTileBg.png")))
                {
                    Properties.Resources.ShieldTileBg.Save(Path.Combine(_intInfra.WorkingDirectory, "Web", "img", "ShieldTileBg.png"));
                }
                if (!File.Exists(Path.Combine(_intInfra.WorkingDirectory, "Web", "js", "jsplumb.js")))
                {
                    File.WriteAllText(Path.Combine(_intInfra.WorkingDirectory, "Web", "js", "jsplumb.js"), Properties.Resources.jsplumb_js);
                }
                if (!File.Exists(Path.Combine(_intInfra.WorkingDirectory, "Web", "js", "app.js")))
                {
                    File.WriteAllText(Path.Combine(_intInfra.WorkingDirectory, "Web", "js", "app.js"), Properties.Resources.app_js);
                }
                if (!File.Exists(Path.Combine(_intInfra.WorkingDirectory, "Web", "css", "app.css")))
                {
                    File.WriteAllText(Path.Combine(_intInfra.WorkingDirectory, "Web", "css", "app.css"), Properties.Resources.app_css);
                }
                RefreshData();
            }
        }
        private void BuildMonitorHtml()
        {
            string _htmlMonitor = @"<!doctype html>
                <html>
                    <head>
		                <link rel='stylesheet' href='css/app.css'>
                        <script src='js/jsplumb.js'></script>
                        <script src='js/app.js'></script>
                    </head>
                    <body>
		                {0}
                    </body>
                </html>";
            Point[] positions = new Point[]
            {
                new Point(20, 40),
                new Point(50, 30),
                new Point(30, 20),
                new Point(55, 50),
                new Point(50, 70),
                new Point(30, 80),
                new Point(5, 75),
                new Point(4, 65),
                new Point(4, 50),
                new Point(5, 26),
                new Point(5, 38),
                new Point(5, 25),
                new Point(4, 37),
                new Point(5, 30),
                new Point(5, 30),
                new Point(5, 30),
                new Point(5, 30),
                new Point(5, 30),
                new Point(5, 30)
            };

            int id = 0;
            string _htmlComponent = string.Empty;
            string component;
            foreach (InfraAdapter item in _intInfra.InfraFarm.Adapters.OrderBy(a => a.Domain))
            {
                component = item.MonitoringPanel.Replace("id123", "targetWindow" + id);
                component = component.Replace("styleposition", string.Format("position: absolute; top:{0}%; left:{1}%;", positions[id].X, positions[id].Y));
                _htmlComponent += component;
                id++;
            }

            if (!ComputerAdapter.IsFileLocked(Path.Combine(_intInfra.WorkingDirectory, "Web", "app.html")))
            { 
                if (File.Exists(Path.Combine(_intInfra.WorkingDirectory, "Web", "app.html")))
                {
                    File.WriteAllText(Path.Combine(_intInfra.WorkingDirectory, "Web", "app_new.html"), string.Format(_htmlMonitor, _htmlComponent));
                    File.Replace(Path.Combine(_intInfra.WorkingDirectory, "Web", "app_new.html"), Path.Combine(_intInfra.WorkingDirectory, "Web", "app.html"), Path.Combine(_intInfra.WorkingDirectory, "Web", "app.backup"));
                }
                else
                {
                    File.WriteAllText(Path.Combine(_intInfra.WorkingDirectory, "Web", "app.html"), string.Format(_htmlMonitor, _htmlComponent));
                }
            }
        }
        private void CopyStream(Stream input, Stream output)
        {
            if (input != null && output != null)
            { 
                byte[] buffer = new byte[8192];

                int bytesRead;
                while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    output.Write(buffer, 0, bytesRead);
                }
            }
        }
        #endregion

        #region Event
        private void ViewMonitoring_Resize(object sender, EventArgs e)
        {
            _webPage?.RefreshData();
        }
        private void _timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();
            RefreshDataAsync();
            _timer.Start();
        }
        #endregion
    }
}
