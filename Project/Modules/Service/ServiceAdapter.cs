using System;
using System.Collections.Generic;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Droid_Infra
{
    public static class ServiceAdapter
    {
        #region Methods public
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

        public static string GetStatus(string serviceName)
        {
            ServiceController serviceController = new ServiceController(serviceName);
            return serviceController.Status.ToString();
        }
        public static string StartService(string serviceName)
        {
            ServiceController serviceController = new ServiceController(serviceName);
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
        #endregion
    }
}
