using System;
using System.Collections.Generic;

public class TeamLead : Programmer
{
    private readonly List<Programmer> programmers;

    public TeamLead(int id, List<Programmer> programmers) : base(id)
    {
        throw new NotImplementedException();
    }

    public List<Programmer> Programmers
    {
        get { throw new NotImplementedException(); }
    }

    public void HuntProgrammers(List<TeamLead> teamLeads)
    {
        throw new NotImplementedException();
    }

    public int GetWrittenLinesOfCode()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return String.Format("Team lead #{0}\nAmount of programmers in team: {1}", Id, programmers.Count);
    }
}