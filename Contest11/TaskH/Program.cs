using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine().Split();
            try
            {
                if (command[0] == "explicit")
                {
                    MartianInt martianInt = new MartianInt(int.Parse(command[1]));
                    int newInt = (int) martianInt;
                    Console.WriteLine(newInt);
                }
                else
                {
                    MartianInt newMartianInt = int.Parse(command[1]);
                    Console.WriteLine(newMartianInt.Value);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}