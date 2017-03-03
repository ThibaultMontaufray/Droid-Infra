namespace Droid_Infra
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;

    public class Boot2Docker : Command
    {
        #region Attribute
        private STATUS _lastStatus;
        private string _vmName;
        private int _cpu;
        private int _memory;
        private int _vram;
        private int _port;
        private int _portSSH;
        private string _iso;
        #endregion

        #region Properties
        public string ISO
        {
            get { return _iso; }
            set { _iso = value; }
        }
        public int PortSSH
        {
            get { return _portSSH; }
            set { _portSSH = value; }
        }
        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }
        public int VirtualRAM
        {
            get { return _vram; }
            set { _vram = value; }
        }
        public int Memory
        {
            get { return _memory; }
            set { _memory = value; }
        }
        public int CPU
        {
            get { return _cpu; }
            set { _cpu = value; }
        }
        public string VirtualMachineName
        {
            get { return _vmName; }
            set { _vmName = value; }
        }
        public STATUS LastStatus
        {
            get { return _lastStatus; }
            set { _lastStatus = value; }
        }
        #endregion

        #region Constructor
        public Boot2Docker()
        {
            //RefreshInfo();
        }
        #endregion

        #region Methods public
        public void Init()
        {
            string cmd = "boot2docker init --hostip=192.168.59.3";
            DisplayConsolCommand(cmd);
            string result = ExecuteCommand(cmd);
            System.Console.WriteLine(result);
        }
        public void Start()
        {
            string cmd = "boot2docker start";
            DisplayConsolCommand(cmd);
            string dump = ExecuteCommand(cmd);
            System.Console.WriteLine(dump);

            string result;
            foreach (string cmdLine in CleanStartCommand(dump))
            {
                DisplayConsolCommand(cmdLine);
                result = ExecuteCommand(cmdLine);
                if (!string.IsNullOrEmpty(result)) System.Console.WriteLine(result);
            }
        }
        public void Restart()
        {
            string cmd = "boot2docker restart";
            DisplayConsolCommand(cmd);
            string result = ExecuteCommand(cmd);
            System.Console.WriteLine(result);
        }
        public void Stop()
        {
            string cmd = "boot2docker stop";
            DisplayConsolCommand(cmd);
            string result = ExecuteCommand(cmd);
            System.Console.WriteLine(result);
        }
        public void RefreshStatus()
        {
            string cmd = "boot2docker status";
            DisplayConsolCommand(cmd);
            string result = ExecuteCommand(cmd);

            try
            {
                _lastStatus = (STATUS)Enum.Parse(typeof(STATUS), result.Replace('\n', ' ').Trim().ToUpper());
            }
            catch (Exception)
            {
                Console.WriteLine("Unknow status detected : " + result);
                _lastStatus = STATUS.UNKNOWN;
            }

            System.Console.WriteLine(_lastStatus.ToString());
        }
        public void RefreshInfo()
        {
            string cmd = "boot2docker info";
            DisplayConsolCommand(cmd);
            string result = ExecuteCommand(cmd);
            
            JsonSerializer serializer = new JsonSerializer();
            VirtualMachine vm = JsonConvert.DeserializeObject<VirtualMachine>(result);

            string[] tabLine;
            foreach (string line in result.Split('\n'))
            {
                if (line.Contains("\""))
                {
                    tabLine = line.Split('"');
                    if (tabLine.Length > 1)
                    {
                        switch (tabLine[1].ToLower())
                        {
                            case "name":
                                _vmName = tabLine[3];
                                break;
                            case "iso":
                                _iso = tabLine[3];
                                break;
                            case "cpus":
                                int.TryParse(tabLine[2].Replace(':', ' ').Replace(',', ' ').Trim(), out _cpu);
                                break;
                            case "memory":
                                int.TryParse(tabLine[2].Replace(':', ' ').Replace(',', ' ').Trim(), out _memory);
                                break;
                            case "vram":
                                int.TryParse(tabLine[2].Replace(':', ' ').Replace(',', ' ').Trim(), out _vram);
                                break;
                            case "state":
                                try
                                {
                                    _lastStatus = (STATUS)Enum.Parse(typeof(STATUS), tabLine[3].ToUpper());
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Unknow status detected : " + tabLine[3]);
                                    _lastStatus = STATUS.UNKNOWN;
                                }
                                break;
                            case "dockerport":
                                int.TryParse(tabLine[2].Replace(':', ' ').Replace(',', ' ').Trim(), out _port);
                                break;
                            case "sshport":
                                int.TryParse(tabLine[2].Replace(':', ' ').Replace(',', ' ').Trim(), out _portSSH);
                                break;
                        }
                    }
                }
            }
            DisplayInfo();
        }
        public void DisplayInfo()
        {
            Console.WriteLine("");
            Console.WriteLine(string.Format("\t- Virtual machine :\t{0}", _vmName));
            Console.WriteLine(string.Format("\t- ISO             :\t{0}", _iso));
            Console.WriteLine(string.Format("\t- Machine CPU     :\t{0}", _cpu));
            Console.WriteLine(string.Format("\t- RAM             :\t{0}", _memory));
            Console.WriteLine(string.Format("\t- Virtual RAM     :\t{0}", _vram));
            Console.WriteLine(string.Format("\t- Status          :\t{0}", _lastStatus));
            Console.WriteLine(string.Format("\t- Docker port     :\t{0}", _port));
            Console.WriteLine(string.Format("\t- SSH port        :\t{0}", _portSSH));
            Console.WriteLine("");
        }
        #endregion

        #region Methods private
        private List<string> CleanStartCommand(string dump)
        {
            List<string> cmd = new List<string>();
            string[] tab = dump.Split('\n');
            foreach (string line in tab)
            {
                if (line.Contains("set "))
                {
                    cmd.Add(line);
                }
                else if (line.Split('"').Length > 1)
                {
                    if (line.Contains("DOCKER_HOST"))
                    {
                        cmd.Add("set DOCKER_HOST=" + line.Split('"')[1]);
                    }
                    else if (line.Contains("DOCKER_CERT_PATH"))
                    {
                        cmd.Add("set DOCKER_CERT_PATH=" + line.Split('"')[1]);
                    }
                    else if (line.Contains("DOCKER_TLS_VERIFY"))
                    {
                        cmd.Add("set DOCKER_TLS_VERIFY=" + line.Split('"')[1]);
                    }
                }
            }
            return cmd;
        }
        private static void DisplayConsolCommand(string cmd)
        {
            ConsoleColor lastColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("# " + cmd);
            System.Console.ForegroundColor = lastColor;
        }
        #endregion

        #region Event
        #endregion
    }
}
