﻿using Atlassian.Stash;
//using Bitbucket.Net;
//using Bitbucket.Net.Models.Core.Projects;
//using Bitbucket.Net.Models.Core.Users;
using Droid.Infra.Modules.Bitbucket.Controler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CodeBucket.Client;

namespace Droid.Infra
{
    public delegate void BitbucketAdapterEventHandler(object o);
    public class BitbucketAdapter : InfraAdapter
    {
        #region Attributes
        public event BitbucketAdapterEventHandler ConnectionChanged;

        private BitbucketClient _client;
        private ClientCommit _clientCommit;
        private RepoClient _clientRepo;

        private List<Repository> _repositories;
        private List<CodeBucket.Client.V1.GitReference> _branches;
        private List<Commit> _commits;
        private Repository _currentRepo;
        private User _currentTeam;
        private CodeBucket.Client.V1.GitReference _currentBranch;
        #endregion

        #region Properties
        public List<Commit> Commits
        {
            get { return _commits; }
            set { _commits = value; }
        }
        public List<CodeBucket.Client.V1.GitReference> Branches
        {
            get { return _branches; }
            set { _branches = value; }
        }
        public List<Repository> Repositories
        {
            get { return _repositories; }
            set { _repositories = value; }
        }
        [XmlIgnore]
        public BitbucketClient Client
        {
            get { return _client; }
            set { _client = value; }
        }
        public Repository CurrentRepo
        {
            get { return _currentRepo; }
            set { _currentRepo = value; }
        }
        public User CurrentTeam
        {
            get { return _currentTeam; }
            set { _currentTeam = value; }
        }
        [XmlIgnore]
        public User CurrentUser
        {
            get
            {
                if (_client != null) { return _client.Users.GetCurrent().Result; }
                return null;
            }

        }
        [XmlIgnore]
        public Collection<User> Watchers
        {
            get
            {
                if (_client != null) { return _client.Repositories.GetWatchers(_currentTeam.Username, _currentRepo.Name).Result; }
                return null;
            }
        }
        [XmlIgnore]
        public Collection<User> Teams
        {
            get
            {
                if (_client != null) { return _client.Teams.GetAll().Result; }
                return null;
            }

        }
        [XmlIgnore]
        public override bool Online
        {
            get
            {
                try
                {
                    Task t = Task.Run(() => {
                        Connect();
                    });
                    TimeSpan ts = TimeSpan.FromMilliseconds(7000);
                    if (!t.Wait(ts))
                    {
                        return false;
                    }
                    else
                    {
                        return _client?.Users.GetCurrent().Result != null;
                    }
                }
                catch
                {
                    return false;
                }
            }
        }
        #endregion

        #region Constructor
        public BitbucketAdapter()
        {
            _techno = TECHNO.BITBUCKET;
            _type = AdapterType.BitbucketAdapter;
            Init();
        }
        public BitbucketAdapter(InterfaceInfra intInf)
        {
            _techno = TECHNO.BITBUCKET;
            _type = AdapterType.BitbucketAdapter;
            _parent = intInf;
            Init();
        }
        #endregion

