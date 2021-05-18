using System;
using System.Collections.Generic;

public partial class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        var users = new List<User>(n);

        for (var i = 0; i < n; i++)
        {
            try
            {
                users.Add(User.Parse(Console.ReadLine()));
            }
            catch (ArgumentException argumentException)
            {
                Console.WriteLine(argumentException.Message);
            }
        }
        
        Console.WriteLine($"{GetAverage(users):f2}");
    }
}