using System;

class Program
{
    static void Main(string[] args)
    {
        Function func;
        try
        {
            func = Function.GetFunction(Console.ReadLine());
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        string[] section = Console.ReadLine().Split(' ');
        double a = double.Parse(section[0]);
        double b = double.Parse(section[1]);
        double step = double.Parse(Console.ReadLine());
        double result;
        try
        {
            result = Function.SolveIntegral(func, a, b, step);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        Console.WriteLine($"{result:F3}");
    }
}
