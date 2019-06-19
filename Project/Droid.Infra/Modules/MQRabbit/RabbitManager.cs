using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using RabbitMQHare;
using Newtonsoft.Json.Linq;
using System.Timers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.FileExtensions;
using Microsoft.Extensions.Configuration.Json;

namespace Droid.Infra
{
    public static class RabbitManager
    {
        #region Attributes
        public static event EventHandler QueueAdded;
        public static event EventHandler QueueRemoved;

        private static IConfiguration _config = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true).Build();
        private static int _port;
        private static Timer _timer;
        private static bool _daemonStarted;
        private static bool _daemonLock;
        private static bool _daemonStopRequested;
        private static List<string> _lastKnownQueues;
        private static readonly TimeSpan MAXQUEUEAGE = new TimeSpan(0, 7, 0, 0);
        #endregion
            
        #region Properties
        public static List<string> QueuesNames
        {
            get
            {
                try
                {
                    List<string> queues = new List<string>();
                    WebClient webClient = new WebClient { Credentials = new NetworkCredential(_config["RABBIT_USER"], _config["RABBIT_PSWD"]) };
                    string response = webClient.DownloadString(string.Format("http://{0}:15672/api/queues/%2F", _config["RABBIT_HOST"]));
                    JArray tab = (JArray)Newtonsoft.Json.JsonConvert.DeserializeObject(response);
                    if (tab != null)
                    {
                        foreach (var item in tab)
                        {
                            queues.Add(item.Value<string>("name"));
                        }
                    }
                    RabbitQueue[] var = (RabbitQueue[])Newtonsoft.Json.JsonConvert.DeserializeObject(response, typeof(RabbitQueue[]));
                    return queues;
                }
                catch (Exception exp)
                {
                    Console.Write(exp.Message);
                    return null;
                }
            }
        }
        public static RabbitQueue[] Queues
        {
            get
            {
                try
                {
                    List<string> queues = new List<string>();
                    WebClient webClient = new WebClient { Credentials = new NetworkCredential(_config["RABBIT_USER"], _config["RABBIT_PSWD"]) };
                    string response = webClient.DownloadString(string.Format("http://{0}:15672/api/queues/%2F", _config["RABBIT_HOST"]));
                    return (RabbitQueue[])Newtonsoft.Json.JsonConvert.DeserializeObject(response, typeof(RabbitQueue[]));
                }
                catch (Exception exp)
                {
                    Console.Write(exp.Message);
                    return null;
                }
            }
        }
        public static bool DaemonStarted
        {
            get { return _daemonStarted; }
            set { _daemonStarted = value; }
        }
        #endregion

        #region Constructor
        static RabbitManager()
        {
            Init();
        }
        #endregion

