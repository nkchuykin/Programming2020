using System.Collections.Generic;
using System.IO;
using System.Linq;

public partial class Program
{
    private const string InputPath = "input.txt";
    private const string OutputPath = "output.txt";
        
    public static void Main()
    {
        List<Point> points = GetPoints();
        HashSet<Point> uniquePoints = GetUnique(points);
        
        using var sw = new StreamWriter(OutputPath);
        sw.WriteLine(points.Count);
        sw.WriteLine(uniquePoints.Count);
        uniquePoints.ToList().ForEach(sw.WriteLine);
    }
}