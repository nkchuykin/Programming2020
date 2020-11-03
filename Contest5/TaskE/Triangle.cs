using System;

public class Triangle
{
    private readonly Point a;
    private readonly Point b;
    private readonly Point c;

    private double AB => GetLengthOfSide(a, b);
    private double AC => GetLengthOfSide(a, c);
    private double BC => GetLengthOfSide(b, c);

    public Triangle(Point a, Point b, Point c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double GetPerimeter()
    {
        throw new NotImplementedException();
    }

    public double GetSquare()
    {
        throw new NotImplementedException();
    }

    public bool GetAngleBetweenEqualsSides(out double angle)
    {
        throw new NotImplementedException();
    }

    public bool GetHypotenuse(out double hypotenuse)
    {
        throw new NotImplementedException();
    }

    
    private static double GetLengthOfSide(Point first, Point second)
    {
        throw new NotImplementedException();
    }
}