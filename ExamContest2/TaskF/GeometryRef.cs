using System;
using System.Collections.Generic;

public class GeometryRef
{
    protected List<Point> points;

    protected virtual List<Point> Points
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    protected GeometryRef(List<Point> points)
    {
    }

    protected virtual double GetPerimeter()
    {
        throw new NotImplementedException();
    }

    public virtual double GetSquare()
    {
        throw new NotImplementedException();
    }

    public static GeometryRef Parse(string line)
    {
        throw new NotImplementedException();
    }
}