using System;
using System.IO;

partial class Program
{
    private static string GetTextFromFile(string inputPath)
    {
        return File.ReadAllText(inputPath);
    }

    private static int GetSumFromText(string text)
    {
        string[] parsedText = text.Split(new string[] { Environment.NewLine, ".", "!", "?", " ", "," }, new StringSplitOptions());
        int sum = 0;
        int cur;
        foreach (string st in parsedText)
        {
            if (int.TryParse(st, out cur))
            {
                sum += cur;
            }
        }
        return sum;
    }
}