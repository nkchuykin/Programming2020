using System;

public class Ash : Tree
{
    public int leafCount;

    public Ash()
    {
    }

    public Ash(int height, int age, int leafCount) : base(height, age)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"Ash with {base.ToString()} leaf:{leafCount}";
    }
}