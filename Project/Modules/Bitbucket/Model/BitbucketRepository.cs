using SharpBucket.V1.EndPoints;
using SharpBucket.V1.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid_Infra
{
    public class BitbucketRepository
    {
        #region Attribute
        private BitbucketAdapter _bitbucketAdapter;
        private string _account;
        private string _link;
        private RepositoriesEndPoint _endPoint;
        private IssuesResource _issuesResource;
        private IssuesInfo _issuesInfo;
        #endregion

        #region Properties
        public string Link
        {
            get { return _link; }
            set { _link = value; }
        }
        public string Account
        {
            get { return _account; }
            set { _account = value; }
        }
        public List<Issue> Issues
        {
            get { return _issuesInfo != null ? _issuesInfo.issues : null; }
        }
        #endregion

        #region Constructor
        public BitbucketRepository(BitbucketAdapter adapter, string account, string link)
        {
            _bitbucketAdapter = adapter;
            _account = account;
            _link = link;

        }
        #endregion

        #region Methods public
        public void LoadRepo(string account=null, string link=null)
        {
            if (!string.IsNullOrEmpty(account)) { _account = account; }
            if (!string.IsNullOrEmpty(link)) { _link = link; }

            _endPoint = _bitbucketAdapter.SharpBucket.RepositoriesEndPoint(_account, _link);
            _issuesResource = _endPoint.IssuesResource();
            _issuesInfo = _issuesResource.ListIssues();
        }
        #endregion

        #region Methods private
        #endregion

        #region Event
        #endregion
    }
}
