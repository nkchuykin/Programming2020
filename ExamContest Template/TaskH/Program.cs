using System;

public class Program
{
    public static void Main(string[] args)
    {
        string filename = Console.ReadLine();
        int screenSize = int.Parse(Console.ReadLine());
        var reader = new StringByStringReader(filename);
        
        foreach (var item in reader)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine("-------");
        
        foreach (var item in reader.CutStrings(screenSize))
        {
            Console.WriteLine(item);
        }
    }
}