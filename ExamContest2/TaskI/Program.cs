using System;

internal class Program
{
    private const string Path = "input.txt";
    
    public static void Main(string[] args)
    {
        int[] arr = Reader.ReadFile(Path);
        Console.WriteLine(string.Join(" " ,arr));
    }
}