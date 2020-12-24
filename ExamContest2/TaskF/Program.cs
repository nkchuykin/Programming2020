using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double s = double.Parse(Console.ReadLine());

        var geometryRefs = new List<GeometryRef>(n);

        for (int i = 0; i < n; i++)
        {
            try
            {
                geometryRefs.Add(GeometryRef.Parse(Console.ReadLine()));
            }
            catch (ArgumentException argumentException)
            {
                Console.WriteLine(argumentException.Message);
            }
        }

        foreach (var geometryRef in geometryRefs.Where(geometryRef => geometryRef.GetSquare() >= s))
        {
            Console.WriteLine(geometryRef);
        }
    }
}