using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        IntWrapper iw = new IntWrapper(n);
        try
        {
            Console.WriteLine(iw.FindNumberLength());
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
