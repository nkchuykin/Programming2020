using System;
using System.IO;

public class Program
{
    private static void PlaceShip<T>(string[] shipData, Ship[,] ships) where T : Ship, new()
    {
        Ship ship = new T
        {
            BowRow = int.Parse(shipData[1]),
            BowColumn = int.Parse(shipData[2]),
            IsHorizontal = bool.Parse(shipData[3])
        };

        if (ship.IsHorizontal) {
            for (var j = ship.BowColumn; j < ship.BowColumn + ship.Length; ++j) {
                ships[ship.BowRow, j] = ship;
            }
        } else {
            for (var i = ship.BowRow; i < ship.BowRow+ ship.Length; ++i) {
                ships[i, ship.BowColumn] = ship;
            }
        }
    }
    
    public static void Main(string[] args)
    {
        Ship[,] ships = new Ship[10, 10];
        
        using (var sr = new StreamReader("ships.txt"))
        {
            int shipsCount = 0;
            while (shipsCount != 10)
            {
                string[] shipData = sr.ReadLine().Split();
                ++shipsCount;
                
                switch (shipData[0])
                {
                    case nameof(Submarine):
                        PlaceShip<Submarine>(shipData, ships);
                        break;
                    case nameof(Destroyer):
                        PlaceShip<Destroyer>(shipData, ships);
                        break;
                    case nameof(Cruiser):
                        PlaceShip<Cruiser>(shipData, ships);
                        break;
                    case nameof(Battleship):
                        PlaceShip<Battleship>(shipData, ships);
                        break;
                }
            }
            
            var battlefield = new Battlefield(ships);

            while (!sr.EndOfStream)
            {
                int[] coordinates = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                Console.WriteLine(battlefield[coordinates[0], coordinates[1]]);
            }
        }
    }
}