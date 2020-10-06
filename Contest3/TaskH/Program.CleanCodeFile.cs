using System;
using System.IO;
using System.Collections.Generic;

partial class Program
{
    private static string[] ReadCodeLines(string codePath)
    {
        string[] lines = File.ReadAllLines(codePath);
        return lines;
    }

    private static string[] CleanCode(string[] codeWithComments)
    {
        string[] cleanCode = new string[codeWithComments.Length];
        int linePosition = 0;
        bool isBigComment = false;
        foreach (string line in codeWithComments)
        {
            bool isOk = !isBigComment;
            for (int i = 1; i < line.Length; i++)
            {
                if (line[i] == '/' && line[i-1] == '/')
                {
                    isOk = false;
                }
                if (line[i] == '*' && line[i-1] == '/')
                {
                    isBigComment = true;
                    isOk = false;
                }
                if (line[i] == '/' && line[i-1] == '*')
                {
                    isBigComment = false;
                }
            }
            if (isOk)
            {
                cleanCode[linePosition++] = line;
            }
        }
        Array.Resize(ref cleanCode, linePosition);
        return cleanCode;
    }
    private static void WriteCode(string codeFilePath, string[] codeLines)
    {
        File.Create(codeFilePath);
        File.WriteAllLines(codeFilePath, codeLines);
    }
}