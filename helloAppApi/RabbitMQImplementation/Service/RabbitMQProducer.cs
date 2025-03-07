using RabbitMQ.Client;
using System.Text;
using System.Text.Json;

public class RabbitMQProducer
{
    private readonly IConnection _connection;
    private readonly IModel _channel;

    private readonly IConfiguration _config;
    public RabbitMQProducer() 
    {
        var factory = new ConnectionFactory() { HostName = "localhost" };
        _connection = factory.CreateConnection();
        _channel = _connection.CreateModel();

        _channel.QueueDeclare(
            queue: "emailQueue",
            durable: false,
            exclusive: false,
        autoDelete: false,
            arguments: null
        );
    }

    public void PublishMessage(EmailMessage message)
    {
        var json = JsonSerializer.Serialize(message);
        var body = Encoding.UTF8.GetBytes(json);

        _channel.BasicPublish(
            exchange: "",
            routingKey: "emailQueue",
            basicProperties: null,
            body: body
        );
    }
}
