using System;
using System.Collections.Generic;
using System.IO;

partial class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Element> elements = new List<Element>();
        for (int i = 0; i < n; i++)
        {
            string[] data = Console.ReadLine().Split();
            elements.Add(new Element(data[0], data[1], int.Parse(data[2]), int.Parse(data[3])));
        }

        try
        {
            PlaceAll(elements);
        }
        catch (FormatException e)
        {
            using (StreamWriter sw = new StreamWriter("output.xml"))
            {
                sw.WriteLine(e.Message);
            }
            return;
        }
        DumpData(elements, "output.xml");
    }
}