using System;

partial class Program
{
    public static void Main(string[] args)
    {
        if (!Validate(Console.ReadLine(), out int num))
        {
            Console.WriteLine("Incorrect input");
            return;
        }

        Console.WriteLine(RecurrentFunction(num));
    }
}
