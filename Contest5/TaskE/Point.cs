public class Point
{
    private readonly double x;
    private readonly double y;

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public double GetX() => x;
    public double GetY() => y;
}