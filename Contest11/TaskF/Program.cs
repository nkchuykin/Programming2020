using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        ITrackingCenter center = new RoadCenter();
        for (int i = 0; i < n; i++)
        {
            string[] commands = Console.ReadLine().Split();
            switch (commands[0])
            {
                case "data":
                    center.GetData("data.json");
                    break;
                case "speedCheck":
                {
                    int cameraId = int.Parse(commands[1]);
                    int carNumber = int.Parse(commands[2]);
                    int speed = int.Parse(commands[3]);
                    center.CheckCarSpeed(cameraId, carNumber, speed);
                    break;
                }
                case "newCamera":
                {
                    int cameraId = int.Parse(commands[1]);
                    int maxSpeed = int.Parse(commands[2]);
                    center.AddCamera(cameraId, maxSpeed);
                    break;
                }
            }
        }
    }
}