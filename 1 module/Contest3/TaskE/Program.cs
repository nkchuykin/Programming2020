using System;

partial class Program
{
    public static void Main(string[] args)
    {
        int[] numberArray = ParseInput(Console.ReadLine());
        
        Console.WriteLine(GetMaxInArray(numberArray));
    }
}