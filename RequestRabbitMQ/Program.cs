using System;

namespace RequestRabbitMQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Topicmessages topicmessages = new Topicmessages();
            topicmessages.SendMessage();
            Console.ReadLine();
        }
    }
}