using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using System.Security.Permissions;
using Microsoft.Web.Administration;

namespace Droid.Infra
{
    public class IISAdapter
    {
        #region Attributes
        private const string IISSERVICENAME = "W3SVC";
        private ServerManager _serverManager;
        #endregion

        #region Properties
        public string Version
        {
            get { return Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\InetStp", "MajorVersion", string.Empty).ToString(); }
        }
        public string Path
        {
            get { return Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\InetStp", "InstallPath", string.Empty).ToString(); }
        }
        public List<ApplicationPool> ApplicationPool
        {
            get
            {
                if (TryCreateServerManager())
                {
                    return _serverManager.ApplicationPools.ToList();
                }
                return null;
            }
        }
        public bool IsInstalled
        {
            get
            {
                try { return !string.IsNullOrEmpty(Path); }
                catch { return false; }
            }
        }
        public bool IsRunning
        {
            get
            {
                try
                {
                    ServiceController controller = new ServiceController(IISSERVICENAME);
                    return controller.Status == ServiceControllerStatus.Running;
                }
                catch { return false; }
            }
        }
        #endregion

        #region Constructor
        public IISAdapter()
        {
            Init();
        }
        #endregion

        #region Methods public
        public void Restart()
        {
            if (IsInstalled)
            {
                ServiceAdapter.StopService(IISSERVICENAME);
                System.Threading.Thread.Sleep(1000);
                ServiceAdapter.StartService(IISSERVICENAME);
            }
        }
        public void Stop()
        {
            if (IsInstalled)
            {
                ServiceAdapter.StopService(IISSERVICENAME);
            }
        }
        public void Start()
        {
            if (IsInstalled)
            {
                ServiceAdapter.StartService(IISSERVICENAME);
            }
        }
        public void RefreshData()
        {
            if (IsInstalled)
            {
                Console.WriteLine(" - IIS version : " + Version);
                Console.WriteLine(" - IIS path : " + Path);
                Console.WriteLine(" - IIS running : " + IsRunning);

                try
                {
                    DisplayIISPool();
                }
                catch (System.Security.SecurityException scx)
                {
                    Console.WriteLine(scx.Message + " " + scx.FailedAssemblyInfo.ToString());
                }
            }
        }
        public void CreateBinding(string site, string sitePath, string physicalPath)
        {
            ServerManager serverManager = new ServerManager();
            var v = _serverManager.Sites[site].Bindings;

            //_serverManager.Sites[site].Bindings.Add( Applications.Add(sitePath, physicalPath);
            _serverManager.Sites[site].Bindings.Add("*:80:test.com", "http");
            _serverManager.CommitChanges();
        }
        #endregion

        #region Methods private
        private void Init()
        {
            RefreshData();
        }
        private void DisplayIISPool()
        {
            if (TryCreateServerManager())
            { 
                foreach (ApplicationPool item in ApplicationPool)
                {
                    Console.WriteLine(" - IIS pool " + item.Name + " : " + GetAppPoolIdentity(item.Name));
                }
            }
        }
        private string GetAppPoolIdentity(string appPoolName)
        {
            if (TryCreateServerManager())
            {
                ApplicationPool appPool = _serverManager.ApplicationPools[appPoolName];
                appPool.ProcessModel.IdentityType = ProcessModelIdentityType.SpecificUser;
                return appPool.ProcessModel.UserName;
            }
            return string.Empty;
        }
        /// <summary>
        /// separate because of admin right requested
        /// </summary>
        /// <returns>True if created</returns>
        //[PrincipalPermissionAttribute(SecurityAction.Demand, Role = @"BUILTIN\Administrators")]
        private bool TryCreateServerManager()
        {
            try
            {
                if (_serverManager == null)
                {
                    _serverManager = new ServerManager();
                }
                return _serverManager != null;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                return false;
            }
        }
        #endregion

        #region Event
        #endregion
    }
}
