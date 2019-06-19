using Microsoft.Extensions.Configuration;
using RabbitMQ.Client;
using RabbitMQ.Client.Exceptions;
using System;
using System.Text;

namespace Droid.Infra
{
    public class RabbitSender : RabbitMQInterface
    {
        #region Attributes
        private IConfiguration _config = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true).Build();
        private IConnection _connection;
        private IModel _channel;
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public RabbitSender(string queueName) : base(queueName)
        {
        }
        #endregion

        #region Methods public
        public void SendIt(string message)
        {
            try
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
                            using (var connection = _factory.CreateConnection())
                            {
                                using (_channel = connection.CreateModel())
                                {
                                    _channel.QueueDeclare(queue: _queueName,
                                                         durable: false,
                                                         exclusive: false,
                                                         autoDelete: false,
                                                         arguments: null);

                                    var body = Encoding.UTF8.GetBytes(message);

                                    _channel.BasicPublish(exchange: string.Empty,
                                                         routingKey: _queueName,
                                                         basicProperties: null,
                                                         body: body);
                                    Console.WriteLine(" [x] Sent {0}", message.Replace("\n", "\\n"));
                                }
                            }
                        }
                    }
                }
            }
            catch (BrokerUnreachableException exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
        #endregion

        #region Methods protected
        protected override void Init()
        {
            Console.WriteLine("RabbitMq sender init completed.");
        }
        #endregion

        #region Methods private
        #endregion

        #region Event
        #endregion
    }
}
