using System;
using System.Collections.Generic;

public class Program
{
    public static double FreeSpace;

    public static void Main()
    {
        var downloadsQueue = new List<IDownload>();
        FreeSpace = int.Parse(Console.ReadLine());
        var numberOfDownloads = int.Parse(Console.ReadLine());

        for (var i = 0; i < numberOfDownloads; ++i)
        {
            var args = Console.ReadLine().Split(';');
            switch (args[0].ToLower())
            {
                case "movie":
                    downloadsQueue.Add(new Download<Movie>(new Movie(int.Parse(args[1]), args[2],
                        short.Parse(args[3]), short.Parse(args[4]), args[5])));
                    break;
                case "track":
                    downloadsQueue.Add(new Download<Track>(new Track(int.Parse(args[1]), args[2],
                        args[3], args[4], short.Parse(args[5]))));
                    break;
                case "game":
                    downloadsQueue.Add(new Download<Game>(new Game(int.Parse(args[1]), args[2],
                        args[3], args[4], short.Parse(args[5]))));
                    break;
                default:
                    downloadsQueue.Add(new Download<Content>(new Content(int.Parse(args[1]), args[2])));
                    break;
            }
        }

        Loader.Download(downloadsQueue);
    }
}