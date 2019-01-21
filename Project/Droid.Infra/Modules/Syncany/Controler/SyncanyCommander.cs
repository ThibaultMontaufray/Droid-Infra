// Log 00 01

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Tools.Utilities;

namespace Droid.Infra
{
    public static class SyncanyCommander
    {
        #region Attribute
        #endregion

        #region PropertiesH
        public static List<Plugin> AvalailablePlugins
        {
            get
            {
                string[] tab = GetListPlugins();
                return Plugin.Parse(new List<string>(tab));
            }
        }
        public static string Status
        {
            get { return "";  }
        }
        #endregion

        #region Constructor
        static SyncanyCommander()
        {
            if (string.IsNullOrEmpty(Log.ApplicationAppData))
            { 
                Log.ApplicationAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Servodroid\Droid-Infra";
            }
        }
        #endregion

        #region Methods public
        /// <summary>
        /// Creates a new repository using any plugin and generates a syncany://link
        /// </summary>
		public static void Init(string cloudConfigFilesPath, string cloudOriginalFilesPath, string user, string passwword, string cloudType)
        {
            string root = Path.GetPathRoot(cloudOriginalFilesPath);

            string[] commands = new string[3];
            commands[0] = root.Replace("\\" , string.Empty);
            commands[1] = "cd " + cloudOriginalFilesPath;
            commands[2] = string.Format("sy -d init --plugin={0} --plugin-option=path=\"{1}\" -o username='{2}' -o password='{3}' --no-encryption --no-compression --add-daemon", cloudType, cloudConfigFilesPath, user, passwword);
            ConsoleLauncher.ExecuteCommand(commands);
        }
        /// <summary>
        /// connects to an existing repository using a syncany://-link
        /// </summary>
		public static void Connect(string cloudConfigPath, string repoToAssociate, string typeConnection)
        {
            string root = Path.GetPathRoot(repoToAssociate);

            string[] commands = new string[3];
            commands[0] = root.Replace("\\", string.Empty);
            commands[1] = "cd " + repoToAssociate;
            commands[2] = string.Format("sy connect --plugin={0} --plugin-option=path={1} --add-daemon", typeConnection, cloudConfigPath);
            ConsoleLauncher.ExecuteCommand(commands);
        }
        /// <summary>
        /// detects local changes and uploads them to the repository
        /// </summary>
        public static void Up(string workingDirectory)
        {
            string root = Path.GetPathRoot(workingDirectory);

            string[] commands = new string[3];
            commands[0] = root.Replace("\\", string.Empty);
            commands[1] = "cd " + workingDirectory;
            commands[2] = "sy up";
            ConsoleLauncher.ExecuteCommand(commands);
        }
        /// <summary>
        /// downloads changes by other people and apply them to your local machine
        /// </summary>
        public static void Down(string workingDirectory)
        {
            string root = Path.GetPathRoot(workingDirectory);

            string[] commands = new string[3];
            commands[0] = root.Replace("\\", string.Empty);
            commands[1] = "cd " + workingDirectory;
            commands[2] = "sy down";
            ConsoleLauncher.ExecuteCommand(commands);
        }
        /// <summary>
        /// starts background daemon to automatically sync your files
        /// </summary>
        public static void Starts()
        {
            ConsoleLauncher.ExecuteCommand("sy daemon start");
        }
        /// <summary>
        /// restores an old version of a file to the local folder
        /// </summary>
        public static void Restores(string revision)
        {
            ConsoleLauncher.ExecuteCommand("sy resetore --revision=2 5shr616");

        }
        /// <summary>
        /// downloads and install the plugin
        /// </summary>
        /// <param name="packcageName">Name of the plugin to install</param>
        public static void PluginInstall(string packcageName)
        {
            ConsoleLauncher.ExecuteCommand("sy plugin install " + packcageName);
        }
        #endregion

        #region Methods private
        private static string[] GetListPlugins()
        {
            string ret = ConsoleLauncher.ExecuteCommand("sy plugin list");
            return ret.Split('\n');
        }
        #endregion

        #region Event
        #endregion
    }
}
