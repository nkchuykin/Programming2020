using System;

internal class Program
{
    public static void Main(string[] args)
    {
        BaseArray array = new ChristmasArray(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
        var number = int.Parse(Console.ReadLine());

        try
        {
            Console.WriteLine(array[number]);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine($"{array.GetMetric():f3}");
    }
}
