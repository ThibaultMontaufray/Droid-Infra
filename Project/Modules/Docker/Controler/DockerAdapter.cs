namespace Droid_Infra
{
    public class DockerAdapter : InfraAdapteur
    {
        #region Attribute
        private Boot2Docker _docker;
        #endregion

        #region Properties
        public Boot2Docker Docker
        {
            get { return _docker; }
            set { _docker = value; }
        }
        #endregion

        #region Constructor
        public DockerAdapter()
        {
            _docker = new Boot2Docker();
        }
        #endregion

        #region Methods public
        #region ACTIONS
        public static void ACTION_lancer_docker_130()
        {
            ViewDocker ddp = new ViewDocker();
            //ddp.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            //ddp.ShowDialog();
        }
        #endregion

        public void GlobalAction(string action)
        {
            switch (action)
            {
                case "initialisation":
                    LaunchInitDocker();
                    break;
                case "status":
                    LaunchStatus();
                    break;
                case "start":
                    LaunchStart();
                    break;
                case "stop":
                    LaunchStop();
                    break;
            }
        }
        #endregion

        #region Methods private
        private void LaunchInitDocker()
        {
            _docker.Init();
        }
        private void LaunchStatus()
        {
            _docker.RefreshStatus();
        }
        private void LaunchStart()
        {
            _docker.Start();
        }
        private void LaunchStop()
        {
            _docker.Stop();
        }
        #endregion
    }
}