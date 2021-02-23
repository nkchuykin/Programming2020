using System;
public class Program
{
    public static void Main(string[] args)
    {
        var gameArgs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        Game game = new Game(gameArgs[0], gameArgs[1], gameArgs[2], gameArgs[3]);
        game.Play();
        Console.WriteLine(Game.helpers.Count);
    }
}