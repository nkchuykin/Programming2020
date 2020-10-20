using System;

partial class Program
{
    public static void Main(string[] args)
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine(Count(arr, k));
    }
}