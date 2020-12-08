using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        int findsNumber = int.Parse(Console.ReadLine());
        var archaeologicalFinds = new List<ArchaeologicalFind>();
    
        for (int i = 0; i < findsNumber; ++i)
        {
            if (ReadFind(Console.ReadLine().Split(' '), out var archaeologicalFind))
            {
                ArchaeologicalFind.AddFind(archaeologicalFinds, archaeologicalFind);
            }
        }
    
        archaeologicalFinds.ForEach(Console.WriteLine);
        Console.WriteLine(ArchaeologicalFind.TotalFindsNumber);
    }

    private static bool ReadFind(IReadOnlyList<string> data, out ArchaeologicalFind archaeologicalFind)
    {
        archaeologicalFind = null;

        try
        {
            archaeologicalFind = new ArchaeologicalFind(int.Parse(data[0]), int.Parse(data[1]), data[2]);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
            return false;
        }

        return true;
    }
}