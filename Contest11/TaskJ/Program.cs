using System;

public class Program
{
    public static void Main(string[] args)
    {
        var map = new Map<int, int>();
        // Input pairs number.
        int batchSize = int.Parse(Console.ReadLine());
        // Input pairs.
        for (int i = 0; i < batchSize; ++i)
        {
            var pair = Console.ReadLine().Split();
            try
            {
                map.Add(int.Parse(pair[0]), int.Parse(pair[1]));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Input keys number.
        batchSize = int.Parse(Console.ReadLine());
        // Input keys to check.
        for (int i = 0; i < batchSize; ++i)
        {
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine(map.ContainsKey(key));
            try
            {
                Console.WriteLine(map[key]);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        // Input keys to remove number.
        batchSize = int.Parse(Console.ReadLine());
        // Input keys to remove.
        for (int i = 0; i < batchSize; ++i)
        {
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine(map.Remove(key));
        }
    }
}