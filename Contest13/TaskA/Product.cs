using System;

public abstract partial class Product
{
    private readonly long id;

    protected Product(long id)
    {
        throw new NotImplementedException();
    }

    public override string ToString() => throw new NotImplementedException();
}