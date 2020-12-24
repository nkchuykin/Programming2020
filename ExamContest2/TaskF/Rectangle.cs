using System;
using System.Collections.Generic;

public sealed class Rectangle : GeometryRef
{
    protected override List<Point> Points
    {
        set => throw new NotImplementedException();
    }

    public Rectangle(List<Point> points) : base(points)
    {
    }
}