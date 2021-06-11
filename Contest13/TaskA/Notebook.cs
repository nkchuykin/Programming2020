using System;

public class Notebook : Product
{
    private readonly string color;
    
    public Notebook(long id, string color) : base(id)
    {
        throw new NotImplementedException();
    }
    
    public override string ToString() => throw new NotImplementedException();
}