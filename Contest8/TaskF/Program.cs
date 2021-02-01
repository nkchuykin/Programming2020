using System;

class Program
{
    public static Calc func;
    static void Main()
    {
        double start = double.Parse(Console.ReadLine());
        int[] args = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));
        StackCalculator.CreateRules(args);
        func(ref start);
        Console.WriteLine(start.ToString("f3"));
    }
}

