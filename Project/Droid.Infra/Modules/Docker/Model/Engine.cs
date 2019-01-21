// Log code 120 00

namespace Droid.Infra
{
    using Newtonsoft.Json;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Tools.Utilities;
    using System.Threading.Tasks;
    using Modules.Docker.Controler;

    public delegate void EngineEventHandler(object o);
    public class Engine : Command
    {
        #region Attribute
        public event EngineEventHandler DataRefreshed;

        private DockerComposeControler _currentCompose;
        private List<DockerComposeControler> _dockerComposes;
        private List<Machine> _machines;
        private string _currentMachine;
        private bool _lockLoadingData = false;
        #endregion

        #region Properties
        public List<DockerComposeControler> DockerComposes
        {
            get { return _dockerComposes; }
            set { _dockerComposes = value; }
        }
        public List<Machine> Machines
        {
            get { return _machines; }
            set { _machines = value; }
        }
        public Machine CurrentMachine
        {
            get { return _machines.Where(m => m.Name.Equals(_currentMachine)).FirstOrDefault(); }
            set { _currentMachine = value.Name; }
        }
        public string Status
        {
            get
            {
                return ExecuteCommand("docker-machine status");
            }
        }
        public string Version
        {
            get
            {
                return ExecuteCommand("docker-machine version");
            }
        }
        public string Ip
        {
            get
            {
                return ExecuteCommand("docker-machine ip");
            }
        }
        public DockerComposeControler CurrentCompose
        {
            get { return _currentCompose; }
            set { _currentCompose = value; }
        }
        #endregion

        #region Constructor
        public Engine()
        {
            _dockerComposes = new List<DockerComposeControler>();
            _machines = new List<Machine>();
        }
        #endregion

        #region Methods static
        #endregion

        #region Methods public
        public void RefreshData()
        {
            if (_lockLoadingData) { return; }
            _lockLoadingData = true;

            string cmd = "docker-machine ls";
            DisplayConsolCommand(cmd);
            ParseMachineList(ExecuteCommand(cmd));
            if (_machines.Count > 0) { _currentMachine = _machines[0].Name; }
            else { _machines = null; }
            DataRefreshed?.Invoke(null);

            _lockLoadingData = false;
        }
        public async void RefreshDataAsync()
        {
            await Task.Run(() => RefreshData());
        }
        public void DisplayMachineList()
        {
            ParseMachineList(ExecuteCommand("docker-machine ls"));

            Console.WriteLine("\tDRIVER\tNAME");
            foreach (Machine m in _machines)
            {
                Console.WriteLine(string.Format("\t{0}\t{1}", m.DriverName, m.Name));
            }
        }
        #endregion

        #region Methods private
        private void DisplayMachineConfig()
        {
            Console.WriteLine("Pfiou seriously ? do it yourself !");
        }
        private void ParseMachineList(string dump)
        {
            _machines.Clear();

            string[] line;
            string[] tab = dump.Split('\n');
            for (int i = 1; i < tab.Length; i++)
            {
                if (!string.IsNullOrEmpty(tab[i]))
                {
                    for (int j = 0; j < 10; j++) { tab[i] = tab[i].Replace("  ", " "); }
                    line = tab[i].Split(' ');

                    Machine machine = new Machine();
                    machine.Name = line[0];
                    machine.URL = line.Length > 4 ? line[4] : string.Empty;
                    machine.RefreshDataAsync();
                    _machines.Add(machine);
                }
            }
        }

        private static void DisplayConsolCommand(string cmd)
        {
            ConsoleColor lastColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.WriteLine("# " + cmd);
            System.Console.ForegroundColor = lastColor;        
        }
        #endregion
    }
}
