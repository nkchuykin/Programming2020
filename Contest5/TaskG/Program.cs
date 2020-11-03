using System;
using System.IO;

public partial class Program
{
    static void Main(string[] args)
    {
        int count;
        if (!ParseCommandsCount(Console.ReadLine(), out count))
        {
            File.WriteAllText("logs.log", "Incorrect input");
            return;
        }
        for (int i = 0; i < count; i++)
        {
            Logger.HandleCommand(Console.ReadLine());
        }
    }
}