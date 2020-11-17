using System;

public class Polygon
{
    private double area;

    private double perimeter;
    
    public virtual double Area => area;
    
    public virtual double Perimeter => perimeter;

    protected Polygon()
    {
        
    }
    
    public Polygon(double area, double perimeter)
    {
        if (area <= 0 || perimeter <= 0)
        {
            throw new ArgumentException("Input parameters should be greater than zero.");
        }
        
        this.area = area;
        this.perimeter = perimeter;
    }

    public override string ToString() => $"area: {Area:f3}; perimeter: {Perimeter:f3}";
}