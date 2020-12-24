using System;

internal class Program
{
    public static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double r1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double r2 = double.Parse(Console.ReadLine());
        
        Console.WriteLine(Circle.Circumference(r1).ToString("f3"));
        Console.WriteLine(Circle.Circumference(r2).ToString("f3"));
        Console.WriteLine(Circle.Square(r1).ToString("f3"));
        Console.WriteLine(Circle.Square(r2).ToString("f3"));
        Console.WriteLine(Circle.Distance(x1, y1, r1, x2, y2, r2).ToString("f3"));
    }
}