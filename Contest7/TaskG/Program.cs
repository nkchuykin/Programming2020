using System;
using System.IO;

class Program
{

    static void Main(string[] args)
    {
        TestSystem testSystem = new TestSystem();
        int n = int.Parse(Console.ReadLine());
        try
        {
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();
                if (commands[0] == "Add")
                    testSystem.Add(commands[1]);
                else if (commands[0] == "Remove")
                    testSystem.Remove(commands[1]);
                else if (commands[0] == "Notify")
                    testSystem.Notify(commands[1]);
                else
                    throw new NotImplementedException();
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}