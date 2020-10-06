using System;

partial class Program
{
    private static bool TryParseInput(string inputA, string inputB, out int a, out int b)
    {
        bool aIsOk = int.TryParse(inputA, out a) && a >= 0;
        bool bIsOk = int.TryParse(inputB, out b) && b >= 0;
        return aIsOk && bIsOk;
    }

    private static char GetMaxDigit(char[] charr)
    {
        char maxChar = charr[0];
        foreach (char ch in charr)
        {
            if (ch > maxChar)
            {
                maxChar = ch;
            }
        }
        return maxChar;
    }

    static void ReplaceAWithB(char[] charr, char a, char b)
    {
        for (int i=0; i < charr.Length; i++)
        {
            if (charr[i] == a)
            {
                charr[i] = b;
            }
        }
    }

    private static void SwapMaxDigit(ref int a, ref int b)
    {
        char[] aByDigits = a.ToString().ToCharArray();
        char[] bByDigits = b.ToString().ToCharArray();
        char maxADigit = GetMaxDigit(aByDigits);
        char maxBDigit = GetMaxDigit(bByDigits);
        ReplaceAWithB(aByDigits, maxADigit, maxBDigit);
        ReplaceAWithB(bByDigits, maxBDigit, maxADigit);
        string outputA = new string(aByDigits);
        a = int.Parse(outputA);
        string outputB = new string(bByDigits);
        b = int.Parse(outputB);
    }
}