using System;

class Program
{
    public static void Main(string[] args)
    {
        Summator summator = new Summator("input.txt");
        Console.WriteLine(summator.Sum);
    }
}