using System;

public class Program
{
    private static Boat GetBoat(bool isBrigantine = false)
    {
        string[] data = Console.ReadLine().Split();
        int cost = int.Parse(data[0]);
        bool isAtThePort = data[1].Equals("true");

        return isBrigantine ? new Brigantine(cost, isAtThePort) : new Boat(cost, isAtThePort);
    }

    private static (string type, int weight) ParseCargoData(string input)
    {
        string[] data = input.Split();
        return (data[1], int.Parse(data[0]));
    }

    public static void Main(string[] args)
    {
        var boat = GetBoat();
        var brigantine = (Brigantine) GetBoat(true);
        (string type, int weight) = ParseCargoData(Console.ReadLine());

        if (type.Equals("Brigantine"))
        {
            Console.WriteLine(brigantine.IsAtThePort
                ? $"Brigantine. {brigantine.CountCost(weight)}$"
                : "Could not deliver cargo.");
        }
        else
        {
            Console.WriteLine(!boat.IsAtThePort
                ? $"Brigantine. {((Boat) brigantine).CountCost(weight)}$"
                : $"Boat. {boat.CountCost(weight)}$");
        }
    }
}