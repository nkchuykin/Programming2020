using System;

partial class Program
{
    public static void Main(string[] args)
	{
        int[] arr1, arr2;
        int n;
        if (!Polynom.TryParsePolynom(Console.ReadLine(), out arr1) || 
            !Polynom.TryParsePolynom(Console.ReadLine(), out arr2) || 
            !int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Incorrect input");
            return;
        }
        Console.WriteLine(Polynom.PolynomToString(Polynom.Sum(arr1, arr2)));
        Console.WriteLine(Polynom.PolynomToString(Polynom.Dif(arr1, arr2)));
        Console.WriteLine(Polynom.PolynomToString(Polynom.MultiplyByNumber(arr1, n)));
        Console.WriteLine(Polynom.PolynomToString(Polynom.MultiplyByPolynom(arr1, arr2)));
    }
}

