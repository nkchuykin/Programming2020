using System;
using System.IO;

public class Program
{

    public static void Main(string[] args)
    {
        int numberOfQueries = int.Parse(Console.ReadLine());
        using (StreamWriter log = new StreamWriter("log.txt"))
        {
            RandomProxy random = new RandomProxy(log);
            for (int i = 0; i < numberOfQueries; i++)
            {
                string[] comands = Console.ReadLine().Split();
                try
                {
                    if (comands[0] == "register")
                    {
                        random.Register(comands[1], int.Parse(comands[2]));
                        continue;
                    }
                    switch (comands.Length)
                    {
                        case 2:
                            random.Next(comands[1]);
                            break;
                        case 3:
                            random.Next(comands[1], int.Parse(comands[2]));
                            break;
                        case 4:
                            random.Next(comands[1], int.Parse(comands[2]), int.Parse(comands[3]));
                            break;
                    }
                }
                catch (ArgumentException ex)
                {
                    log.WriteLine($"{ex.GetType()} {ex.Message}");
                }
            }
        }
    }
}