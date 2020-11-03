using System;

public static partial class Program
{
    public static void Main()
    {
        const string inputFilePath = "rick.in";
        const string outputFilePath = "morty.out";
        WriteCount(outputFilePath, GetCountCapitalLetters(inputFilePath));
    }
}