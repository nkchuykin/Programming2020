using System;

public class Tree 
{
    public int height;
    public int age;

    public Tree()
    {
    }

    public Tree(int height, int age)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"height:{height} age:{age}";
    }
}