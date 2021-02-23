using System;

class Biathlonist : Sportsman, ISkiRunner, IShooter
{
    public Biathlonist(int force, int agility, int endurance) : base(force, agility, endurance)
    {
    }

    int ISkiRunner.Run()
    {
        return (int)(0.5 * force + 0.1 * agility + 0.4 * endurance);
    }

    int IShooter.Shoot()
    {
        return (int)(0.3 * force + 0.4 * agility + 0.3 * endurance);
    }

    internal static Biathlonist Parse(string input)
    {
        try
        {
            int[] ints = Array.ConvertAll(input.Split(), int.Parse);
            if (ints.Length > 3)
                throw new ArgumentException();
            return new Biathlonist(ints[0], ints[1], ints[2]);
        }
        catch
        {
            throw new ArgumentException("Incorrect biathlonist");
        }
    }
}