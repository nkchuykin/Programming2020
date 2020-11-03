using System;

partial class Program
{
    public static void Main(string[] args)
    {
        CountInFile("input.txt", out int linesCount, out int wordsCount, out int charsCount);
        
        Console.WriteLine(linesCount);
        Console.WriteLine(wordsCount);
        Console.WriteLine(charsCount);
    }
}