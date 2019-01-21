using System;
using System.Collections.Generic;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Droid.Infra
{
    public static class ServiceAdapter
    {
        #region Attributes
        #endregion

        #region Properties
        #endregion

        #region Constructor
        #endregion

        #region Methods public
        public static bool Exist(string serviceName)
        {
            try
            {
                return !string.IsNullOrEmpty(new ServiceController(serviceName).DisplayName);
            }
            catch
            {
                return false;
            }
        }
        public static bool InstallService(string servicePath)
        {
            try
            {
                ManagedInstallerClass.InstallHelper(new string[] { servicePath });
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool UninstallService(string servicePath)
        {
            try
            {
                ManagedInstallerClass.InstallHelper(new string[] { "/u", servicePath });
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static string Path(string serviceName)
        {
            try
            {
                using (ManagementObject wmiService = new ManagementObject("Win32_Service.Name='" + serviceName + "'"))
                {
                    wmiService.Get();
                    FileInfo fi = new FileInfo(wmiService["PathName"].ToString());
                    return fi.DirectoryName;
                }
            }
            catch
            {
                return string.Empty;
            }
            return string.Empty;
        }

        public static string GetStatus(string serviceName)
        {
            ServiceController serviceController = new ServiceController(serviceName);
            return serviceController.Status.ToString();
        }
        public static string StartService(string serviceName)
        {
            ServiceController serviceController = new ServiceController(serviceName);
            serviceController.MachineName = "localhost";
            serviceController.Start();
            return "Start command completed";
        }
        public static string StopService(string serviceName)
        {
            ServiceController serviceController = new ServiceController(serviceName);
            if (serviceController.CanStop)
            {
                serviceController.Stop();
                return "Stopped";
            }
            else
                return "Can't stop the service";
        }
        public static string Pause(string serviceName)
        {
            ServiceController serviceController = new ServiceController(serviceName);
            if (serviceController.CanPauseAndContinue)
            {
                if (serviceController.Status == ServiceControllerStatus.Running)
                {
                    serviceController.Pause();
                    return "Paused";
                }
                else if (serviceController.Status == ServiceControllerStatus.Paused)
                {
                    serviceController.Continue();
                    return "Resume";
                }
                else
                {
                    return "Stopped";
                }
            }
            else
            {
                return "Can't pause an continue";
            }
        }
        public static void Delete(string serviceName)
        {
            //sc.exe delete  servicename
        }
        #endregion

        #region Methods private
        private static string ExecuteCommand(string cmd)
        {
            string result = string.Empty;
            ProcessStartInfo psi = new ProcessStartInfo();
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

                process.WaitForExit(300000);

                using (StreamReader reader = process.StandardOutput)
                {
                    result = reader.ReadToEnd();
                }
            }
            return result;
        }
        #endregion

        #region Event
        private static void process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {

        }
        private static void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {

        }
        #endregion
    }
}
