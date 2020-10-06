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
            string kek = line.Trim();
            if (kek.Length == 0)
            {
                continue;
            }
            else if (kek.Length == 1)
            {
                cleanCode[linePosition++] = line;
            }
            else
            {
                if (kek[0] == '/' && kek[1] == '*')
                {
                    isBigComment = true;
                }
                if (kek[kek.Length - 2] == '*' && kek[kek.Length - 1] == '/')
                {
                    isBigComment = false;
                    continue;
                }
                if (kek[0] == '/' && kek[1] == '/')
                {
                    continue;
                }
                if (!isBigComment)
                {
                    cleanCode[linePosition++] = line;
                }
            }
        }
        Array.Resize(ref cleanCode, linePosition);
        return cleanCode;
    }
    private static void WriteCode(string codeFilePath, string[] codeLines)
    {
        //File.Create(codeFilePath);
        File.WriteAllLines(codeFilePath, codeLines);
    }
}