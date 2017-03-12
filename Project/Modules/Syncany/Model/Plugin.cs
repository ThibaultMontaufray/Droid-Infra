using System;
using System.Collections.Generic;

namespace Droid_Infra
{
    public class Plugin
    {
        #region Attributes
        private string _id;
        private string _name;
        private string _versionLocal;
        private string _type;
        private string _versionRemote;
        private bool _updatable;
        private string _provider;
        #endregion

        #region Properties
        public string Provider
        {
            get { return _provider; }
            set { _provider = value; }
        }
        public bool Updatable
        {
            get { return _updatable; }
            set { _updatable = value; }
        }
        public string VersionRemote
        {
            get { return _versionRemote; }
            set { _versionRemote = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public string VersionLocal
        {
            get { return _versionLocal; }
            set { _versionLocal = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        #endregion

        #region Constructor
        public Plugin()
        {

        }
        #endregion

        #region Methods public
        public static List<Plugin> Parse(List<string> dumpRow)
        {
            List<Plugin> plugins = new List<Plugin>();
            Plugin currentPlugin;
            List<string> headers = null;
            string[] tab;
            string tmpVal;
            bool header = true;

            foreach (string row in dumpRow)
            {
                tab = row.Split('|');
                if (tab.Length >= 7)
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
                        try
                        {
                            currentPlugin = new Plugin();
                            currentPlugin.Id = tab[headers.IndexOf("id")].Replace("\r", string.Empty).Trim();
                            currentPlugin.Name = tab[headers.IndexOf("name")].Trim();
                            currentPlugin.VersionLocal = tab[headers.IndexOf("local version")].Trim();
                            currentPlugin.Type = tab[headers.IndexOf("type")].Trim();
                            currentPlugin.VersionRemote = tab[headers.IndexOf("remote version")];
                            currentPlugin.Updatable = !string.IsNullOrEmpty(tab[headers.IndexOf("updatable")].Trim());
                            currentPlugin.Provider = tab[headers.IndexOf("provided by")].Trim();

                            plugins.Add(currentPlugin);
                        }
                        catch (Exception exp)
                        {
                            Tools4Libraries.Log.Write("[ ERR 0000 ] Generic : " + exp.Message);
                        }
                    }
                }
            }
            return plugins;
        }
        #endregion

        #region Methods private
        #endregion
    }
}
