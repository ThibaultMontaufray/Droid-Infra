using System.Windows.Forms;

namespace Droid.Infra.UI
{
    public partial class GitHubGUI : Form
    {
        #region Attribute
        private GitHubAdapter _gitHubAdapt;
        #endregion

        #region Properties
        public GitHubAdapter GitHubAdapt
        {
            get { return _gitHubAdapt; }
            set { _gitHubAdapt = value; }
        }
        #endregion

        #region Constructor
        public GitHubGUI()
        {
            //GitHubIssue.ShowDialog("ThibaultMontaufray", "pouey!", new System.Collections.Generic.List<string>() { "Explorer", "Video", "Images", "Audio", "Communication", "Deployer", "Calendar", "Litterature", "Weather" });
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        private void Init()
        {
            _gitHubAdapt = new GitHubAdapter();
            _gitHubAdapt.StatusChanged += _gitHubAdapt_StatusChanged;
            _gitHubLogger.GitHubAdapter = _gitHubAdapt;
        }
        #endregion

        #region Event
        private void _gitHubAdapt_StatusChanged()
        {
            _gitHubUserDetail.Visible = true;
            _gitHubLogger.Visible = false;
        }
        #endregion
    }
}
