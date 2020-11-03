using System;

public partial class Program
{
    static void Main(string[] args)
    {
        int[] arr;
        if (!ParseArrayFromLine(Console.ReadLine(), out arr))
        {
            Console.WriteLine("Incorrect input");
            return;
        }
        MergeSort(arr, 0, arr.Length);
        Console.WriteLine(string.Join(" ", arr));
    }

    public static void MergeSort(int[] arr, int left, int right)
    {
        if (left + 1 >= right)
        {
            return;
        }

        int mid = (left + right) / 2;
        MergeSort(arr, left, mid);
        MergeSort(arr, mid, right);
        Merge(arr, left, right, mid);
    }
}