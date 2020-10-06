using System;

partial class Program
{
    static void Main(string[] args)
    {
        string inputPath = "input.txt";
        string text = GetTextFromFile(inputPath);
        
        Console.WriteLine(GetSumFromText(text));
    }
}