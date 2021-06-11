using System;
using System.Numerics;

public partial class Program
{
    public static void Main(string[] args)
    {
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        
        BigInteger[,] array = GetArrayPart(x1, y1, x2, y2);

        for (int i = x1; i <= x2; ++i)
        {
            for (int j = y1; j <= y2; ++j)
            {
                Console.Write($"{array[i,j]}\t");
            }
            
            Console.WriteLine();
        }
    }
}