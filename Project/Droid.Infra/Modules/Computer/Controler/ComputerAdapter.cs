using System;
using System.Management;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.DirectoryServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using Microsoft.Win32;
using System.Timers;
using System.Xml.Serialization;
using System.Net.NetworkInformation;

// integrate this windows shortcuts : http://www.keyboard-shortcut.com/windows/run.php
namespace Droid.Infra
{
    // vide fichier tmp C:\Users\amost\AppData\Local\Temp
    //      poubelle
    //      
    public class ComputerAdapter : InfraAdapter
    {
        #region Attributes
        private WindowsIdentity _curIdentity;
        private WindowsPrincipal _principal;
        //private ComputerInfo _computerCi;
        private string _savedGraphicCard;
        private EventLogEntryCollection _sysEvents;
        private IISAdapter _iis;
        private long _ping;
        #endregion

        #region Properties
        [XmlIgnore]
        public string GraphicCard
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(_savedGraphicCard))
                    {
                        ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");
                        foreach (ManagementObject mo in searcher.Get())
                        {
                            foreach (PropertyData property in mo.Properties)
                            {
                                if (property.Name == "Description")
                                {
                                    _savedGraphicCard = property.Value.ToString();
                                }
                            }
                        }
                    }
                    return _savedGraphicCard;
                }
                catch 
                {
                    return string.Empty;
                }
            }
        }
        [XmlIgnore]
        public string RAM
        {
            get
            {
                return string.Empty; // _computerCi.TotalPhysicalMemory.ToString();
            }
        }
        [XmlIgnore]
        public string Os
        {
            get { return Environment.OSVersion.Platform.ToString(); }
        }
        [XmlIgnore]
        public string MicrosoftAccount
        {
            get
            {
                NTAccount nta;
                foreach (var item in _curIdentity.Groups)
                {
                    nta = (NTAccount)item.Translate(typeof(NTAccount));
                    if (nta.Value.ToLower().Contains("microsoftaccount") && nta.Value.Split('\\').Length > 1)
                    {
                        return nta.Value.Split('\\')[1];
                    }
                }
                return string.Empty;
            }
        }
        [XmlIgnore]
        public bool IsSystem
        {
            get
            {
                return _curIdentity.IsSystem;
            }
        }
        [XmlIgnore]
        public bool IsAdmin
        {
            get
            {
                return _principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }
        [XmlIgnore]
        public bool IsAuthenticated
        {
            get
            {
                return _curIdentity.IsAuthenticated;
            }
        }
        [XmlIgnore]
        public EventLogEntryCollection SysEvent
        {
            get { return _sysEvents; }
            set { _sysEvents = value; }
        }
        [XmlIgnore]
        public IISAdapter IIS
        {
            get { return _iis; }
            set { _iis = value; }
        }
        [XmlIgnore]
        public uint LastActivity
        {
            get
            {
                return Win32.GetIdleTime();
            }
        }
        public override bool Online
        {
            get
            {
                return _online;
            }
        }
        public long Ping
        {
            get { return _ping; }
            set { _ping = value; }
        }
        #endregion

        #region Constructor
        public ComputerAdapter()
        {
            _techno = TECHNO.SERVER;
            _type = AdapterType.ComputerAdapter;
            Init();
        }
        public ComputerAdapter(InterfaceInfra intInfra)
        {
            _techno = TECHNO.SERVER;
            _parent = intInfra;
            _type = AdapterType.ComputerAdapter;
            Init();
        }
        #endregion

        #region Methods public
        public new void RefreshData()
        {
            try
            {
                if (_name == "local")
                {
                    _ping = -1;
                    return;
                }
                if (!string.IsNullOrEmpty(_ip))
                {
                    Ping ping = new Ping();
                    string url = Droid.Web.Web.GetPingDomain(_ip);
                    PingReply pr = ping.Send(url);
                    _ping = pr.RoundtripTime;

                    _online = pr.Status == IPStatus.Success;
                }
                else if (!string.IsNullOrEmpty(_domain))
                {
                    Ping ping = new Ping();
                    string url = Droid.Web.Web.GetPingDomain(_domain);
                    PingReply pr = ping.Send(url);
                    _ping = pr.RoundtripTime;

                    _online = pr.Status == IPStatus.Success;
                }
            }
            catch (Exception)
            {
                _ping = 0;
                _online = false;
            }
        }
        public override void GoAction(string action)
        {
            switch (action)
            {
                //case "manage":
                //    LaunchMonitor();
                //    break;
            }
        }
        public DriveInfo[] GetDisks()
        {
            return DriveInfo.GetDrives();
        }
        public long GetDiskOccupancyPercent(string driveName)
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady && drive.Name == driveName)
                {
                    return 100 - ((drive.TotalFreeSpace * 100) / (drive.TotalSize));
                }
            }
            return -1;
        }
        
        public static string[] GetFiles(string directory, string mask)
        {
            Regex regex = new Regex(mask);
            List<string> fileList = new List<string>();
            FileInfo fi;

            string[] fileEntries = Directory.GetFiles(directory);
            foreach (string fileName in fileEntries)
            {
                fi = new FileInfo(fileName);
                if (regex.Match(fi.Name).Success) { fileList.Add(fileName); }
            }

            return fileList.ToArray();
        }
        public static void DosCommand(string command)
        {
            // TODO
        }
        public static bool ContainsFileExt(DirectoryInfo folder, string ext)
        {
            bool res = false;
            if (folder.GetFiles().Where(f => f.Extension.Equals(ext)).Count() != 0)
            {
                res = true;
            }
            else
            {
                foreach (string subFolder in Directory.GetDirectories(folder.FullName))
                {
                    if (ContainsFileExt(new DirectoryInfo(subFolder), ext))
                    {
                        res = true;
                        break;
                    }
                }
            }
            return res;
        }
        public static List<string> GetComputerUsers()
        {
            List<string> users = new List<string>();
            var path =
                string.Format("WinNT://{0},computer", Environment.MachineName);

            using (var computerEntry = new DirectoryEntry(path))
                foreach (DirectoryEntry childEntry in computerEntry.Children)
                    if (childEntry.SchemaClassName == "User")
                        users.Add(childEntry.Name);

            return users;
        }
        public static bool IsFileLocked(string filePath)
        {
            if (File.Exists(filePath))
            {
                FileInfo file = new FileInfo(filePath);
                FileStream stream = null;

                try
                {
                    stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);
                }
                catch (IOException)
                {
                    return true;
                }
                finally
                {
                    if (stream != null) { stream.Close(); }
                }
            }
            return false;
        }
        #endregion

        #region Methods private
        private void Init()
        {
            try
            {
                Microsoft.Win32.SystemEvents.SessionSwitch += new Microsoft.Win32.SessionSwitchEventHandler(SystemEvents_SessionSwitch);

                _curIdentity = WindowsIdentity.GetCurrent();
                _principal = new WindowsPrincipal(_curIdentity);
                //_computerCi = new ComputerInfo();
                if (IsAuthenticated && IsAdmin) { _iis = new IISAdapter(); }

                _sysEvents = new EventLog("System").Entries;
                EventLog eventLog = new EventLog("System");
                eventLog.EnableRaisingEvents = true;
                eventLog.EntryWritten += new EntryWrittenEventHandler(OnEntryWritten);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
        protected override string BuildPanelCustom()
        {
            try
            {
                string html = string.Empty;
                string detail = string.Empty;

                RefreshData();

                if (_name == "local")
                {
                    html = string.Format(MONITORINGHTML, "componentLocal", "sourceWindow1", "", _name.ToUpper());
                    html = html.Replace("<div class='circle-ripple'></div>", string.Empty);
                    detail = "<li>&nbsp;</li>";
                    detail += "<li> - OS : " + Os + "</li>";
                    detail += "<li> - RAM : " + RAM + "</li>";
                    foreach (var item in GetDisks().Where(d => d.DriveType == DriveType.Fixed))
                    {
                        var percent = GetDiskOccupancyPercent(item.Name);
                        if (percent != -1)
                        {
                            detail += string.Format("<li> - Disk {0} : \t{1} %</li>", item.Name, percent);
                        }
                    }
                }
                else
                {
                    html = string.Format(MONITORINGHTML, Online ? "componentOnline" : "componentOffline", "id123", "styleposition", _name.ToUpper());
                    detail = "<li>&nbsp;</li>";
                    detail += "<li> - Ping : " + Ping + "</li>";
                }

                return html.Replace("<li>&nbsp;</li>", detail);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                return string.Empty;
            }
        }
        
        private void ScanWindowsLogs()
        {
            string watchLog = "System";
            EventLog myLog = new EventLog(watchLog);
            // set event handler
            myLog.EntryWritten += new EntryWrittenEventHandler(OnEntryWritten);
            myLog.EnableRaisingEvents = true;
        }
        #endregion

        #region Event
        void SystemEvents_SessionSwitch(object sender, Microsoft.Win32.SessionSwitchEventArgs e)
        {
            if (e.Reason == SessionSwitchReason.SessionLock)
            {
                Console.WriteLine("User left (session locked) : " + DateTime.Now.ToShortTimeString());
            }
            else if (e.Reason == SessionSwitchReason.SessionUnlock)
            {
                Console.WriteLine("User back (session unlocked) : " + DateTime.Now.ToShortTimeString());
            }
        }
        private void OnEntryWritten(object source, EntryWrittenEventArgs e)
        {
            //int e1 = 0;
            EventLog log = new EventLog("System");
            _sysEvents = log.Entries;

            //e1 = _sysEvents.Count - 1;
            //Console.WriteLine(_sysEvents[e1].Message);
            log.Close();
        }
        #endregion
    }

    internal struct LASTINPUTINFO
    {
        public uint cbSize;
        public uint dwTime;
    }
    public class Win32
    {
        [DllImport("User32.dll")]
        public static extern bool LockWorkStation();

        [DllImport("User32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        [DllImport("Kernel32.dll")]
        private static extern uint GetLastError();

        public static uint GetIdleTime()
        {
            LASTINPUTINFO lastInPut = new LASTINPUTINFO();
            lastInPut.cbSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(lastInPut);
            GetLastInputInfo(ref lastInPut);

            return ((uint)Environment.TickCount - lastInPut.dwTime);
        }

        public static long GetTickCount()
        {
            return Environment.TickCount;
        }

        public static long GetLastInputTime()
        {
            LASTINPUTINFO lastInPut = new LASTINPUTINFO();
            lastInPut.cbSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(lastInPut);
            if (!GetLastInputInfo(ref lastInPut))
            {
                throw new Exception(GetLastError().ToString());
            }

            return lastInPut.dwTime;
        }


    }
}
