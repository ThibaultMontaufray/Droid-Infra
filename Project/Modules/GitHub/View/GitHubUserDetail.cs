using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using Tools4Libraries;

namespace Droid_Infra
{
    public partial class GitHubUserDetail : UserControlCustom
    {
        #region Attribute
        public override event UserControlCustomEventHandler HeightChanged;

        private Interface_infra _intInf;
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public GitHubUserDetail()
        {
            InitializeComponent();
        }
        public GitHubUserDetail(Interface_infra intInf)
        {
            _intInf = intInf;
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public override void RefreshData()
        {
            if (_intInf.GitHubAdapter != null && _intInf.GitHubAdapter.CurrentUser != null)
            {
                labelUserName.Text = _intInf.GitHubAdapter.CurrentUser.Name;
                labelInfoRepository.Text = string.Format("Repositories [{0}]", _intInf.GitHubAdapter.CurrentUser.PublicRepos);
                labelInfoFollower.Text = string.Format("Followers [{0}]", _intInf.GitHubAdapter.CurrentUser.Followers);
                labelInfoFollowing.Text = string.Format("Following [{0}]", _intInf.GitHubAdapter.CurrentUser.Following);
                labelUserLocation.Text = "From : " + _intInf.GitHubAdapter.CurrentUser.Location;
                labelUserArrival.Text = "Insciption : " + _intInf.GitHubAdapter.CurrentUser.CreatedAt.ToString("dd/MM/yyyy hh:mm:ss");

                var request = WebRequest.Create(_intInf.GitHubAdapter.CurrentUser.AvatarUrl);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    pictureBoxAvatar.Image = Bitmap.FromStream(stream);
                }
            }
        }
        public override void ChangeLanguage()
        {

        }
        #endregion

        #region Methods private
        private void Init()
        {

        }
        #endregion

        #region Event
        private void buttonLogOff_Click(object sender, EventArgs e)
        {
            _intInf.GitHubAdapter.LogOff();
        }
        #endregion
    }
}
