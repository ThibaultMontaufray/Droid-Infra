using RabbitMQ.Client;
using RabbitMQ.Client.Exceptions;
using System;
using System.Text;

namespace Droid.Infra
{
    public class RabbitSender : RabbitMQInterface
    {
        #region Attributes
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
                using (var connection = _factory.CreateConnection())
                {
                    using (var channel = connection.CreateModel())
                    {

                        channel.QueueDeclare(queue: _queueName,
                                             durable: false,
                                             exclusive: false,
                                             autoDelete: false,
                                             arguments: null);
                        
                        var body = Encoding.UTF8.GetBytes(message);

                        channel.BasicPublish(exchange: string.Empty,
                                             routingKey: _queueName,
                                             basicProperties: null,
                                             body: body);
                        Console.WriteLine(" [x] Sent {0}", message.Replace("\n", "\\n"));
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
