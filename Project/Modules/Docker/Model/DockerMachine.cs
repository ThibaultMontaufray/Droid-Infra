// Log code 120 00

namespace Droid_Infra
{
    using Newtonsoft.Json;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Tools4Libraries;

    public class DockerMachine : Command
    {
        #region Attribute
        private List<Machine> _machines;
        #endregion

        #region Properties
        public List<Machine> Machines
        {
            get { return _machines; }
            set { _machines = value; }
        }
        #endregion

        #region Constructor
        public DockerMachine()
        {
            _machines = new List<Machine>();
            //LoadMachines();
        }
        #endregion

        #region Methods static
        #endregion

        #region Methods public
        public void LoadMachines()
        {
            string cmd = "docker-machine ls";
            DisplayConsolCommand(cmd);
            ParseMachineList(ExecuteCommand(cmd));
        }
        public void RefreshDetails(string machineName)
        {
            if (!string.IsNullOrEmpty(machineName))
            {
                List<Machine> mchn = _machines.Where(m => machineName.Equals(m.Name)).ToList();
                if (mchn != null) _machines[_machines.IndexOf(mchn[0])] = RefreshInspect(machineName);
                else _machines.Add(RefreshInspect(machineName));
                ParseMachineList(ExecuteCommand("docker-machine ls"));
            }
        }
        public void Create(string machineName)
        {
            if (!string.IsNullOrEmpty(machineName))
            {
                List<Machine> mchn = _machines.Where(m => machineName.Equals(m.Name)).ToList();
                if (mchn != null && mchn.Count > 0) return;
                
                string cmd = "docker-machine create --driver virtualbox " + machineName;
                DisplayConsolCommand(cmd);
                string result = ExecuteCommand(cmd);
                System.Console.WriteLine(result);

                _machines.Add(RefreshInspect(machineName));
            }
        }
        public void Delete(string machineName)
        {
            _machines.RemoveAll(m => m.Name.Equals(machineName));

            string cmd = "docker-machine rm " + machineName;
            DisplayConsolCommand(cmd);
            string result = ExecuteCommand(cmd);
            System.Console.WriteLine(result);
        }
        public void Kill(string machineName)
        {
            string cmd = "docker-machine kill " + machineName;
            DisplayConsolCommand(cmd);
            string result = ExecuteCommand(cmd);
            System.Console.WriteLine(result);
        }
        public void Start(string machineName)
        {
            string cmd = "docker-machine start " + machineName;
            DisplayConsolCommand(cmd);
            string result = ExecuteCommand(cmd);
            System.Console.WriteLine(result);
        }
        public void Stop(string machineName)
        {
            string cmd = "docker-machine stop " + machineName;
            DisplayConsolCommand(cmd);
            string result = ExecuteCommand(cmd);
            System.Console.WriteLine(result);
        }
        public void Images(string machineName)
        {
            string cmd = "docker-machine ssh " + machineName;
            DisplayConsolCommand(cmd);
            string result = ExecuteCommand(cmd);
            System.Console.WriteLine(result);
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
        private Machine RefreshInspect(string machineName)
        {
            try
            {
                string cmd = "docker-machine inspect " + machineName;
                DisplayConsolCommand(cmd);
                string result = ExecuteCommand(cmd);

                return JsonConvert.DeserializeObject<Machine>(result);
            }
            catch (Exception exp12000)
            {
                Log.Write("[ ERR : 12000 ] Cannot load the virtual machine.\n" + exp12000.Message);
                return null;
            }
        }
        private void DisplayMachineConfig()
        {
            Console.WriteLine("Pfiou seriously ? do it yourself !");
        }
        private void ParseMachineList(string dump)
        {
            // TODO : urgent changer ce code mega sale !!!
            
            _machines.Clear();

            string[] line;
            string[] tab = dump.Split('\n');
            for (int i = 1; i < tab.Length; i++)
            {
                if (!string.IsNullOrEmpty(tab[i]))
                {
                    string cleanLine = tab[i].Replace("  ", " ");
                    cleanLine = cleanLine.Replace("  ", " ");
                    cleanLine = cleanLine.Replace("  ", " ");
                    cleanLine = cleanLine.Replace("  ", " ");
                    cleanLine = cleanLine.Replace("  ", " ");
                    cleanLine = cleanLine.Replace("  ", " ");
                    cleanLine = cleanLine.Replace("  ", " ");
                    cleanLine = cleanLine.Replace("  ", " ");
                    line = cleanLine.Split(' ');

                    Machine machine = RefreshInspect(line[0]);
                    if (line.Length > 2) machine.State = line[2];
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
