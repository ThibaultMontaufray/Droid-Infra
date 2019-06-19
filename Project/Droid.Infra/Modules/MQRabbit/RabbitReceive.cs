using Microsoft.Extensions.Configuration;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid.Infra
{
    public class RabbitReceive : RabbitMQInterface
    {
        #region Attributes
        private IConfiguration _config = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true).Build();

        public event EventHandler Message;
        private IConnection _connection;
        private IModel _channel;
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public RabbitReceive(string queueName) : base(queueName)
        {

        }
        #endregion

        #region Methods public
        public void SuspendListening()
        {
            CloseConnection();
        }
        public void ResumeListening()
        {
            OpenConnection();
        }
        #endregion

        #region Methods protected
        protected override void Init()
        {
            OpenConnection();
        }
        #endregion

        #region Methods private
        private void Processing(BasicDeliverEventArgs delivery)
        {
            try
            {
                var body = delivery.Body;
                //var message = Encoding.UTF8.GetString(body);
                //message = delivery.RoutingKey.Split('_')[1] + '|' + message;
                var message = delivery.RoutingKey.Split('_')[1] + "|" + DateTime.Now + "|" + Encoding.UTF8.GetString(body);
                Console.WriteLine(" [x] Received {0}", message.Replace("\n", "\\n"));
                Message?.Invoke(message, null);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
        private void OpenConnection()
        {
            int _port;
            if (_factory != null)
            {
                if (_connection == null || !_connection.IsOpen)
                {
                    _factory.HostName = _config["RABBIT_HOST"];
                    _factory.UserName = _config["RABBIT_USER"];
                    _factory.Password = _config["RABBIT_PSWD"];

                    if (int.TryParse(_config["RABBIT_PORT"], out _port))
                    {
                        _factory.Port = _port;
                        _connection = _factory.CreateConnection();
                        _channel = _connection.CreateModel();
                        _channel.QueueDeclare(queue: _queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);
                        var consumer = new EventingBasicConsumer(_channel);
                        consumer.Received += Consumer_Received;
                        _channel.BasicConsume(queue: _queueName, autoAck: true, consumer: consumer);
                        Console.WriteLine(string.Format(" [open] RabbitMQ receiver connected to {0}.", _queueName));
                    }
                }
            }
        }
        private void CloseConnection()
        {
            if (_connection != null && _connection.IsOpen)
            {
                _connection.Close();
                _connection.Dispose();
                Console.WriteLine(string.Format(" [close] RabbitMQ receiver disconnected from {0}.", _queueName));
            }
        }
        #endregion

        #region Event
        private void Consumer_Received(object sender, BasicDeliverEventArgs e)
        {
            Processing(e);
        }
        #endregion
    }
}
