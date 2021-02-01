using System;

public delegate void AtackHeroOnPosition(Mob hero, int position);
public class Game
{
    public AtackHeroOnPosition attackHero;
    public Game(int castlePosition, int countOfMonster, Hero hero, Boss boss)
    {
        throw new NotImplementedException();
    }
    public void Play()
    {
        throw new NotImplementedException();
    }
}
