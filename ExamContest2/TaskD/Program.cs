using System;
using System.Collections.Generic;

internal class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());

        List<Mushroom> mushrooms = new List<Mushroom>(n);

        for (int i = 0; i < n; i++)
        {
            try
            {
                mushrooms.Add(Mushroom.Parse(Console.ReadLine()));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        double average = Mushroom.GetAverageDiameter(mushrooms, m);

        Console.WriteLine(average.ToString("F2"));
    }
}