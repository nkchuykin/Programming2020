using System;

partial class Program
{
    public static void Main(string[] args)
    {
        if (!TryParseInput(Console.ReadLine(), Console.ReadLine(), out int a, out int b))
        {
            Console.WriteLine("Incorrect input");
        }
        else
        {
            SwapMaxDigit(ref a, ref b);
            
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}

