using System;

internal class Program
{
    public static void Main(string[] args)
    {
        Server server = new Server();
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine().Split();
            try
            {
                if (command[0] == "new")
                    server = Server.Connect(command[1]);
                else if (command[0] == "send")
                    server.Send(command[1]);
                else if (command[0] == "receive")
                    server.Receive(command[1]);
                else if (command[0] == "out")
                    server.Output();
                else
                    throw new NotImplementedException();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}