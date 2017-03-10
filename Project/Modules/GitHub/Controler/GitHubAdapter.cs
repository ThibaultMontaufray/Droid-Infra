// Log 00 - 02

using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Droid_Infra
{
    public delegate void GitHubAdapterEventHandler();
    public class GitHubAdapter
    {
        #region Attribute
        public event GitHubAdapterEventHandler StatusChanged;
        public event GitHubAdapterEventHandler ConnectionFailled;

        private bool _isLoggedIn;
        private Octokit.User _currentUser;
        private GitHubClient _client;
        private string _user;
        private string _repoUser;
        private string _password;
        #endregion

        #region Properties
        public string RepoUser
        {
            get { return _repoUser; }
            set { _repoUser = value; }
        }
        public bool IsLoggedIn
        {
            get { return _isLoggedIn; }
        }
        public Octokit.User CurrentUser
        {
            get { return _currentUser; }
        }
        #endregion

        #region Constructor
        public GitHubAdapter()
        {
            _isLoggedIn = false;
        }
        public GitHubAdapter(string user, string pwd, string url = "https://github.com")
        {
            try
            {
                _user = user;
                _password = pwd;
                var ghe = new Uri(url);
                _client = new GitHubClient(new ProductHeaderValue("Droid-Infra"), ghe);
                var basicAuth = new Credentials(user, pwd);
                _client.Credentials = basicAuth;

                _isLoggedIn = true;
                if (StatusChanged != null) { StatusChanged(); }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                if (ConnectionFailled != null)
                {
                    ConnectionFailled();
                }
            }
        }
        #endregion

        #region Methods public
        public async void LogUser(string user, string pwd, string url = "https://github.com")
        {
            try
            {
                _user = user;
                _password = pwd;
                var ghe = new Uri(url);
                _client = new GitHubClient(new ProductHeaderValue("Droid-Infra"), ghe);
                var basicAuth = new Credentials(user, pwd);
                _client.Credentials = basicAuth;

                if (StatusChanged != null)
                {
                    StatusChanged();
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                if (ConnectionFailled != null)
                {
                    ConnectionFailled();
                }
            }
        }
        public bool PublishIssue(string repoName, string title, string body)
        {
            try
            {
                if ("Droid-Autre".Equals(repoName))
                {
                    repoName = "Server";
                }
                if (_client != null && _isLoggedIn)
                {
                    Repository repo = GetRepo(repoName);
                    if (repo != null)
                    {
                        NewIssue issue = new NewIssue(title);
                        issue.Body = body;
                        _client.Issue.Create(repo.Id, issue);
                        return true;
                    }
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            return false;
        }
        public void LogOff()
        {
            _client = null;
        }
        public IReadOnlyList<Repository> GetUserRepo()
        {
            try
            {
                if (_client != null && _isLoggedIn)
                {
                    string repoUser = string.IsNullOrEmpty(_repoUser) ? _user : _repoUser;
                    Task<IReadOnlyList<Octokit.Repository>> getRepoList = null;
                    Task.Run(() => getRepoList = _client.Repository.GetAllForUser(repoUser)).Wait();

                    return getRepoList.Result;
                }
            }
            catch (Exception exp)
            {
                Tools4Libraries.Log.Write("[ ERR 0000 ] Error getting user repository : " + exp.Message);
            }
            return null;
        }
        public List<Repository> GetRepos(string filter)
        {
            List<Repository> repos = new List<Repository>();
            try
            {
                IReadOnlyList<Repository> userRepo = GetUserRepo();
                if (userRepo != null) { return userRepo.Where(r => r.Name.Contains(filter)).ToList(); }
            }
            catch (Exception exp)
            {
                Tools4Libraries.Log.Write("[ ERR 0001 ] Error getting user repositories : " + exp.Message);
            }
            return repos;
        }
        public Repository GetRepo(string repoName)
        {
            try
            {
                IReadOnlyList<Repository> userRepo = GetUserRepo();
                if (userRepo != null && userRepo.Count > 0)
                {
                    var lstRepo = userRepo.Where(r => r.Name.Equals(repoName)).ToList();
                    if (lstRepo != null && lstRepo.Count > 0) return lstRepo[0];
                }
            }
            catch (Exception exp)
            {
                Tools4Libraries.Log.Write("[ ERR 0002 ] Error getting user particular repository : " + exp.Message);
            }
            return null;
        }
        #endregion

        #region Methods private
        #endregion
    }
}