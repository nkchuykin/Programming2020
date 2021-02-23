using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        int skiRunnersCount = int.Parse(Console.ReadLine());
        int shootersCount = int.Parse(Console.ReadLine());
        int biathlonistsCount = int.Parse(Console.ReadLine());
        try
        {
            List<Sportsman> sportsmen = new List<Sportsman>();
            AddSkiRunners(skiRunnersCount, sportsmen);
            AddShooters(shootersCount, sportsmen);
            AddBiathlonists(biathlonistsCount, sportsmen);
            Console.WriteLine(Methods.FindBestRunnerValue(sportsmen));
            Console.WriteLine(Methods.FindBestShooterValue(sportsmen));
            Console.WriteLine(Methods.FindBestBiathlonistValue(sportsmen));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void AddBiathlonists(int biathlonistsCount, List<Sportsman> sportsmen)
    {
        for (int i = 0; i < biathlonistsCount; i++)
        {
            sportsmen.Add(Biathlonist.Parse(Console.ReadLine()));
        }
    }

    private static void AddShooters(int shootersCount, List<Sportsman> sportsmen)
    {
        for (int i = 0; i < shootersCount; i++)
        {
            sportsmen.Add(Shooter.Parse(Console.ReadLine()));
        }
    }

    private static void AddSkiRunners(int skiRunnersCount, List<Sportsman> sportsmen)
    {
        for (int i = 0; i < skiRunnersCount; i++)
        {
            sportsmen.Add(SkiRunner.Parse(Console.ReadLine()));
        }
    }
}