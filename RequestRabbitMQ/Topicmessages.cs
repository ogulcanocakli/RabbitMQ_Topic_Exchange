using RabbitMQ.Client;
using System;
using System.Text;

public class Topicmessages
{

    private const string UName = "guest";
    private const string PWD = "guest";
    private const string HName = "localhost";

    public void SendMessage()
    {
        var connectionFactory = new ConnectionFactory()
        {
            UserName = UName,
            Password = PWD,
            HostName = HName
        };

        var connection = connectionFactory.CreateConnection();
        var model = connection.CreateModel();
        var properties = model.CreateBasicProperties();
        properties.Persistent = false;
        byte[] messagebuffer = Encoding.Default.GetBytes("Message from Topic Exchange 'Bombay' ");

        model.BasicPublish(exchange: "topic.exchange",
                           routingKey: "Message.Bombay.SMS",
                           basicProperties: properties,
                           body: messagebuffer);

        Console.WriteLine("Message Sent From: topic.exchange ");
        Console.WriteLine("Routing Key: Message.Bombay.Email");
        Console.WriteLine("Message Sent");

    }
}