using System;
using System.Collections.Generic;

public class Game
{
    public static IList<IHelper> helpers = new List<IHelper>();
    public static int numberOfPlayedRounds = 0;
    private readonly int numberOfRounds;

    public Game(int numberOfHeroes, int numberOfPlumbers, int numberOfMarios, int numberOfRounds)
    {
        throw new NotImplementedException();
    }

    public void Play()
    {
        throw new NotImplementedException();
    }
}