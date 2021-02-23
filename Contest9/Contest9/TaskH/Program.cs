using System;
using System.Collections.Generic;
using System.IO;

class MainClass
{
    private static string[] coms = {"create ", "add ", "remove "};

    private static string[] permissions =
    {
        "UserRead",
        "UserWrite",
        "UserExecute",
        "GroupRead",
        "GroupWrite",
        "GroupExecute",
        "EveryoneRead",
        "EveryoneWrite",
        "EveryoneExecute"
    };

    private static string RandomString()
    {
        var line = string.Empty;
        for (int i = 0; i < 5; i++)
            line += (char) Random.Next('a', 'z' + 1);
        return line;
    }

    private static readonly Random Random = new Random();

    private static void MakeTests()
    {
        for (int test = 3; test <= 30; test++)
        {
            using (StreamWriter sw = new StreamWriter("tests/" + test.ToString("d2")))
            {
                List<string> files = new List<string>();
                int n = Random.Next(50, 100);
                sw.WriteLine(n);
                for (int i = 0; i < n; i++)
                {
                    string command;
                    do
                        command = coms[Random.Next(3)];
                    while (command != "create " && files.Count == 0);
                    string file;
                    switch (command)
                    {
                        case "create ":
                            file = RandomString();
                            files.Add(file);
                            sw.WriteLine(command + file);
                            break;
                        default:
                            file = files[Random.Next(files.Count)];
                            sw.WriteLine(command + file + " " + permissions[Random.Next(9)]);
                            break;
                    }
                }
            }
        }
    }

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