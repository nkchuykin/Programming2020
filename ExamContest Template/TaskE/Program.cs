using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        var firstTeam = new Team();
        var secondTeam = new Team();
        
        for (int i = 0; i < n; i++)
        {
            try
            {
                firstTeam += Player.Parse(Console.ReadLine());
            }
            catch (ArgumentException argumentException)
            {
                Console.WriteLine(argumentException.Message);
            }
        }

        for (int i = 0; i < m; i++)
        {
            try
            {
                secondTeam += Player.Parse(Console.ReadLine());
            }
            catch (ArgumentException argumentException)
            {
                Console.WriteLine(argumentException.Message);
            }
        }
        
        Console.WriteLine($"{firstTeam.Skill:F3}");
        Console.WriteLine($"{secondTeam.Skill:F3}");

        if (firstTeam.CompareTo(secondTeam) == 0)
        {
            Console.WriteLine("Teams are equal");
        }
        else if (firstTeam > secondTeam && firstTeam.CompareTo(secondTeam) > 0)
        {
            Console.WriteLine("Team 1");
        }
        else if (firstTeam < secondTeam && firstTeam.CompareTo(secondTeam) < 0)
        {
            Console.WriteLine("Team 2");
        }
    }
}