// Log code : 00 - 10

using System;
using System.Collections.Generic;
using Tools.Utilities;

namespace Droid.Infra
{
    public static class Daemon
    {
        #region Attribute
        #endregion

        #region Properties
        public static List<Watch> WatchList
        {
            get
            {
                string row = ConsoleLauncher.ExecuteCommand("sy daemon list");
                return ParseWatchList(row.Split('\n'));
            }
        }
        public static bool Started
        {
            get
            {
                string row = ConsoleLauncher.ExecuteCommand("sy daemon status");
                return !row.Contains("syncanyd not running");
            }
        }
        public static int ProcessId
        {
            get
            {
                string row = ConsoleLauncher.ExecuteCommand("sy daemon status");
                if (row.Contains("syncanyd running"))
                {
                    try
                    {
                        return int.Parse(row.Split(' ')[row.Split(' ').Length - 1]);
                    }
                    catch (Exception exp)
                    {
                        Log.Write("[ ERR 0010 ] Error looking for the daemon PID : " + exp.Message);
                        return -2;
                    }
                }
                else
                {
                    return -1;
                }
            }
        }
        #endregion

        #region Constructor
        #endregion

        #region Methods public
        public static void Start()
        {
            string row = ConsoleLauncher.ExecuteCommand("sy daemon start");
        }
        public static void Stop()
        {
            string row = ConsoleLauncher.ExecuteCommand("sy daemon stop");
        }
        public static void AddWatch(string folder)
        {
            ConsoleLauncher.ExecuteCommand("sy daemon add " + folder);
        }
        public static void AddWatchImmediate(string folder)
        {
            ConsoleLauncher.ExecuteCommand("sy daemon add " + folder);
            ConsoleLauncher.ExecuteCommand("sy daemon reload");
        }
        public static void DeleteWatch(string folder)
        {
            ConsoleLauncher.ExecuteCommand("sy daemon remove " + folder);
        }
        public static void DeleteWatchImmediate(string folder)
        {
            ConsoleLauncher.ExecuteCommand("sy daemon remove " + folder);
            ConsoleLauncher.ExecuteCommand("sy daemon reload");
        }
        #endregion

        #region Methods private
        private static List<Watch> ParseWatchList(string[] dumpConsol)
        {
            string[] tab;
            string tmpVal;
            bool header = true;
            Watch currentWatch;
            List<string> headers = new List<string>();
            List<Watch> watchList = new List<Watch>();

            foreach (string row in dumpConsol)
            {
                tab = row.Split('|');
                if (tab.Length >= 3)
                {
                    if (header)
                    {
                        headers = new List<string>();
                        for (int i = 0; i < tab.Length; i++)
                        {
                            tmpVal = tab[i];
                            if (tmpVal.Contains("\r")) tmpVal = tmpVal.Split('\r')[tmpVal.Split('\r').Length - 1];
                            headers.Add(tmpVal.Trim().ToLower());
                        }
                        header = false;
                    }
                    else
                    {
                        currentWatch = new Watch();
                        currentWatch.Id = tab[headers.IndexOf("#")].Replace("\r", string.Empty).Trim();
                        currentWatch.Path = tab[headers.IndexOf("path")].Trim();
                        currentWatch.Enabled = tab[headers.IndexOf("enabled")].Trim().Equals("yes");
                        watchList.Add(currentWatch);
                    }
                }
            }

            return watchList;
        }
        #endregion
    }
}
