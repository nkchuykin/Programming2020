using System;

partial class Program
{
    private static int GetCountGreaterThanValue(int[] array, double average)
    {
        int greatCounter = 0;
        foreach (int item in array)
        {
            if (item > average)
            {
                greatCounter++;
            }
        }
        return greatCounter;
    }

    private static double GetAverage(int[] array)
    {
        int arraySum = 0;
        foreach (int i in array)
        {
            arraySum += i;
        }
        return (double)arraySum / array.Length;
    }

    private static bool ValidateNumber(out int n)
    {
        if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
        {
            return false;
        }
        return true;
    }

    private static bool ReadNumbers(int n, out int[] array)
    {
        array = new int[n];
        for (int i = 0; i < n; i++)
        {
            if (!ValidateNumber(out array[i]))
            {
                return false;
            }
        }
        return true;
    }
}