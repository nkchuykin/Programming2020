using System;

public class Book : Product
{
    private readonly int age;

    public Book(long id, int age) : base(id)
    {
        throw new NotImplementedException();
    }

    public override string ToString() => throw new NotImplementedException();
}