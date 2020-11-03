using System;

partial class Program
{
    public static void Main(string[] args)
	{
        Matrix matrix = new Matrix("matrix.txt");
        Console.Write(matrix);
        Console.WriteLine(matrix.SumOffEvenElements);
    }
}

