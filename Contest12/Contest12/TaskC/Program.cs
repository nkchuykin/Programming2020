using System;
using System.Collections.Generic;

public class Program
{ 
    public static void Main(string[] args)
    {
        var first = new LinkedList<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
        var second = new LinkedList<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));

        var game = new Game(first, second);
        
        foreach (var str in game)
        {
            Console.WriteLine(str);
        }
    }
}