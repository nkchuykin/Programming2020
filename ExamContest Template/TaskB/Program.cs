using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
        var commits = new Commit[n];
        for (int i = 0; i < n; i++)
        {
            String[] lineArgs = Console.ReadLine().Split(' ');
            commits[i] = new Commit(int.Parse(lineArgs[0]), lineArgs[1]);
        }
        
        string[] lastLineArgs = Console.ReadLine().Split(' ');
        var inMergeCommit = new Commit(int.Parse(lastLineArgs[0]), lastLineArgs[1]);
        
        try
        {
            Console.WriteLine(Commit.MergeAllCommits(commits, inMergeCommit, Commit.MergeCommits,
                commit => commit.Id < commit.Content.Length));
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}