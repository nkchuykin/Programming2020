using System;
using System.Collections.Generic;
using System.Linq;

public class Team
{
    private List<IPlayer> Players { get; }
    public double Skill => Players.Sum(x => x.Skill);

    public Team()
    {
        throw new NotImplementedException();
    }
}