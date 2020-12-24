using System;
using System.IO;

internal class Program
{
    public static void Main(string[] args)
    {
        string type = Console.ReadLine();
        int matrixSize = int.Parse(Console.ReadLine());
        Field field = new Field(new int[matrixSize][]);
        
        try
        {
            field.FillIn(type);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        Console.WriteLine(field);
    }
}