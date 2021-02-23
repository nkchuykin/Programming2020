using System;

class Program
{
    public static void Main(string[] args)
    {
        int teamLeadsAmount = int.Parse(Console.ReadLine());
        int[] programmersAmount = Array.ConvertAll(
            Console.ReadLine().Split(' '), int.Parse);

        var company = new Company(teamLeadsAmount, programmersAmount);
        
        company.PrintTeams();
        
        foreach (var teamLead in company.TeamLeads)
        {
            teamLead.HuntProgrammers(company.TeamLeads);
        }

        company.PrintTeams();
    }
}