using System;
public class Lamp : Furniture
{
    public double LifeTimeSeconds => throw new NotImplementedException();

    public Lamp(long id, TimeSpan lifeTime) : base(id)
    {
        throw new NotImplementedException();
    }
}