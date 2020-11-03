using System;

partial class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        if (!IsInputNumberCorrect(input))
        {
            Console.WriteLine("Incorrect input");
            return;
        }
        Console.WriteLine(Factorial(input));
    }
}
