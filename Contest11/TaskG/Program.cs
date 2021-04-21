using System;

public class Program
{
    public static void Main(string[] args)
    {
        Rational a = Rational.Parse(Console.ReadLine());
        Rational b = Rational.Parse(Console.ReadLine());
        Console.WriteLine(a + b);
        Console.WriteLine(a - b);
        Console.WriteLine(a * b);
        Console.WriteLine(a / b);
    }
}