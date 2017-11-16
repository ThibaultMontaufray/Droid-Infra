using System;
using System.Management;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;

namespace Droid_Infra
{
    public class ComputerAdapter : InfraAdapteur
    {
        #region Attributes
        private string _ip;
        private string _os;
        private string _login;
        private string _password;
        private string _ram;
        private string _graphicCard;
        #endregion

        #region Properties
        public string GraphicCard
        {
            get { return _graphicCard; }
            set { _graphicCard = value; }
        }
        public string RAM
        {
            get { return _ram; }
            set { _ram = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }
        public string Os
        {
            get { return _os; }
            set { _os = value; }
        }
        public string Ip
        {
            get { return _ip; }
            set { _ip = value; }
        }
        #endregion

        #region Constructor
        public ComputerAdapter()
        {

        }
        #endregion

        #region Methods public
        public static string DiscoverOSPlateform()
        {
            return Environment.OSVersion.Platform.ToString();
        }
        public static string DiscoverOSVersion()
        {
            return Environment.OSVersion.ToString();
        }
        public static string DiscoverGraphicCard()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");

            string graphicsCard = string.Empty;
            foreach (ManagementObject mo in searcher.Get())
            {
                foreach (PropertyData property in mo.Properties)
                {
                    if (property.Name == "Description")
                    {
                        graphicsCard = property.Value.ToString();
                    }
                }
            }
            return graphicsCard;
        }
        public static bool DiscoverIISInstalled()
        {
            try
            {
                ServiceController sc = new ServiceController("World Wide Web Publishing Service");
                if ((sc.Status.Equals(ServiceControllerStatus.Stopped) || sc.Status.Equals(ServiceControllerStatus.StopPending)))
                {
                    Console.WriteLine("Starting the service...");
                    sc.Start();
                }
                else
                {
                    Console.WriteLine("Stopping the service...");
                    sc.Stop();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Methods private
        #endregion
    }
}
