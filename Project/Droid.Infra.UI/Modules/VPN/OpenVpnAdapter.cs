using Droid.Infra.Modules.VPN.View;
using Droid.Infra.OpenVPN;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Tools.Utilities;

namespace Droid.Infra
{
    [Serializable]
    public class OpenVpnAdapterUI : InfraAdapter
    {
        #region Attributes
        public event InterfaceEventHandler SheetDisplayRequested;

        private InterfaceInfra _parent;
        private List<VPNConfig> _configs = new List<VPNConfig>();

        private ViewVpnManager _viewVpnManager;
        #endregion

        #region Properties
        [XmlIgnore]
        public InterfaceInfra IntInf
        {
            get { return _parent; }
            set { _parent = value; }
        }
        public string BinDirectory
        {
            get
            {
                string exe = UtilsHelper.LocateOpenVPN();
                FileInfo fi = new FileInfo(exe);
                return fi.DirectoryName;
            }
        }
        public override bool Online
        {
            get
            {
                try
                {
                    //string command = Path.Combine(BinDirectory + "\\openvpn.exe");
                    //command = command.Split(':')[command.Split(':').Length - 1];
                    //command = "\"" + command + "\"  --version";
                    //command = command.Replace("\\\\", "\\");
                    //string ret = Command.ExecuteCommand(command);
                    //return ret.Contains("OpenVPN");
                    return !string.IsNullOrEmpty(BinDirectory);
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public int Proxy
        {
            get { return _configs.Count; }
        }
        #endregion

        #region Constructor
        public OpenVpnAdapterUI()
        {
            _techno = TECHNO.OPENVPN;
            _type = AdapterType.OpenVpnAdapter;
            LoadConfig();
        }
        public OpenVpnAdapterUI(InterfaceInfra intInfra)
        {
            _techno = TECHNO.OPENVPN;
            _type = AdapterType.OpenVpnAdapter;
            _parent = intInfra;
            LoadConfig();
        }
        #endregion

        #region Methods public
        public override void GoAction(string action)
        {
            throw new NotImplementedException();
        }
        public async void LoadConfig()
        {
            await Task.Run(() => ReadConfigs());
        }
        #endregion

        #region Methods private
        private void ReadConfigs()
        {
            // unload config first, if needed
            UnloadConfigs();

            // find config files
            List<String> configs = UtilsHelper.LocateOpenVPNConfigs(Properties.Settings.Default.vpnconf);
            configs.AddRange(UtilsHelper.LocateOpenVPNManagerConfigs(false));

            // insert configs in context menu and panel
            //int atIndex = 2;
            if (configs != null)
            {
                //toolStripSeparator2.Visible = true;

                foreach (string cfile in configs)
                {
                    try
                    {
                        VPNConfig c = VPNConfig.CreateUserspaceConnection(Properties.Settings.Default.vpnbin, cfile, Properties.Settings.Default.debugLevel, Properties.Settings.Default.smartCardSupport, _viewVpnManager);

                        _configs.Add(c);
                        //contextMenu.Items.Insert(atIndex++, c.Menuitem);
                        //pnlStatus.Controls.Add(c.InfoBox);
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(ProgramVPN.res.GetString("BOX_Config_Error") + Environment.NewLine + cfile + ": " + e.Message);
                        //RTLMessageBox.Show(this,
                        //    ProgramVPN.res.GetString("BOX_Config_Error") +
                        //    Environment.NewLine + cfile + ": " +
                        //    e.Message, MessageBoxIcon.Exclamation);
                    }
                }
            }

            configs = UtilsHelper.LocateOpenVPNManagerConfigs(true);
            if (Helper.CanUseService())
            {
                configs.AddRange(Helper.LocateOpenVPNServiceConfigs());
            }

            //toolStripSeparator2.Visible = configs.Count > 0;
            foreach (string cfile in configs)
            {
                try
                {
                    VPNConfig c = VPNConfig.CreateServiceConnection(cfile, Properties.Settings.Default.debugLevel, Properties.Settings.Default.smartCardSupport, _viewVpnManager);
                    _configs.Add(c);
                    //contextMenu.Items.Insert(atIndex++, c.Menuitem);
                    //pnlStatus.Controls.Add(c.InfoBox);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(ProgramVPN.res.GetString("BOX_Config_Error") + Environment.NewLine + cfile + ": " + e.Message);
                    //RTLMessageBox.Show(this,
                    //    ProgramVPN.res.GetString("BOX_Config_Error") +
                    //    Environment.NewLine + cfile + ": " +
                    //    e.Message, MessageBoxIcon.Error);
                }
            }
        }
        private void UnloadConfigs()
        {
            foreach (VPNConfig vpnc in _configs)
                vpnc.Disconnect(true);

            // disconnect all configs, remove menu items
            while (_configs.Count > 0)
            {
                while (
                    _configs[0].VPNConnection.State.CreateSnapshot().ConnectionState
                        != VPNConnectionState.Stopped)
                {
                    System.Threading.Thread.Sleep(200);
                }
                //contextMenu.Items.Remove(m_configs[0].Menuitem);
                _configs.Remove(_configs[0]);
            }

            //toolStripSeparator2.Visible = false;
        }
        
        private void LaunchManage()
        {
            if (_viewVpnManager == null) { _viewVpnManager = new ViewVpnManager(); }
            _viewVpnManager.Adapter = this;
            LaunchSheet(_viewVpnManager);
        }
        protected override string BuildPanelCustom()
        {
            string html = string.Format(MONITORINGHTML, Online ? "componentOnline" : "componentOffline", "id123", "styleposition", (string.IsNullOrEmpty(_name) ? _techno.ToString() : _name));
            return html;
        }
        #endregion

        #region Event
        #endregion
    }
}
