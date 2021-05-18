using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        List<int> list = new List<int>(input);
        IEnumerable<int> even = new OnlyEven(list);
        Console.WriteLine(string.Join(" ", even));
    }
}