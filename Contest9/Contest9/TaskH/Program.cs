using System;
using System.Collections.Generic;
using System.IO;

class MainClass
{

    public static void Main(string[] args)
    {
        Files files = new Files();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] commands = Console.ReadLine().Split(' ');
            switch (commands[0])
            {
                case "create":
                    files.CreateFile(commands[1]);
                    break;
                case "add":
                    files.AddPermission(commands[1], commands[2]);
                    break;
                case "remove":
                    files.RemovePermission(commands[1], commands[2]);
                    break;
                default:
                    throw new InvalidOperationException();
            }
        }

        Console.WriteLine(files);
    }
}