using System;
using System.Collections.Generic;

public class Figure : IFigure
{
    public List<Point> Points { get; }

    private Figure(List<Point> points)
    {
        Points = points;
    }

    public static Figure Parse(string str)
    {
        string[] words = str.Split(';');

        var onePoint = Point.Parse(words[1]);
        var twoPoint = Point.Parse(words[2]);
        var threePoint = Point.Parse(words[3]);

        return words[0] switch
        {
            "Triangle" => new Figure(new List<Point> {onePoint, twoPoint, threePoint}),
            "Rectangle" => new Figure(new List<Point> {onePoint, twoPoint, threePoint, Point.Parse(words[4])}),
            _ => throw new ArgumentException("Incorrect input")
        };
    }
}