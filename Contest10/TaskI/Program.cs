using System;

class Program
{
    public static void Main(string[] args)
    {
        JsonReader jsonReader = new JsonReader("input.txt");
        Console.WriteLine(jsonReader.TheSickestStreet);
    }
}