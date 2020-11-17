using System;
using System.Collections.Generic;

partial class Program
{
    static void Main(string[] args)
    {
        string favouriteName = Console.ReadLine();

        int N = int.Parse(Console.ReadLine());
        List<Sheep> sheeps = new List<Sheep>(N);

        for (int i = 0; i < N; i++)
        {
            try
            {
                sheeps.Add(ParseSheep(Console.ReadLine()));
            }
            catch (ArgumentException argumentException)
            {
                Console.WriteLine(argumentException.Message);
            }
        }

        Grassland grassland = new Grassland(sheeps);

        PrintSheeps(grassland.GetEvenSheeps());
        PrintSheeps(grassland.GetOddSheeps());
        PrintSheeps(grassland.GetSheepsByContainsName(favouriteName));
    }

    private static void PrintSheeps(List<Sheep> sheeps)
    {
        foreach (var sheep in sheeps)
        {
            Console.WriteLine(sheep);
        }
    }
}
