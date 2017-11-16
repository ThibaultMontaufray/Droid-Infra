namespace Droid_Infra
{
    using RestSharp;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SqlAdapter : InfraAdapteur
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
        }
        public SqlAdapter(string login, string password, string url)
        {
            _url = url;
            _login = login;
            _password = password;
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        #endregion
    }
}
