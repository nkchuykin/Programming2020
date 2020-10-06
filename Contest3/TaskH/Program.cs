using System;

partial class Program
{
    static void Main(string[] args)
    {
        string inputFilePath = "code.cs";
        string outputFilePath = "cleanCode.cs";
        string[] codeWithComments = ReadCodeLines(inputFilePath);
        string[] codeWithoutComments = CleanCode(codeWithComments);
        
        WriteCode(outputFilePath, codeWithoutComments);
    }
}