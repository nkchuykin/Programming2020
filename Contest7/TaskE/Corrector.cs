using System;

class Corrector : Editor
{
    private readonly char hateSymbol;
    private readonly char favouriteSymbol;

    private Corrector(string name, int salary, char hateSymbol, char favouriteSymbol) : base(name, salary)
    {
        this.hateSymbol = hateSymbol;
        this.favouriteSymbol = favouriteSymbol;
    }

    public new string EditHeader(string header)
    {
        return base.EditHeader(header.Replace(hateSymbol, favouriteSymbol));
    }

    public static Corrector Parse(string line)
    {
        string[] words = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        if (words.Length != 4 || !int.TryParse(words[1], out int payment) ||
            !char.TryParse(words[2], out char hateSymbol) ||
            !char.TryParse(words[3], out char favouriteSymbol) || payment < 0)
        {
            throw new ArgumentException("Incorrect input");
        }

        return new Corrector(words[0], payment, hateSymbol, favouriteSymbol);
    }
}