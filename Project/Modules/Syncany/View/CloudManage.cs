using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Tools4Libraries;

namespace Droid_Infra
{
    public partial class CloudManage : UserControlCustom
    {
        #region Attribute
        private SyncanyAdapter _syncany;
        private string _workingDirectory;
        private Timer _timer;
        #endregion

        #region Properties
        public string WorkingDirectory
        {
            get { return _workingDirectory; }
            set { _workingDirectory = value; }
        }
        public SyncanyAdapter SyncanyAdapter
        {
            get { return _syncany; }
            set { _syncany = value; }
        }
        #endregion

        #region Constructor
        public CloudManage(SyncanyAdapter syncany, string workingDirectory)
        {
            _syncany = syncany;
            _workingDirectory = workingDirectory;
            _timer = new Timer();
            _timer.Interval = 37000;
            _timer.Tick += _timer_Tick;
            _timer.Start();

            InitializeComponent();
        }
        #endregion

        #region Methods public
        public override void RefreshData()
        {
            if (_syncany != null)
            { 
                labelDaemonStatusValue.Text = Daemon.Started ? GetText.Text("Started") : GetText.Text("Stopped");
                labelConfigFileValue.Text = string.IsNullOrEmpty(_syncany.CloudConfigPath) ? GetText.Text("Noconfigpathsaved") : _syncany.CloudConfigPath;
                labelDaemonPIDValue.Text = Daemon.ProcessId.ToString();
                labelLoginValue.Text = string.IsNullOrEmpty(_syncany.Login) ? GetText.Text("Unknow") : _syncany.Login;
                labelPasswordValue.Text = string.IsNullOrEmpty(_syncany.Password) ? GetText.Text("Unknow") : "*******";
                labelSynchroDateValue.Text = _syncany.LastSynchronisation.ToString();
                buttonSynchroStartStop.Text = _syncany.SynchronisationRunning ? GetText.Text("Started") : GetText.Text("Stopped");
                RefreshDataDirectories();
            }
        }
        public override void ChangeLanguage()
        {
            RefreshData();
            labelDaemonStatus.Text = GetText.Text("daemonstatus");
            labelConfigFolderPath.Text = GetText.Text("configFolderPath");
            labelDaemonPID.Text = GetText.Text("daemonPid");
            labelLogin.Text = GetText.Text("login");
            labelPassword.Text = GetText.Text("password");
            labelSynchroDate.Text = GetText.Text("synchroDate");
            buttonSynchroStartStop.Text = _syncany.SynchronisationRunning ? GetText.Text("Started") : GetText.Text("Stopped");
        }
        #endregion

        #region Methods private
        private void RefreshDataDirectories()
        {
            List<Watch> watchList = Daemon.WatchList;

            dataGridViewRepo.Rows.Clear();

            foreach (var repo in _syncany.CloudRepositories)
            {
                AddRowDatagridview(repo.Split('|')[0], watchList);
            }
        }
        private void AddRowDatagridview(string repo, List<Watch> watchList)
        {
            DataGridViewRow row;
            Watch currentWatch;
            List<Watch> watchListTmp = watchList.Where(w => w.Path.Equals(repo)).ToList();

            if (watchListTmp.Count > 0)
            {
                currentWatch = watchListTmp[0];

                dataGridViewRepo.Rows.Add();
                row = dataGridViewRepo.Rows[dataGridViewRepo.Rows.Count - 1];

                row.Cells[ColumnEnabled.Index].Value = currentWatch != null;
                row.Cells[ColumnPath.Index].Value = currentWatch.Path;
                row.Cells[ColumnId.Index].Value = currentWatch.Id;

                string typeRepo = string.Empty;
                foreach (var item in _syncany.CloudRepositories)
                {
                    if (item.Split('|')[0].Equals(repo))
                    {
                        typeRepo = item.Split('|')[1];
                        row.Cells[ColumnTypeName.Index].Value = typeRepo;
                        break;
                    }
                }

                switch (typeRepo)
                {
                    case "azure":
                        row.Cells[ColumnIcon.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.network;
                        break;
                    case "dropbox":
                        row.Cells[ColumnIcon.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.network;
                        break;
                    case "flickr":
                        row.Cells[ColumnIcon.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.flickr;
                        break;
                    case "ftp":
                        row.Cells[ColumnIcon.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.ftp;
                        break;
                    case "gui":
                        row.Cells[ColumnIcon.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.network;
                        break;
                    case "local":
                        row.Cells[ColumnIcon.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.folder;
                        break;
                    case "raid0":
                        row.Cells[ColumnIcon.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.cd;
                        break;
                    case "s3":
                        row.Cells[ColumnIcon.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.network;
                        break;
                    case "samba":
                        row.Cells[ColumnIcon.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.network;
                        break;
                    case "sftp":
                        row.Cells[ColumnIcon.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.network;
                        break;
                    case "swift":
                        row.Cells[ColumnIcon.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.network;
                        break;
                    case "webdav":
                        row.Cells[ColumnIcon.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.drive_web;
                        break;
                    default:
                        row.Cells[ColumnIcon.Index].Value = Tools4Libraries.Resources.ResourceIconSet16Default.network;
                        break;
                }
            }
        }
        private void SwitchSynchro()
        {
            if (_syncany.SynchronisationRunning)
            {
                _syncany.SuspendSynchro();
            }
            else
            {
                _syncany.ResumeSynchro();
            }
            buttonSynchroStartStop.Text = _syncany.SynchronisationRunning ? GetText.Text("Started") : GetText.Text("Stopped");
        }
        #endregion

        #region Event
        private void buttonSynchroStartStop_Click(object sender, EventArgs e)
        {
            SwitchSynchro();
        }
        private void _timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();
            SuspendLayout();
            labelSynchroDateValue.Text = _syncany.LastSynchronisation.ToString();
            this.Invalidate();
            ResumeLayout();
            _timer.Start();
        }
        #endregion
    }
}
