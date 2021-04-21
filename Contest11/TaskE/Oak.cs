using System;

public class Oak : Tree
{
    public int acornCount;

    public Oak()
    {
    }

    public Oak(int height, int age, int acornCount) : base(height, age)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"Oak with {base.ToString()} acorn:{acornCount}";
    }

}