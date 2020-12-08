using System;

public class Program
{
    public static void Main(string[] args)
    {
        int countOfUsers = int.Parse(Console.ReadLine());
        int countOfPrizes = int.Parse(Console.ReadLine());
        string[] logins = GetStringArrayFromConsole(countOfUsers);
        string[] prizes = GetStringArrayFromConsole(countOfPrizes);
        MyGiveawayHelper generator = new MyGiveawayHelper(logins, prizes);
        while (generator.HasPrizes)
        {
            var result = generator.GetPrizeLogin();
            Console.WriteLine($"User {result.login} won {result.prize}");
        }
    }

    private static string[] GetStringArrayFromConsole(int n)
    {
        string[] arr = new string[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = Console.ReadLine();
        }

        return arr;
    }
}