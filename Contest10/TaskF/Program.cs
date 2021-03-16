using System;

class Program
{
    public static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine(Methods.Max<double>(x,y));
    }
}