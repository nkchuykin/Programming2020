using System;

class Linguist : Editor
{

    private Linguist(string name, int salary, string bannedWord) : base(name, salary)
    {
        throw new NotImplementedException();
    }

    public new string EditHeader(string header)
    {
        throw new NotImplementedException();
    }

    public static Linguist Parse(string line)
    {
        throw new NotImplementedException();
    }
}