using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] soldiers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = int.Parse(Console.ReadLine());
        Army army;
        
        try
        {
            army = new Army(soldiers, n);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        foreach (int number in army)
        {
            Console.WriteLine(number);
        }
    }
}