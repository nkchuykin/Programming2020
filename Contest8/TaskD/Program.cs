using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        var logger = new Logger();
        
        using (var fs = new FileStream("logs.txt", FileMode.OpenOrCreate))
        using (var sw = new StreamWriter(fs))
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ');

                Print method = command[0] switch
                {
                    "Console" => Console.WriteLine,
                    "File" => sw.WriteLine,
                    _ => throw new ArgumentException("Некорректная команда")
                };
                logger.MakeLog(method, command[1]);
            }
            
            logger.OutputLogs();
        }
        
        Console.WriteLine("Logs in file:");
        Console.WriteLine(File.ReadAllText("logs.txt"));
        File.Delete("logs.txt");
    }
}

