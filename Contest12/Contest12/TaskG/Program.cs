using System;
using System.Collections.Generic;

public partial class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

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

        var groups = GetGroups(users);

        GetQueryResult(groups, m).ForEach(Console.WriteLine);
    }
}