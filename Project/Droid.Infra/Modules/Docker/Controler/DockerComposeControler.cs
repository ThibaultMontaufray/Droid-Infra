using Droid.Infra.Modules.Docker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid.Infra.Modules.Docker.Controler
{
    public delegate void DockerComposeControlerEventHandler(string message);

    [Serializable]
    public class DockerComposeControler : Command
    {
        #region Attributes
        public event DockerComposeControlerEventHandler OnImageUpdated;

        private Compose _currentDockerCompose;
        #endregion

        #region Properties
        public Compose CurrentDockerCompose
        {
            get { return _currentDockerCompose; }
            set { _currentDockerCompose = value; }
        }
        public bool Status
        {
            get
            {
                if (_currentDockerCompose == null) { return false; }
                else
                {
                    string result = ExecuteCommand("docker-compose ps");
                    return !result.StartsWith("ERROR");
                }
            }
        }
        #endregion

        #region Constructor
        public DockerComposeControler()
        {

        }
        public DockerComposeControler(string path)
        {
            _currentDockerCompose = new Compose();
            _currentDockerCompose.Path = path;
        }
        #endregion

        #region Methods public
        public void Stop()
        {
            ExecuteCommand("docker-compose stop");
        }
        public void Start()
        {
            ExecuteCommand("docker-compose start");
        }
        public void ReStart()
        {
            ExecuteCommand("docker-compose restart");
        }
        public void Inspect()
        {
            ExecuteCommand("docker-compose config");
        }
        public void Clear()
        {
            ExecuteCommand("docker-compose srm -f");
        }
        public void Build()
        {
            ExecuteCommand("docker-compose up --build");
        }
        public void Up()
        {
            ExecuteCommand("docker-compose up");
        }
        public void Logs()
        {
            ExecuteCommand("docker-compose logs -f --tail 50");
        }
        #endregion

        #region Methods private
        private void RefreshData()
        {
            string result;

            // images
            result = ExecuteCommand("docker-compose images");

            // contrainers
            result = ExecuteCommand("docker-compose ps");

            // version
            result = ExecuteCommand("docker-compose version");
        }
        #endregion

        #region Event
        #endregion 
    }
}