        #region Methods public
        public static void CleanQueue(string queueName)
        {
            ConnectionFactory factory = new ConnectionFactory();

            factory.HostName = _config["RABBIT_HOST"];
            factory.UserName = _config["RABBIT_USER"];
            factory.Password = _config["RABBIT_PSWD"];

            if (int.TryParse(_config["RABBIT_PORT"], out _port))
            {
                factory.Port = _port;
                using (var connection = factory.CreateConnection())
                {
                    using (var channel = connection.CreateModel())
                    {
                        channel.QueuePurge(queueName);
                    }
                }
            }
        }
        public static uint QueueMessages(string queueName)
        {
            ConnectionFactory factory = new ConnectionFactory();

            factory.HostName = _config["RABBIT_HOST"];
            factory.UserName = _config["RABBIT_USER"];
            factory.Password = _config["RABBIT_PSWD"];

            if (int.TryParse(_config["RABBIT_PORT"], out _port))
            {
                try
                {
                    factory.Port = _port;
                    using (var connection = factory.CreateConnection())
                    {
                        using (var channel = connection.CreateModel())
                        {
                            try
                            {
                                return channel.MessageCount(queueName);
                            }
                            catch (Exception exp)
                            {
                                Console.WriteLine(exp.Message);
                                return uint.MinValue;
                            }
                        }
                    }
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
            return 0;
        }
        public static void QueueDelete(string queueName)
        {
            try
            {
                ConnectionFactory factory = new ConnectionFactory();

                factory.HostName = _config["RABBIT_HOST"];
                factory.UserName = _config["RABBIT_USER"];
                factory.Password = _config["RABBIT_PSWD"];

                if (int.TryParse(_config["RABBIT_PORT"], out _port))
                {
                    factory.Port = _port;
                    using (var connection = factory.CreateConnection())
                    {
                        using (var channel = connection.CreateModel())
                        {
                            channel.QueueDelete(queueName);
                            QueueRemoved?.Invoke(queueName, null);
                        }
                    }
                }
                Console.WriteLine("Queue " + queueName + " deleted");
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
        public static void QueueCreate(string queueName)
        {
            try
            {
                ConnectionFactory factory = new ConnectionFactory();

                factory.HostName = _config["RABBIT_HOST"];
                factory.UserName = _config["RABBIT_USER"];
                factory.Password = _config["RABBIT_PSWD"];

                if (int.TryParse(_config["RABBIT_PORT"], out _port))
                {
                    factory.Port = _port;
                    using (var connection = factory.CreateConnection())
                    {
                        using (var channel = connection.CreateModel())
                        {
                            channel.QueueDeclare(queue: queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);
                        }
                    }
                }
                Console.WriteLine("Queue " + queueName + " created");
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
        public static DateTime QueueLastCommunication(string queueName)
        {
            try
            {
                DateTime date = DateTime.MaxValue;
                DateTime dateTmp;
                WebClient webClient = new WebClient { Credentials = new NetworkCredential(_config["RABBIT_USER"], _config["RABBIT_PSWD"]) };
                //string response = webClient.DownloadString(string.Format("http://{0}:15672/api/queues/%2F", _config["RABBIT_HOST"]));
                string response = webClient.DownloadString(string.Format("http://{0}:15672/api/queues?name=" + queueName, _config["RABBIT_HOST"]));
                JArray tab = (JArray)Newtonsoft.Json.JsonConvert.DeserializeObject(response);
                if (tab != null)
                {
                    foreach (var item in tab)
                    {
                        if (item.Value<string>("messages").Equals("0"))
                        {
                            dateTmp = item.Value<DateTime>("idle_since");
                            if (dateTmp > date) { date = dateTmp; }
                        }
                    }
                }
                RabbitQueue[] var = (RabbitQueue[])Newtonsoft.Json.JsonConvert.DeserializeObject(response, typeof(RabbitQueue[]));
                return date;
            }
            catch (Exception exp)
            {
                Console.Write(exp.Message);
                return DateTime.MinValue;
            }
        }
        public static void StartDaemon()
        {
            if (!_daemonStarted && !_daemonLock)
            {
                _timer.Start();
                _daemonStarted = true;
            }
        }
        public static void StopDaemon()
        {
            if (_daemonLock)
            {
                _daemonStopRequested = true;
            }
            else
            { 
                _timer.Stop();
                _daemonStarted = false;
            }
        }
        #endregion

        #region Methods private
        private static void Init()
        {
            Console.WriteLine("Rabbit user : " + _config["RABBIT_USER"]);
            Console.WriteLine("Rabbit host : " + _config["RABBIT_HOST"]);

            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Elapsed += _timer_Elapsed;

            _daemonStarted = false;
            _daemonLock = false;
            _daemonStopRequested = false;
            
            _lastKnownQueues = QueuesNames;
            if (_lastKnownQueues != null) { Console.WriteLine(_lastKnownQueues.Count + " queue(s) detected."); }
        }
        private static void ProcessDaemon()
        {
            try
            {
                CleanOldQueues();

                var newQueues = QueuesNames;
                if (newQueues != null && _lastKnownQueues == null || _lastKnownQueues.Except(newQueues).Any() || newQueues.Except(_lastKnownQueues).Any())
                {
                    QueueAdded?.Invoke(newQueues, null);
                }
                _lastKnownQueues = newQueues;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
        private static void CleanOldQueues()
        {
            foreach (var item in _lastKnownQueues)
            {
                if (item.ToLower().Contains("communication") && DateTime.Now - RabbitManager.QueueLastCommunication(item) > MAXQUEUEAGE)
                {
                    RabbitManager.QueueDelete(item);
                }
            }
        }
        #endregion

        #region Event
        private static void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _daemonLock = true;
            _timer.Stop();

            ProcessDaemon();

            if (!_daemonStopRequested)
            { 
                _timer.Start();
            }
            _daemonLock = false;
            _daemonStopRequested = false;
            _daemonStarted = false;
        }
        #endregion
    }
}
