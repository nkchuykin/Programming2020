using System;
using System.Collections.Generic;
using System.IO;

public partial class Program
{
    private static (string[], List<Cat>) ReadData(string path)
    {
        var cats = new List<Cat>();
        string[] catParameters;
        using (var sr = new StreamReader(path))
        {
            catParameters = sr.ReadLine().Split();
            while (!sr.EndOfStream)
            {
                string[] info = sr.ReadLine().Split();
                cats.Add(new Cat(int.Parse(info[0]), int.Parse(info[1]), info[2] == "black"));
            }
        }

        return (catParameters, cats);
    }

    public static void Main(string[] args)
    {
        (string[] catParameters, List<Cat> cats) = ReadData("cats.txt");

        List<Cat> selectedCats = ChooseCats(
            int.Parse(catParameters[0]),
            int.Parse(catParameters[1]),
            int.Parse(catParameters[2]),
            cats);

        selectedCats.ForEach(Console.WriteLine);
    }
}