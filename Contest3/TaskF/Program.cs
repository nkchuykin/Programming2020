using System;

partial class Program
{
    public static void Main(string[] args)
    {
        int[] first = ParseInput(Console.ReadLine());
        int[] second = ParseInput(Console.ReadLine());
        
        Console.WriteLine(GetNumberOfEqualElements(first, second));
    }
}