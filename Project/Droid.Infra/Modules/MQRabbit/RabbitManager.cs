﻿using RabbitMQ.Client;
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

namespace Droid.Infra
{
    public static class RabbitManager
    {
        #region Attributes
        public static event EventHandler QueueAdded;
        public static event EventHandler QueueRemoved;

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
                    WebClient webClient = new WebClient { Credentials = new NetworkCredential(ConfigurationManager.AppSettings["RABBIT_USER"], ConfigurationManager.AppSettings["RABBIT_PSWD"]) };
                    string response = webClient.DownloadString(string.Format("http://{0}:15672/api/queues/%2F", ConfigurationManager.AppSettings["RABBIT_HOST"]));
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
                    WebClient webClient = new WebClient { Credentials = new NetworkCredential(ConfigurationManager.AppSettings["RABBIT_USER"], ConfigurationManager.AppSettings["RABBIT_PSWD"]) };
                    string response = webClient.DownloadString(string.Format("http://{0}:15672/api/queues/%2F", ConfigurationManager.AppSettings["RABBIT_HOST"]));
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

            factory.HostName = System.Configuration.ConfigurationManager.AppSettings["RABBIT_HOST"];
            factory.UserName = System.Configuration.ConfigurationManager.AppSettings["RABBIT_USER"];
            factory.Password = System.Configuration.ConfigurationManager.AppSettings["RABBIT_PSWD"];

            if (int.TryParse(System.Configuration.ConfigurationManager.AppSettings["RABBIT_PORT"], out _port))
            {
                factory = new ConnectionFactory() { Endpoint = new AmqpTcpEndpoint(System.Configuration.ConfigurationManager.AppSettings["RABBIT_HOST"], _port) };
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

            factory.HostName = System.Configuration.ConfigurationManager.AppSettings["RABBIT_HOST"];
            factory.UserName = System.Configuration.ConfigurationManager.AppSettings["RABBIT_USER"];
            factory.Password = System.Configuration.ConfigurationManager.AppSettings["RABBIT_PSWD"];

            if (int.TryParse(System.Configuration.ConfigurationManager.AppSettings["RABBIT_PORT"], out _port))
            {
                factory = new ConnectionFactory() { Endpoint = new AmqpTcpEndpoint(System.Configuration.ConfigurationManager.AppSettings["RABBIT_HOST"], _port) };
                using (var connection = factory.CreateConnection())
                {
                    using (var channel = connection.CreateModel())
                    {
                        return channel.MessageCount(queueName);
                    }
                }
            }
            return 0;
        }
        public static void QueueDelete(string queueName)
        {
            try
            {
                ConnectionFactory factory = new ConnectionFactory();

                factory.HostName = System.Configuration.ConfigurationManager.AppSettings["RABBIT_HOST"];
                factory.UserName = System.Configuration.ConfigurationManager.AppSettings["RABBIT_USER"];
                factory.Password = System.Configuration.ConfigurationManager.AppSettings["RABBIT_PSWD"];

                if (int.TryParse(System.Configuration.ConfigurationManager.AppSettings["RABBIT_PORT"], out _port))
                {
                    factory = new ConnectionFactory() { Endpoint = new AmqpTcpEndpoint(System.Configuration.ConfigurationManager.AppSettings["RABBIT_HOST"], _port) };
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

                factory.HostName = System.Configuration.ConfigurationManager.AppSettings["RABBIT_HOST"];
                factory.UserName = System.Configuration.ConfigurationManager.AppSettings["RABBIT_USER"];
                factory.Password = System.Configuration.ConfigurationManager.AppSettings["RABBIT_PSWD"];

                if (int.TryParse(System.Configuration.ConfigurationManager.AppSettings["RABBIT_PORT"], out _port))
                {
                    factory = new ConnectionFactory() { Endpoint = new AmqpTcpEndpoint(System.Configuration.ConfigurationManager.AppSettings["RABBIT_HOST"], _port) };
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
                WebClient webClient = new WebClient { Credentials = new NetworkCredential(ConfigurationManager.AppSettings["RABBIT_USER"], ConfigurationManager.AppSettings["RABBIT_PSWD"]) };
                //string response = webClient.DownloadString(string.Format("http://{0}:15672/api/queues/%2F", ConfigurationManager.AppSettings["RABBIT_HOST"]));
                string response = webClient.DownloadString(string.Format("http://{0}:15672/api/queues?name=" + queueName, ConfigurationManager.AppSettings["RABBIT_HOST"]));
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
            CleanOldQueues();

            var newQueues = QueuesNames;
            if (_lastKnownQueues == null || _lastKnownQueues.Except(newQueues).ToList().Any() || newQueues.Except(_lastKnownQueues).ToList().Any())
            {
                QueueAdded?.Invoke(newQueues, null);
            }
            _lastKnownQueues = newQueues;
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