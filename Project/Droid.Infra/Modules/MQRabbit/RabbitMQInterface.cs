using Microsoft.Extensions.Configuration;
using RabbitMQ.Client;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace Droid.Infra
{
    public abstract class RabbitMQInterface
    {
        #region Attributes
        private const string SERVICENAME = "RabbitMQ";
        private string _serverPath = string.Empty;

        private IConfiguration _config = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true).Build();

        protected ConnectionFactory _factory;
        protected string _queueName;
        protected bool _adminMode;
        #endregion

        #region Properties
        public bool IsInstalled
        {
            get
            {
                try
                {
                    return Environment.OSVersion.Platform.ToString().Contains("Win") ? ServiceAdapter.Exist(SERVICENAME) : false;
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                    return false;
                }
            }
        }
        public bool IsRunning
        {
            get
            {
                try
                {
                    return Environment.OSVersion.Platform.ToString().Contains("Win") ? IsInstalled && ServiceAdapter.GetStatus(SERVICENAME) == "Running" : false;
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                    return false;
                }
            }
        }
        public string Info
        {
            get
            {
                try
                {
                    return System.Text.Encoding.UTF8.GetString((byte[])_factory?.ClientProperties["information"]);
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                    return string.Empty;
                }
            }
        }
        public string Product
        {
            get
            {
                try
                {
                    return System.Text.Encoding.UTF8.GetString((byte[])_factory?.ClientProperties["product"]);
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                    return string.Empty;
                }
            }
        }
        public string Platform
        {
            get
            {
                try
                {
                    return System.Text.Encoding.UTF8.GetString((byte[])_factory?.ClientProperties["platform"]);
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                    return string.Empty;
                }
            }
        }
        public string Version
        {
            get
            {
                try
                {
                    return System.Text.Encoding.UTF8.GetString((byte[])_factory?.ClientProperties["version"]);
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                    return string.Empty;
                }
            }
        }
        public string Copyright
        {
            get
            {
                try
                {
                    return System.Text.Encoding.UTF8.GetString((byte[])_factory?.ClientProperties["copyright"]);
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                    return string.Empty;
                }
            }
        }
        public string Hostname
        {
            get
            {
                try
                {
                    return _factory?.HostName ?? string.Empty;
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                    return string.Empty;
                }
            }
        }
        public string Password
        {
            get
            {
                try
                {
                    return _factory?.Password ?? string.Empty;
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                    return string.Empty;
                }
            }
        }
        public string UserName
        {
            get
            {
                try
                {
                    return _factory?.UserName ?? string.Empty;
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                    return string.Empty;
                }
            }
        }
        public string Port
        {
            get
            {
                try
                {
                    return _factory?.Port.ToString() ?? string.Empty;
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                    return string.Empty;
                }
            }
        }
        public string Protocol
        {
            get
            {
                try
                {
                    return _factory?.Protocol.ToString() ?? string.Empty;
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                    return string.Empty;
                }
            }
        }
        public string TimeoutRead
        {
            get
            {
                try
                {
                    return _factory?.SocketReadTimeout.ToString() ?? string.Empty;
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                    return string.Empty;
                }
            }
        }
        public string TimeoutWrite
        {
            get
            {
                try
                {
                    return _factory?.SocketWriteTimeout.ToString() ?? string.Empty;
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                    return string.Empty;
                }
            }
        }
        public string SearchPath
        {
            get
            {
                try
                {
                    Task.Run(() => ScanPath());
                    return _serverPath;
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                    return string.Empty;
                }
            }
        }
        #endregion

        #region Constructor
        public RabbitMQInterface(string queueName = "DefaultQueue", bool adminMode = false)
        {
            _queueName = queueName;
            _adminMode = adminMode;
            InitConnection();
            Init();
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods protected
        protected abstract void Init();
        protected void InitConnection()
        {
            if (_adminMode) { InitAdmin(); }
            if (InitServiceRabbit())
            {
                InitConnectionRabbit();
            }
        }
        #endregion

        #region Methods private
        private bool InitServiceRabbit()
        {
            try
            {
                if (!Environment.OSVersion.Platform.ToString().Contains("Win")) { return false; }
                if (!IsRunning) { ServiceAdapter.StartService(SERVICENAME); }
                return IsRunning;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                return false;
            }
        }
        private void InitConnectionRabbit()
        {
            int port;
            if (int.TryParse(_config["RABBIT_PORT"], out port))
            {
                _factory = new ConnectionFactory()
                {
                    Endpoint = new AmqpTcpEndpoint(_config["RABBIT_HOST"], port)
                };
            }
        }
        private async void InitAdmin()
        {
            await new Task(() => ScanPath());
        }

        private void ScanPath()
        {
            try
            {
                Console.WriteLine("Start searching server exe path : " + DateTime.Now.ToString());
                DriveInfo[] allDrives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in allDrives.Where(d => d.DriveType == DriveType.Fixed).OrderByDescending(d => d.Name))
                {
                    if (drive.IsReady)
                    {
                        DirectoryInfo scanDir = new DirectoryInfo(drive.Name);
                        if (ScanFolder(scanDir))
                        {
                            break;
                        }
                    }
                }
                Console.WriteLine("Finish searching server exe path : " + DateTime.Now.ToString());
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
        private bool ScanFolder(DirectoryInfo folder)
        {
            try
            {
                if (folder.FullName.Length < 248 && CanRead(folder.FullName))
                {
                    if (folder.FullName.Contains("rabbitmq"))
                    { 
                        foreach (FileInfo file in folder.GetFiles())
                        {
                            if (file.Name.Equals("rabbitmqctl.bat"))
                            {
                                _serverPath = file.Directory.ToString();
                                return true;
                            }
                        }
                    }
                    foreach (DirectoryInfo dir in folder.GetDirectories())
                    {
                        if (ScanFolder(dir))
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        private bool CanRead(string path)
        {
            //try
            //{
            //    var readAllow = false;
            //    var readDeny = false;
            //    var accessControlList = Directory.GetAccessControl(path);
            //    if (accessControlList == null)
            //        return false;
            //    var accessRules = accessControlList.GetAccessRules(true, true, typeof(System.Security.Principal.SecurityIdentifier));
            //    if (accessRules == null)
            //        return false;

            //    foreach (FileSystemAccessRule rule in accessRules)
            //    {
            //        if ((FileSystemRights.Read & rule.FileSystemRights) != FileSystemRights.Read) continue;

            //        if (rule.AccessControlType == AccessControlType.Allow)
            //            readAllow = true;
            //        else if (rule.AccessControlType == AccessControlType.Deny)
            //            readDeny = true;
            //    }

            //    return readAllow && !readDeny;
            //}
            //catch
            //{
            //    return false;
            //}
            return true;
        }
        private async Task<string> ExecuteCommand(string cmd)
        {
            try
            {
                string result = string.Empty;
                if (System.Environment.OSVersion.Platform.ToString().Contains("Win"))
                {
                    if (string.IsNullOrEmpty(_serverPath)) { await new Task(() => ScanPath()); }

                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.WorkingDirectory = _serverPath;
                    psi.FileName = @"C:\Windows\System32\cmd.exe";
                    psi.UseShellExecute = false;
                    psi.Verb = "runas";
                    psi.Arguments = "/c " + cmd;
                    psi.RedirectStandardOutput = true;
                    psi.CreateNoWindow = true;

                    using (Process process = new Process())
                    {
                        process.StartInfo = psi;
                        process.OutputDataReceived += process_OutputDataReceived;
                        process.ErrorDataReceived += process_ErrorDataReceived;
                        process.Start();

                        process.WaitForExit(300000); // max 5 min to execute

                        using (StreamReader reader = process.StandardOutput)
                        {
                            result = reader.ReadToEnd();
                        }
                    }
                }
                return result;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                return string.Empty;
            }
        }
        #endregion

        #region Event
        protected static void process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine(e.ToString());
        }
        protected static void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine(e.ToString());
        }
        #endregion
    }
}
