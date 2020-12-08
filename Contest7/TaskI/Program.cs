using System;

class Program
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        string regex = Console.ReadLine();
        string replace = Console.ReadLine();
        RegularExpression expression = new RegularExpression(regex);

        Console.WriteLine(expression.FindAndReplace(text, replace));
    }
}