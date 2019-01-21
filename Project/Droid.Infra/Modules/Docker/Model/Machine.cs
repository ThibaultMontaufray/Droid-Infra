using Docker.DotNet;

namespace Droid.Infra
{
    using global::Docker.DotNet.Models;
    using Modules.Docker.Controler;
    using Modules.Docker.Model;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Tools.Utilities;

    public delegate void MachineEventHandler();

    [Serializable]
    public class Machine : Command
    {
        #region Attribute
        public event MachineEventHandler MachineUpdated;
        
        private string _name;
        private Driver _driver;
        private string _configVersion;
        private string _driverName;
        private string _storePath;
        private Host _host;
        //private Swarm _swarm;
        //private Engine _engine;
        //private string _state;
        private string _url;
        private bool _lockLoadingData = false;
        private List<Container> _containers;
        private List<Image>_images;
        private List<Modules.Docker.Model.Network> _networks;
        #endregion

        #region Properties
        [JsonProperty("URL")]
        public string URL
        {
            get { return _url; }
            set { _url = value; }
        }
        public string State
        {
            get
            {
                return string.IsNullOrEmpty(_name) ? string.Empty : ExecuteCommand("docker-machine status " + _name).Replace("\n", string.Empty);
            }
        }
        public string Name
        {
            get 
            {
                //if (_driver != null) return _driver.Name;
                //else
                return _name; 
            }
            set
            {
                _name = value;
            }
        }
        [JsonProperty("HostOptions")]
        public Host Host
        {
            get { return _host; }
            set { _host = value; }
        }
        [JsonProperty("StorePath")]
        public string StorePath
        {
            get { return _storePath; }
            set { _storePath = value; }
        }
        [JsonProperty("DriverName")]
        public string DriverName
        {
            get { return _driverName; }
            set { _driverName = value; }
        }
        [JsonProperty("ConfigVersion")]
        public string ConfigVersion
        {
            get { return _configVersion; }
            set { _configVersion = value; }
        }
        [JsonProperty("Driver")]
        public Driver Driver
        {
            get { return _driver; }
            set { _driver = value; }
        }
        public List<Modules.Docker.Model.Network> Networks
        {
            get { return _networks; }
        }
        public List<Container> Containers
        {
            get { return _containers; }
        }
        public List<Image> Images
        {
            get { return _images; }
        }
        #endregion

        #region Constructor
        public Machine()
        {
            _containers = new List<Container>();
            _images = new List<Image>();
            _networks = new List<Modules.Docker.Model.Network>();
            _driver = new Driver();
        }
        #endregion

        #region Methods public
        public void RefreshData()
        {
            if (_lockLoadingData) { return; }
            _lockLoadingData = true;

            if (!string.IsNullOrEmpty(_name))
            {
                RefreshInspect();
                GetImages();
                GetContainers();
                GetNetworks();
                MachineUpdated?.Invoke();
            }

            _lockLoadingData = false;
        }
        public async void RefreshDataAsync()
        {
            await Task.Run(() => RefreshData());
        }
        public void Create()
        {
            if (!string.IsNullOrEmpty(_name))
            {
                string cmd = "docker-machine create --driver virtualbox " + _name;
                DisplayConsolCommand(cmd);
                string result = ExecuteCommand(cmd);
                System.Console.WriteLine(result);
            }
        }
        public void Delete()
        {
            string cmd = string.Format("docker-machine rm {0} -f", _name);
            DisplayConsolCommand(cmd);
            string result = ExecuteCommand(cmd);
            System.Console.WriteLine(result);
        }
        public void RegenerateCert()
        {
            string cmd = "set DOCKER_HOST= " + _url + " & ";
            cmd += string.Format("docker-machine regenerate-certs {0} -f ", _name);
            DisplayConsolCommand(cmd);
            string result = ExecuteCommand(cmd);
            System.Console.WriteLine(result);
        }
        public void DisplayEnvVar()
        {
            string cmd = "set DOCKER_HOST= " + _url + " & ";
            cmd += string.Format("docker-machine env {0} ", _name);
            DisplayConsolCommand(cmd);
            string result = ExecuteCommand(cmd);
            System.Console.WriteLine(result);
        }
        public void Kill()
        {
            string cmd = "set DOCKER_HOST= " + _url + " & ";
            cmd += "docker-machine kill " + _name;
            DisplayConsolCommand(cmd);
            string result = ExecuteCommand(cmd);
            System.Console.WriteLine(result);
        }
        public void Start()
        {
            string cmd = "set DOCKER_HOST= " + _url + " & ";
            cmd += "docker-machine start " + _name;
            DisplayConsolCommand(cmd);
            string result = ExecuteCommand(cmd);
            System.Console.WriteLine(result);
        }
        public void Stop()
        {
            string cmd = "set DOCKER_HOST= " + _url + " & ";
            cmd += "docker-machine stop " + _name;
            DisplayConsolCommand(cmd);
            string result = ExecuteCommand(cmd);
            System.Console.WriteLine(result);
        }
        public string InspectContainer(Container container)
        {
            string cmd = "set DOCKER_HOST= " + _url + " & ";
            cmd += "docker container inspect " + container.Id;
            DisplayConsolCommand(cmd);
            return ExecuteCommand(cmd);
        }
        public string InspectImage(Image image)
        {
            string cmd = "set DOCKER_HOST= " + _url + " & ";
            cmd += "docker image inspect " + image.Id;
            DisplayConsolCommand(cmd);
            return ExecuteCommand(cmd);
        }
        public string InspectNetwork(Droid.Infra.Modules.Docker.Model.Network network)
        {
            string cmd = "set DOCKER_HOST= " + _url + " & ";
            cmd += "docker network inspect " + network.Id;
            DisplayConsolCommand(cmd);
            return ExecuteCommand(cmd);
        }

