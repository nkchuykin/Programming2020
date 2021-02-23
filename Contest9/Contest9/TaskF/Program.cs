using System;

public class Program
{
    static string Compare(IComparable first, IComparable second)
    {
        if (first.CompareTo(second) > 0)
            return "FIRST";
        if (first.CompareTo(second) < 0)
            return "SECOND";
        return "SAME";
    }


    static void Main(string[] args)
    {
        try
        {
            Vector first = Vector.Parse(Console.ReadLine());
            Vector second = Vector.Parse(Console.ReadLine());
            Console.WriteLine(Compare(first, second));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}