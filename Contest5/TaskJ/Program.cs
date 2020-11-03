using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    private static void PrintTasks(IEnumerable<Task> tasks)
    {
        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }
    }

    public static void Main(string[] args)
    {
        var support = new Support();

        using (var sr = new StreamReader("queries.txt"))
        {
            while (!sr.EndOfStream)
            {
                string[] query = sr.ReadLine().Split('|').Select(parameter => parameter.Trim()).ToArray();

                switch (query[0].ToLower())
                {
                    case "open":
                        Console.WriteLine(support.OpenTask(query[1]));
                        break;
                    case "close":
                        support.CloseTask(int.Parse(query[1]), query[2]);
                        break;
                    case "close unresolved":
                        support.CloseAllUnresolvedTasksWithDefaultAnswer(query[1]);
                        break;
                    case "info":
                        Console.WriteLine(support.GetTaskInfo(int.Parse(query[1])));
                        break;
                    case "get all":
                        PrintTasks(support.Tasks);
                        break;
                    case "get unresolved":
                        PrintTasks(support.GetAllUnresolvedTasks());
                        break;
                    default:
                        throw new InvalidOperationException("Unknown command.");
                }
            }
        }
    }
}