        public DockerClientConfiguration GetConfig()
        {
            var client = GetClient();
            return client?.Configuration;
        }
        #endregion

        #region Methods private
        private static void DisplayConsolCommand(string cmd)
        {
            ConsoleColor lastColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.WriteLine("# " + cmd);
            System.Console.ForegroundColor = lastColor;
        }
        private void RefreshInspect()
        {
            string result;
            Machine tmpMachine = null;
            try
            {
                result = ExecuteCommand("docker-machine inspect " + _name);
                tmpMachine = JsonConvert.DeserializeObject<Machine>(result);

                _name = tmpMachine._name;
                _driver = tmpMachine._driver;
                _host = tmpMachine._host;
                if (tmpMachine.State == "Running") { _url = tmpMachine.Driver.IP + ":2376"; }
                else { _url = string.Empty; }
                _configVersion = tmpMachine._configVersion;
                
            }
            catch (Exception exp12000)
            {
                Log.Write("[ ERR : 12000 ] Cannot load the virtual machine.\n" + exp12000.Message);
            }
        }
        private async Task<IList<ContainerListResponse>> GetContainerNewWay()
        {
            try
            {
                var client = GetClient();
                return await client?.Containers.ListContainersAsync(
                        new ContainersListParameters()
                        {
                            Limit = 10
                        });
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message + " | " + exp.InnerException);
                return null;
            }
        }

        private DockerClient GetClient()
        {
            try
            {
                if (_name != null && _driver != null)
                {
                    return new DockerClientConfiguration(new Uri(string.Format("http://{0}:{1}", _driver.IP, _driver.SshPort))).CreateClient();
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message + " | " + exp.InnerException);
            }
            return null;
        }
        private List<Image> GetImages()
        {
            _images = new List<Image>();

            if (!string.IsNullOrEmpty(_url))
            {
                string cmd = "set DOCKER_HOST= " + _url + " & ";
                cmd += "docker image ls --no-trunc";
                var dump = ExecuteCommand(cmd);

                string[] line;
                string[] tab = dump.Split('\n');
                for (int i = 1; i < tab.Length; i++)
                {
                    if (!string.IsNullOrEmpty(tab[i]))
                    {
                        tab[i] = tab[i].Replace("  ", ";");
                        tab[i].Trim();
                        for (int j = 0; j < 10; j++) { tab[i] = tab[i].Replace(";;", ";"); }
                        line = tab[i].Split(';');

                        Image dockerImage = new Image(line);
                        if (dockerImage != null) { _images.Add(dockerImage); }
                    }
                }
            }
            return _images;
        }
        private List<Container> GetContainers()
        {
            _containers = new List<Container>();

            if (!string.IsNullOrEmpty(_url))
            {
                string cmd = "set DOCKER_HOST= " + _url + " & ";
                cmd += "docker container ls --no-trunc -s -a";
                var dump = ExecuteCommand(cmd);

                string[] line;
                string[] tab = dump.Split('\n');
                for (int i = 1; i < tab.Length; i++)
                {
                    if (!string.IsNullOrEmpty(tab[i]))
                    {
                        tab[i] = tab[i].Replace("  ", ";");
                        tab[i].Trim();
                        for (int j = 0; j < 10; j++) { tab[i] = tab[i].Replace(";;", ";"); }
                        line = tab[i].Split(';');

                        Container dockerContainer = new Container(line);
                        if (dockerContainer != null) { _containers.Add(dockerContainer); }
                    }
                }
            }
            return _containers;
        }
        private List<Modules.Docker.Model.Network> GetNetworks()
        {
            _networks = new List<Modules.Docker.Model.Network>();

            if (!string.IsNullOrEmpty(_url))
            {
                string cmd = "set DOCKER_HOST= " + _url + " & ";
                cmd += "docker network ls --no-trunc";
                var dump = ExecuteCommand(cmd);

                string[] line;
                string[] tab = dump.Split('\n');
                for (int i = 1; i < tab.Length; i++)
                {
                    if (!string.IsNullOrEmpty(tab[i]))
                    {
                        tab[i] = tab[i].Replace("  ", ";");
                        tab[i].Trim();
                        for (int j = 0; j < 10; j++) { tab[i] = tab[i].Replace(";;", ";"); }
                        line = tab[i].Split(';');

                        Modules.Docker.Model.Network dockerNetwork = new Modules.Docker.Model.Network(line);
                        if (dockerNetwork != null) { _networks.Add(dockerNetwork); }
                    }
                }
            }
            return _networks;
        }
        #endregion
    }
}
