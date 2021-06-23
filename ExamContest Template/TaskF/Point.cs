using System;

public struct Point
{
    private readonly int x;
    private readonly int y;

    public int X => x;
    public int Y => y;
    private Point(int x, int y)
    {
        throw new NotImplementedException();
    }

    public static Point Parse(string str)
    {
        throw new NotImplementedException();
    }
}