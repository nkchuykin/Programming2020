using System;
using System.Globalization;
using System.Threading;

partial class Program
{
    private static double GetMin(double[] array)
    {
        return array[0];
    }

    private static double GetAverage(double[] array)
    {
        double sum = 0.0;
        foreach (double d in array)
        {
            sum += d;
        }
        return sum / array.Length;
    }

    private static double GetMedian(double[] array)
    {
        int firstIndex = array.Length / 2;
        int secondIndex = firstIndex - 1 + array.Length % 2;
        return (array[firstIndex] + array[secondIndex]) / 2.0;
    }

    private static double[] ReadNumbers(string line)
    {
        string[] parsedInput = line.Split(new char[] { ' ' });
        double[] output = new double[parsedInput.Length];
        for (int i = 0; i < output.Length; i++)
        {
            output[i] = double.Parse(parsedInput[i]);
        }
        Array.Sort(output);
        return output;
    }

}