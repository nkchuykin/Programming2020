using System;
using System.IO;

public class Wizard : LegendaryHuman
{

    public Wizard(string name, int healthPoints, int power, string rank) : base(name, healthPoints,
        power)
    {
        throw new NotImplementedException();
    }

    public override void Attack(LegendaryHuman enemy)
    {
        throw new NotImplementedException();
    }
}