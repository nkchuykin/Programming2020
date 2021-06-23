using System;

partial class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] data = Console.ReadLine().Split();
            switch (data[0])
            {
                case "string":
                    Planet<string>.CreatePlanet(int.Parse(data[1]), data[2], data[3]);
                    break;
                case "int":
                    Planet<int>.CreatePlanet(int.Parse(data[1]), int.Parse(data[2]), data[3]);
                    break;
                default:
                    ChangeStarSystem(int.Parse(data[1]), data[2]);
                    break;
            }
        }

        Planet<string>.Planets.ForEach(Console.WriteLine);
        Planet<int>.Planets.ForEach(Console.WriteLine);
    }
}