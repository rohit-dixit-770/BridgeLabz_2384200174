using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Channels;

namespace RabbitMQImplementation.Service
{
    public class RabbitMQConsumer
    {
        public void ConsumeMessages()
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using var connection = factory.CreateConnectionAsync();
            using var channel = connection.CreateModel();

            channel.QueueDeclare(queue: "emailQueue", durable: false, exclusive: false, autoDelete: false, arguments: null);
            var consumer = new AsyncEventingBasicConsumer(channel);

            consumer.ReceivedAsync += async (model, ea) =>
                {
                    var body = ea.Body.ToArray();
                    var message = Encoding.UTF8.GetString(body);
                    var emailMessage = JsonSerializer.Deserialize<MailMessage>(message);

                    if (emailMessage != null)
                    {
                        await new EmailSender().SendEmailAsync(emailMessage.To, emailMessage.Subject, emailMessage.Body);
                    }
                };

            channel.BasicConsume(queue: "emailQueue", autoAck: true, consumer: consumer);

        }
    }
}