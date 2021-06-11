using System;
using System.Collections.Generic;

delegate string KeyPredicate(int id);

delegate string ValuePredicate(int id);

public partial class Program
{
    private static Dictionary<int, string> areas = new Dictionary<int, string>();
    private static Dictionary<int, string> cities = new Dictionary<int, string>();

    public static void Main(string[] args)
    {
        LoadAreas();
        LoadCities();
        int areasCount = int.Parse(Console.ReadLine());
        var data = new Dictionary<int, List<int>>();
        for (int i = 0; i < areasCount; i++)
        {
            int areaId = int.Parse(Console.ReadLine());
            var citiesInArea = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
            data[areaId] = citiesInArea;
        }

        try
        {
            var convertedData = Convert(x => areas[x], x => cities[x], data);
            foreach (var pair in convertedData)
            {
                Console.Write($"{pair.Key}: ");
                pair.Value.ForEach(city => Console.WriteLine($"city; "));
                Console.WriteLine();
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}