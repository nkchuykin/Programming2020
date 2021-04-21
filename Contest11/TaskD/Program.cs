using System;
using System.Collections.Generic;

public class Program
{
    private const string OutputPath = "output.xml";

    public static void Main(string[] args)
    {
        int seed = int.Parse(Console.ReadLine());

        var serializer = new SimpleFurnitureSerializer();

        serializer.Serialize(GenerateFurnitureBySeed(seed), OutputPath);
    }

    private static List<Furniture> GenerateFurnitureBySeed(int seed)
    {
        Random random = new Random(seed);

        int countFurniture = random.Next(5, 20);

        var furniture = new List<Furniture>(countFurniture);

        for (int i = 0; i < countFurniture; i++)
        {
            furniture.Add(GenerateFurniture(random, i + 1));
        }

        return furniture;
    }

    private static Furniture GenerateFurniture(Random random, long id)
    {
        int choice = random.Next(0, 2);

        if (choice % 2 != 0)
        {
            return new Bed(id, GeneratePillows(random));
        }

        var timeSpan = TimeSpan.FromSeconds(random.Next(10, 400000));

        return new Lamp(id, timeSpan);
    }

    private static List<Pillow> GeneratePillows(Random random)
    {
        int countPillow = random.Next(0, 10);

        var pillows = new List<Pillow>(countPillow);

        for (int i = 0; i < countPillow; i++)
        {
            pillows.Add(GeneratePillow(random, i + 1));
        }

        return pillows;
    }

    private static Pillow GeneratePillow(Random random, int id)
    {
        return new Pillow(id, random.Next(0, 7) % 2 == 0);
    }
}