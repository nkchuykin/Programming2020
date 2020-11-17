using System;
using System.Collections.Generic;

static class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        var apples = new List<Apple>(N);

        for (int i = 0; i < N; i++)
        {
            var words = Console.ReadLine().Split(' ');
            try
            {
                apples.Add(new Apple()
                {
                    Weight = double.Parse(words[0]),
                    Color = words[1]
                });
            }
            catch (ArgumentException argumentException)
            {
                Console.WriteLine(argumentException.Message);
            }
        }

        var worker = new Worker(apples.ToArray());

        foreach (var sortedApple in worker.GetSortedApples())
        {
            Console.WriteLine(sortedApple);
        }
    }
}