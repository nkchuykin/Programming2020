using System;

partial class Program
{
    public static void Main(string[] args)
    {
        if (!ValidateNumber(out int n) ||
            !ReadNumbers(n, out int[] array))
        {
            Console.WriteLine("Incorrect input");
            return;
        }

        double averageNumber = GetAverage(array);
        int countAboveAverage = GetCountGreaterThanValue(array, averageNumber);

        Console.WriteLine(countAboveAverage);
    }

}