using Microsoft.Extensions.Configuration;
using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using Newtonsoft.Json;
using System.Net.Mail;
using System.Text;
using ModelLayer.DTO;

namespace RepositoryLayer.Helper
{
    public class RabbitMQConsumer
    {
        private readonly IConfiguration _config;
        private readonly EmailSender _emailService;

        public RabbitMQConsumer(IConfiguration config, EmailSender emailService)
        {
            _config = config;
            _emailService = emailService;
        }

        public void StartListening()
        {
            var factory = new ConnectionFactory
            {
                HostName = "localhost",
                UserName = "Rohit",
                Password = "Rohhit@770"
            };

            var connection = factory.CreateConnection();
            var channel = connection.CreateModel();
            channel.QueueDeclare(queue: "Email_Queue", 
                durable: false, 
                exclusive: false, 
                autoDelete: false, 
                arguments: null);

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += async (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                var emailMessage = JsonConvert.DeserializeObject<EmailMessage>(message);

                await _emailService.SendEmailAsync(emailMessage.To, emailMessage.Subject, emailMessage.Body);
            };

            channel.BasicConsume(
                queue: "Email_Queue", 
                autoAck: true, 
                consumer: consumer);
        }
    }

}
