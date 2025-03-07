using RabbitMQ.Client;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace RepositoryLayer.Helper
{
    public class RabbitMQProducer
    {
        private readonly IConfiguration _config;

        public RabbitMQProducer(IConfiguration config)
        {
            _config = config;
        }

        public void PublishMessage(object message)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();


            channel.QueueDeclare(
                queue: "emailQueue",
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null
            );

            var json = JsonConvert.SerializeObject(message);
            var body = Encoding.UTF8.GetBytes(json);

            channel.BasicPublish(
                exchange: "",
                routingKey: "emailQueue",
                basicProperties: null,
                body: body
                );

        }
    }

}
