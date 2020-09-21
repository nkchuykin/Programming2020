using System;

partial class Program
{
    private const int MinYear = 1701;
    private const int MaxYear = 1800;

    private static string GetFormatMessage(int day, int month, int year)
    {
        return String.Format("{0:D2}.{1:D2}.{2:D4}",day,month,year);
    }

    private static void Main(string[] args)
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());

        if (!ValidateData(day, month, year))
        {
            Console.WriteLine("Incorrect input");
            return;
        }

        int dateOfWeek = GetDayOfWeek(day, month, year);

        string outputMessage = GetDateOfFriday(dateOfWeek, day, month, year);

        Console.WriteLine(outputMessage);
    }
}