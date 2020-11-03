using System;
using System.Globalization;

partial class Program
{
    public static void Main(string[] args)
    {
        double[] array = ReadNumbers(Console.ReadLine());

        Console.WriteLine($"{GetMin(array):F2}{Environment.NewLine}" +
                          $"{GetAverage(array):F2}{Environment.NewLine}" +
                          $"{GetMedian(array):F2}");
    }
}