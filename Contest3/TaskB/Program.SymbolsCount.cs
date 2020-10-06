partial class Program
{
    private static void GetLetterDigitCount(string line, out int digitCount, out int letterCount)
    {
        digitCount = 0;
        letterCount = 0;
        foreach (char ch in line)
        {
            if (ch >= '0' && ch <= '9')
            {
                digitCount++;
            }
            if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z')
            {
                letterCount++;
            }
        }
    }
}