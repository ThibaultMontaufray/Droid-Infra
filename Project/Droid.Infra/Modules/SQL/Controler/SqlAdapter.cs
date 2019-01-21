namespace Droid.Infra
{
    using RestSharp;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SqlAdapter : InfraAdapter
    {
        #region Attribute
        private string _login;
        private string _password;
        #endregion

        #region Properties
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
        #endregion

        #region Constructor
        public SqlAdapter()
        {
            _type = AdapterType.SqlAdapter;
        }
        public SqlAdapter(InterfaceInfra intInfra)
        {
            _parent = intInfra;
            _type = AdapterType.SqlAdapter;
        }
        public SqlAdapter(InterfaceInfra intInfra, string login, string password, string url)
        {
            _parent = intInfra;
            _type = AdapterType.SqlAdapter;
            _url = url;
            _login = login;
            _password = password;
        }
        #endregion

        #region Methods public
        public override void GoAction(string action)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Methods private
        protected override string BuildPanelCustom()
        {
            string html = string.Format(MONITORINGHTML, Online ? "componentOnline" : "componentOffline", "id123", "styleposition", (string.IsNullOrEmpty(_name) ? _techno.ToString() : _name));
            return html;
        }
        #endregion
    }
}
