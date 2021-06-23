using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] inputLines = new string[n];
        
        for (int i = 0; i < n; i++)
        {
            inputLines[i] = Console.ReadLine();
        }

        double minWeight = double.Parse(Console.ReadLine());
        int neededHeight = int.Parse(Console.ReadLine());

        try
        {
            Console.WriteLine(Gnome.GetGnome(inputLines, minWeight, neededHeight));
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}