        #region Methods public
        public new void RefreshData()
        {
            try
            {
                if (_client == null) { Connect(); }
                RefreshVisibleRepositories();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public override void GoAction(string action)
        {
            switch (action)
            {
                case "manage":
                    LaunchManage();
                    break;
                case "connection":
                    LaunchConnect();
                    break;
                case "add":
                    LaunchAdd();
                    break;
                case "createbranch":
                    LaunchCreateBranch();
                    break;
                case "setting":
                    LaunchSetting();
                    break;
            }
        }
        public void Connect(string login = null, string pwd = null)
        {
            if (!string.IsNullOrEmpty(login)) { _login = login; }
            if (!string.IsNullOrEmpty(pwd)) { _password = pwd; }
            
            if (!string.IsNullOrEmpty(_login) && !string.IsNullOrEmpty(_password))
            {
                _client = BitbucketClient.WithBasicAuthentication(_login, _password);
                _clientCommit = new ClientCommit(_client);
                _clientRepo = new RepoClient(_client);
            }
            ConnectionChanged?.Invoke(null);
        }
        public void RefreshAllRepo()
        {
            try
            {
                if (Teams?.Values?.Count > 0) _currentTeam = Teams.Values.First();
                _branches = _clientRepo.GetBranches(_currentRepo.Owner.Username, _currentRepo.Name).ToList();
                _currentBranch = _branches.Where(b => b.Name == _clientRepo.GetPrimaryBranch(_currentRepo.Owner.Username, _currentRepo.Name).Result.Name).FirstOrDefault();
                _commits = _client.Commits.GetAll(_currentTeam.Username, _currentRepo.Name, _currentBranch.Name).Result.Values;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
        public List<Commit> GetCommits(Repository repository, string branch)
        {
            return _clientCommit.GetAll(repository.Owner.Username, repository.Name, branch).Result.Values;
        }
        public void RefreshRepo(string repo)
        {

        }
        public void CreateBranch(string branch, Commit commit, string name)
        {
            // hg branch BRANCHNAME
            // create branch

        }
        public void Push()
        {

        }
        public CodeBucket.Client.V1.Changeset GetCommitDetail(Commit commit)
        {
            return _clientCommit.GetChangeset(_currentRepo.Owner.Username, _currentRepo.Name, commit.Hash).Result;
        }
        public void SwitchRepository(string respository)
        {
            try
            {
                _branches = _clientRepo.GetBranches(_currentRepo.Owner.Username, _currentRepo.Name).ToList();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
        public void SwitchBranch(string branch)
        {
            // first change dir
            // command hg up TEST
            // command hg update TEST
            // changer de branche
            try
            {
                _commits = _client.Commits.GetAll(_currentTeam.Username, _currentRepo.Name, branch).Result.Values;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
        protected override string BuildPanelCustom()
        {
            RefreshData();
            string html = string.Format(MONITORINGHTML, Online ? "componentOnline" : "componentOffline", "id123", "styleposition", (string.IsNullOrEmpty(_name) ? _techno.ToString() : _name));

            string detail = "<li>&nbsp;</li>";
            detail += "<li>Repo : " + _repositories?.Count + "</li>";
            if (_repositories != null)
            {
                foreach (var item in _repositories)
                {
                    if (item != null)
                    {
                        detail += string.Format("<li> - {0} : {1}</li>", item.Owner?.Username, item.Name);
                    }
                }
            }
            return html.Replace("<li>&nbsp;</li>", detail);
        }
        #endregion

        #region Methods private
        private void Init()
        {
            //try
            //{
            //    var v = CommandHg.HgVersion;
            //    var v1 = CommandHg.Pull(@"D:\Professionnel\2017_BIM&CO\Bitbucket\Docker");
            //}
            //catch (Exception exp)
            //{
            //    Console.WriteLine(exp.Message);
            //}


            _repositories = new List<Repository>();
            _commits = new List<Commit>();
            _branches = new List<CodeBucket.Client.V1.GitReference>();
            RefreshData();
        }
        private void RefreshVisibleRepositories()
        {
            if (_client != null)
            {
                foreach (var team in Teams.Values)
                {
                    if (_repositories == null) { _repositories = new List<Repository>(); }
                    var repoVisible = _client.Repositories.GetAllForUser(team.Username).Result;
                    foreach (var repo in repoVisible.Values)
                    {
                        if (_repositories.Where(r => r.FullName.Equals(repo.FullName)).Count() == 0)
                        {
                            _repositories.Add(repo);
                        }
                    }
                }
            }
        }
        private void LaunchAdd()
        {
            if (!Online) { Connect(); }
            if (_client == null || !Online) { LaunchConnect(); }
        }
        private void LaunchManage()
        {
            if (!Online) { Connect(); }
            if (_client == null || !Online) { LaunchConnect(); }
            else
            {
                RefreshData();
            }
        }
        private void LaunchConnect()
        {
        }
        private void LaunchSetting()
        {
            if (_client == null) { LaunchConnect(); }
        }
        private void LaunchCreateBranch()
        {
            if (_client == null) { LaunchConnect(); }
        }
        #endregion

        #region Event
        private void _viewAddRepo_CreationRequested()
        {
            _parent.Save();
            LaunchManage();
        }
        private void _viewLogin_ConnectionRequest(object o)
        {
            _parent.Save();
            string[] arg = (string[])o;
            if (arg.Length > 1)
            {
                Connect(arg[0], arg[1]);
            }
        }
        #endregion
    }
}
