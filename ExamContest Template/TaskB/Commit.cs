using System;

public class Commit
{
    private int id;
    private string content;
    public int Id => id;
    public string Content => content;

    public static Commit MergeAllCommits(Commit[] commits, Commit mergeIn, Func<Commit, Commit, Commit> mergeCommits,
        Predicate<Commit> canCommitMerged)
    {
        throw new NotImplementedException();
    }

    public static Commit MergeCommits(Commit commit1, Commit commit2)
    {
        throw new NotImplementedException();
    }
    
    public Commit(int id, string content)
    {
        throw new NotImplementedException();
    }
}