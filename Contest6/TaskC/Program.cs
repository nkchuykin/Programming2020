using System;
using System.Collections.Generic;

class Program
{
    private static IEnumerable<Polygon> ReadPolygons()
    {
        string input;
        
        var polygons = new List<Polygon>();

        while (!string.IsNullOrEmpty(input = Console.ReadLine()))
        {
            string[] parameters = input.Split(' ');
            
            if (string.Equals(parameters[0], "P"))
            {
                try
                {
                    polygons.Add(new Polygon(double.Parse(parameters[1]), double.Parse(parameters[2])));
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else if (string.Equals(parameters[0], "RP"))
            {
                try
                {
                    polygons.Add(new RegularPolygon(double.Parse(parameters[1]), int.Parse(parameters[2])));
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        return polygons;
    }
    
    public static void Main(string[] args)
    {
        var polygons = ReadPolygons();
        
        foreach (var polygon in polygons)
        {
            Console.WriteLine(polygon);
        }
    }
}
