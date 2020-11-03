using System;

internal static class Program
{
    private static Point GetPointFromInput()
    {
        double[] coordinates = Array.ConvertAll(Console.ReadLine().Split(' '),
            x => double.Parse(x));
        
        return new Point(coordinates[0], coordinates[1]);
    }
    
    private static void Main(string[] args)
    {
        var a = GetPointFromInput();
        var b = GetPointFromInput();
        var c = GetPointFromInput();

        var triangle = new Triangle(a, b, c);

        Console.WriteLine($"{triangle.GetPerimeter():F3}{Environment.NewLine}{triangle.GetSquare():F3}");

        if (triangle.GetAngleBetweenEqualsSides(out double angle))
        {
            Console.WriteLine($"equilateral: {angle:F3}");
        }

        if (triangle.GetHypotenuse(out double hypotenuse))
        {
            Console.WriteLine($"rectangular: {hypotenuse:F3}");
        }
    }
}