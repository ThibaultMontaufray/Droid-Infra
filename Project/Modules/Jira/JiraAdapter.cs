namespace Droid_Infra
{
    using Atlassian.Jira;
    using RestSharp;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class JiraAdapter : InfraAdapteur
    {
        #region Attribute
        private Jira _jira;
        private string _login;
        private string _password;
        private string _url;

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

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
        public JiraAdapter()
        {
        }
        public JiraAdapter(string login, string password, string url)
        {
            _url = url;
            _login = login;
            _password = password;
            _jira = Jira.CreateRestClient(_url, _login, _password);

            //CreateIssue("Issue test summary");
            //DeleteIssue("DEM-4");
            CreateProject();
        }
        #endregion

        #region Methods public
        public void CreateIssue(string name)
        {
            var issue = _jira.CreateIssue("DEM");
            issue.Type = "Récit";
            issue.Summary = name;
            //string epicname = "DEMTable Sprint 1";
            //issue.CustomFields.Add("Sprint", epicname);
            issue.SaveChanges();
        }
        public void DeleteIssue(string id)
        {
            Issue issue = _jira.GetIssue(id);
            if (issue != null) _jira.DeleteIssue(issue);
        }
        #endregion

        #region Methods private
        private void CreateProject()
        {
            var request = CreateRequest(Method.POST, "project");
            request.AddHeader("ContentType", "application/json");
            var issueData = new Dictionary<string, object>();
            issueData.Add("project", new { key = "JIRA", name = "Test2", projectTypeKey = "software", description = "Testing" });
            request.AddBody(new { fields = issueData });
            var response = ExecuteRequest(request);
        }
        private RestRequest CreateRequest(Method method, String path)
        {
            var request = new RestRequest { Method = method, Resource = path, RequestFormat = DataFormat.Json };
            request.AddHeader("Authorization", "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(String.Format("{0}:{1}", _login, _password))));
            return request;
        }
        private IRestResponse ExecuteRequest(RestRequest request)
        {
            var baseApiUrl = new Uri(new Uri(_url), "rest/api/2/project").ToString();
            var client = new RestClient(baseApiUrl);
            return client.Execute(request);
        }
        private void TestAll()
        {
            var issue = _jira.CreateIssue("DEM");
            var v1 = _jira.GetCustomFields();
            var v2 = _jira.GetIssue("DEM-1");
            var v3 = _jira.GetProjectComponents("DEM");

            issue.Type = "Récit";
            issue.Summary = "Test Summary1";
            string epicname = "DEMTable Sprint 1";
            issue.CustomFields.Add("Sprint", epicname);
            issue.SaveChanges();
        }
        #endregion
    }
}
