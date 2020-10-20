using System;

    public partial class Program
    {
        static void Main(string[] args)
        {
            int length;
            if (!ParseInput(Console.ReadLine(), out length) || !IsArrayLengthCorrect(length))
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            int[] arr;
            GenerateArray(length, out arr);
            double average = GetArrayAverage(arr);
            Console.WriteLine(GetSumOfNumbersLessThanAverage(arr, average));
        }
    }