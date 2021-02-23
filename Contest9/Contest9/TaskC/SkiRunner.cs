using System;

public class SkiRunner : Sportsman, ISkiRunner
{
    public SkiRunner(int force, int agility, int endurance) : base(force, agility, endurance)
    {
    }

    int ISkiRunner.Run()
    {
        return (int) (0.5 * force + 0.2 * agility + 0.3 * endurance);
    }

    internal static SkiRunner Parse(string input)
    {
        try
        {
            int[] ints = Array.ConvertAll(input.Split(), int.Parse);
            if (ints.Length > 3)
                throw new ArgumentException();
            return new SkiRunner(ints[0], ints[1], ints[2]);
        }
        catch
        {
            throw new ArgumentException("Incorrect skirunner");
        }
    }
}