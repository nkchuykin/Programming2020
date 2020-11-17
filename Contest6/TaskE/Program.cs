using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    private static IEnumerable<LegendaryHuman> ReadHumans(string filename)
    {
        var legendaryHumans = new List<LegendaryHuman>();

        using (var sr = new StreamReader(filename))
        {
            while (!sr.EndOfStream)
            {
                var data = sr.ReadLine().Split('\t');
                if (data[0] == "Knight")
                {
                    try
                    {
                        var equipment = new string[] { };
                        if (data.Length > 4 && !string.IsNullOrWhiteSpace(data[4]))
                        {
                            equipment = data[4].Split(", ");
                        }

                        legendaryHumans.Add(new Knight(data[1], int.Parse(data[2]), int.Parse(data[3]), equipment));
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (data[0] == "Wizard")
                {
                    try
                    {
                        legendaryHumans.Add(new Wizard(data[1], int.Parse(data[2]), int.Parse(data[3]), data[4]));
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }

        return legendaryHumans;
    }

    public static void Main(string[] args)
    {
        var humans = ReadHumans("legendaryHumans.txt").ToList();

        foreach (var human in humans)
        {
            foreach (var otherHuman in humans.Where(otherHuman => human != otherHuman))
            {
                otherHuman.Attack(human);
                human.Attack(otherHuman);
            }
        }
    }
}