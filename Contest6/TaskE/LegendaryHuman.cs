using System;
using System.IO;

public abstract class LegendaryHuman
{
    public string Name { get; set; }
    
    public int Power { get; set; }

    public int HealthPoints { get; set; }

    public LegendaryHuman(string name, int healthPoints, int power)
    {
        if (healthPoints < 50 || healthPoints > 300)
        {
            throw new ArgumentException("Invalid health points value.");
        }

        if (power < 5 || power > 75)
        {
            throw new ArgumentException("Invalid power value.");
        }
        
        Name = name;
        Power = power;
        HealthPoints = healthPoints;
    }

    public abstract void Attack(LegendaryHuman enemy);
}