using System;

public partial class Program
{
    static void Main(string[] args)
    {
        int length;
        if (!int.TryParse(Console.ReadLine(), out length) || !IsArrayLengthCorrect(length))
        {
            Console.WriteLine("Incorrect input");
            return;
        }
        int[] arr;
        if(!GenerateArray(length, out arr))
        {
            Console.WriteLine("Incorrect input");
            return;
        }
        double average = GetArrayAverage(arr);
        Console.WriteLine(GetSumOfNumbersLessThanAverage(arr, average));
    }
}
