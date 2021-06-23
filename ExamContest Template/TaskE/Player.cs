using System;

public class Player : IPlayer
{
    private readonly string name;
    private readonly int age;
    private readonly int speed;
    private readonly int shooting;

    private Player(string name, int age, int speed, int shooting)
    {
        throw new NotImplementedException();
    }

    public double Skill => throw new NotImplementedException();

    public static Player Parse(string str)
    {
        throw new NotImplementedException();
    }
}