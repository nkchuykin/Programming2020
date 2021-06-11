using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Program
{
    private static void PrintCollection(ICollection<int> collection)
    {
        foreach (var item in collection)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine();
    }

    private static ICollection<int> CollectionFromString(string data) => Array.ConvertAll(data.Split(), int.Parse);

    public static void Main(string[] args)
    {
        string initial = Console.ReadLine();
        string set = Console.ReadLine();
        string array = Console.ReadLine();
        
        var collection = string.IsNullOrWhiteSpace(initial)
            ? new List<int>()
            : new List<int>(CollectionFromString(initial));
        var setRange = string.IsNullOrWhiteSpace(set)
            ? new HashSet<int>()
            : new HashSet<int>(CollectionFromString(set));
        var arrayRange = string.IsNullOrWhiteSpace(array) 
            ? Array.Empty<int>() 
            : CollectionFromString(array);
        int n = int.Parse(Console.ReadLine());
        
        collection.AddRange<int>(setRange);
        PrintCollection(collection);
        collection.RemoveWhere<int>(x => x % n == 0);
        PrintCollection(collection);
        collection.AddRange<int>(arrayRange);
        PrintCollection(collection);
        collection.RemoveDuplicates<int>();
        PrintCollection(collection);
        var selected = collection.AllWhere<int>(x => x < n);
        PrintCollection(selected);
    }
}