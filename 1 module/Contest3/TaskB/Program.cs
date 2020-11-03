using System;

partial class Program
{
    public static void Main(string[] args)
    {
        GetLetterDigitCount(Console.ReadLine(), out int digitCount, out int letterCount);
        
        Console.WriteLine(digitCount);
        Console.WriteLine(letterCount);
    }
}