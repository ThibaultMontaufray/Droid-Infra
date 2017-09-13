using SharpBucket.V1;
using SharpBucket.V1.EndPoints;
using SharpBucket.V1.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools4Libraries;

namespace Droid_Infra
{
    public delegate void BitbucketAdapterEventHandler(object o);
    public class BitbucketAdapter : InfraAdapteur
    {
        #region Attributes
        public event ViewBitBucketLoginEventHandler ConnectionChanged;

        private SharpBucketV1 _sharpbucket;
        private UserEndPoint _userEndPoint;
        private List<Repository> _repo;
        private UserInfo _info;
        
        private string _login;
        private string _password;
        #endregion

        #region Properties
        public User CurrentUser
        {
            get
            {
                if (_info != null) { return _info.user; }
                return null;
            }

        }
        public List<Repository> Repositories
        {
            get { return _repo; }
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
        public SharpBucketV1 SharpBucket
        {
            get { return _sharpbucket; }
            set { _sharpbucket = value; }
        }
        public bool Connected
        {
            get
            {
                if (_sharpbucket != null)
                {
                    return _repo != null;
                }
                return false;
            }
        }
        #endregion

        #region Constructor
        public BitbucketAdapter()
        {
            _repo = new List<Repository>();
            _sharpbucket = new SharpBucketV1();
            _login = Params.BitbucketLogin;
            _password = Params.BitbucketPassword;






            //// your main entry to the Bitbucket API, this one is for V1
            //var sharpBucket = new SharpBucketV1();
            //// authenticate with OAuth keys
            ////sharpBucket.OAuth2LeggedAuthentication("thibault.montaufray@hotmail.fr", "Androi7\"");
            //sharpBucket.BasicAuthentication("thibault.montaufray@hotmail.fr", "Androi7\"");

            //// getting the User end point
            //var userEndPoint = sharpBucket.UserEndPoint();
            //// querying the Bitbucket API for various info
            //var _info = userEndPoint.GetInfo();
            //var privileges = userEndPoint.ListPrivileges();
            //var follows = userEndPoint.ListFollows();
            //var userRepos = userEndPoint.ListRepositories();

            //// getting the Repository end point
            //var repositoryEndPoint = sharpBucket.RepositoriesEndPoint("tmontaufray", "https://bitbucket.org/tmontaufray/repotest/");
            //// getting the Issue resource for this specific repository
            //var issuesResource = repositoryEndPoint.IssuesResource();
            //// getting the list of all the issues of the repository
            //var issues = issuesResource.ListIssues();
        }
        #endregion

        #region Methods public
        public void Connect(string login = null, string pwd = null)
        {
            if (!string.IsNullOrEmpty(login)) { _login = login; }
            if (!string.IsNullOrEmpty(pwd)) { _password = pwd; }
            
            Tools4Libraries.Params.BitbucketLogin = _login;
            Tools4Libraries.Params.BitbucketPassword = _password;

            if (!string.IsNullOrEmpty(_login) && !string.IsNullOrEmpty(_password))
            { 
                _sharpbucket.BasicAuthentication(_login, _password);
                _userEndPoint = _sharpbucket.UserEndPoint();
                _repo = _userEndPoint.ListRepositories();
                _info = _userEndPoint.GetInfo();
            }
            if (ConnectionChanged != null) { ConnectionChanged(null); }
        }
        #endregion

        #region Methods private
        #endregion

        #region Event
        #endregion
    }
}
