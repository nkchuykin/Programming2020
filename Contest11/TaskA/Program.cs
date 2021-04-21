using System;
using System.IO;
using System.Runtime.Serialization.Json;

public class Program
{
    private static Ingredient[] ReadReceipt(string path)
    {
        using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            var formatter = new DataContractJsonSerializer(typeof(Ingredient[]));
            return (Ingredient[])formatter.ReadObject(fs);
        }
    }
    
    public static void Main(string[] args)
    {
        Ingredient[] ingredients = ReadReceipt("input.json");
        Array.Sort(ingredients);
        Array.ForEach(ingredients, Console.WriteLine);

        Soup soup = new Soup(ingredients);
        Console.WriteLine($"Vasya will {(soup.WillEat ? "" : "not ")}eat it.");
    }
}