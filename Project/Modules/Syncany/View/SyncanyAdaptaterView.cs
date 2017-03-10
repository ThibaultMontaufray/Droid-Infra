using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Droid_Infra.Syncany
{
    public partial class SyncanyAdaptaterView : Form
    {
        #region Attributes
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public SyncanyAdaptaterView()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        #endregion

        #region Event
        private void buttonInit_Click(object sender, EventArgs e)
        {
            //SyncanyAdapter.Init(textBoxRepoPath.Text, "DemoUser", "DemoPassword");
        }
        private void buttonUp_Click(object sender, EventArgs e)
        {
            //SyncanyAdapter.Up();
        }
        private void buttonDown_Click(object sender, EventArgs e)
        {
            //SyncanyAdapter.Down();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            SyncanyCommander.Starts();
        }
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            //SyncanyAdapter.Connect(textBoxConnect.Text);
        }
        private void buttonRestores_Click(object sender, EventArgs e)
        {
            SyncanyCommander.Restores(textBoxRestores.Text);
        }
        private void buttonPlugin_Click(object sender, EventArgs e)
        {
            SyncanyCommander.PluginInstall(textBoxPlugin.Text);
        }
        private void buttonListPlugins_Click(object sender, EventArgs e)
        {
            dataGridViewPlugins.DataSource = SyncanyCommander.AvalailablePlugins;
        }
        private void buttonDaemon_Click(object sender, EventArgs e)
        {
            labelDaemonStatus.Text = string.Format("Daemon status : {0}", Daemon.Started ? "Running" : "Stopped");
            labelDaemonPID.Text = string.Format("Daemon PID : {0}", Daemon.ProcessId.ToString());
        }
        private void buttonDaemonStart_Click(object sender, EventArgs e)
        {
            Daemon.Start();
            buttonDaemon_Click(null, null);
        }
        private void buttonDaemonStop_Click(object sender, EventArgs e)
        {
            Daemon.Stop();
            buttonDaemon_Click(null, null);
        }
        #endregion
    }
}
