using System;

public delegate uint Del();

public class Program
{
    public static void Main(string[] args)
    {
        var number = new IntWrapper(int.Parse(Console.ReadLine()));
        Del del = number.FindNumberLength;
        
        try
        {
            Console.WriteLine(del());
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.GetType());
        }
    }
}

