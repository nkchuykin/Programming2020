using System;

partial class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if (Validate(n))
            Console.WriteLine(DivisorsSum(n));
        else
            Console.WriteLine("Incorrect input");
    }
}
