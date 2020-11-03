using System;
using System.IO;

partial class Program
{
    public static void Main(string[] args)
	{
        int[] vector;
        bool valid = TryParseVectorFromFile("vector.txt", out vector);
        if (!valid)
        {
            File.WriteAllText("matrix.txt", "Incorrect input");
            return;
        }
        int[,] matrix = MakeMatrixFromVector(vector);
        WriteMatrixToFile(matrix, "matrix.txt");
    }
}

