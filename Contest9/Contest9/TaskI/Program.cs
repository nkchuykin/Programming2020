using System;
using System.Collections.Generic;

class Program
{
    private static Dictionary<string, User> users = new Dictionary<string, User>();

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        Kafka kafka = new Kafka(m);
        for (int i = 0; i < n; i++)
        {
            string[] commands = Console.ReadLine().Split(" ");
            try
            {
                switch (commands[0])
                {
                    case "activate":
                        kafka.Activate();
                        Console.WriteLine("Kafka is activated");
                        break;
                    case "deactivate":
                        kafka.Deactivate();
                        Console.WriteLine("Kafka is deactivated");
                        break;
                    case "new_user":
                        string username = commands[1];
                        var user = new User(username);
                        users[username] = user;
                        Console.WriteLine($"User {username} is created");
                        break;
                    case "subscribe":
                        kafka.Subscribe(users[commands[1]]);
                        Console.WriteLine($"User {commands[1]} subscribed");
                        break;
                    case "unsubscribe":
                        kafka.Unsubscribe(users[commands[1]]);
                        Console.WriteLine($"User {commands[1]} unsubscribed");
                        break;
                    case "push":
                        kafka.Push(new Message(commands[1], commands[2]));
                        Console.WriteLine($"Message from {commands[2]} {commands[1]} pushed");
                        break;
                    case "pop":
                        var messages = kafka.PopMessages(users[commands[1]], int.Parse(commands[2])).ToArray();
                        Console.WriteLine($"User {commands[1]} poped {commands[2]} messages");
                        Array.ForEach(messages, Console.WriteLine);
                        break;
                }
            }
            catch (KafkaException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}