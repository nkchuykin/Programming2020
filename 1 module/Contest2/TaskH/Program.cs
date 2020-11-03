using System;

partial class Program
{
    static void Main(string[] args)
    {
        string dayOfWeek = Console.ReadLine();
        int firstNumberInput = int.Parse(Console.ReadLine());
        int secondNumberInput = int.Parse(Console.ReadLine());
        int result = MorningWorkout(dayOfWeek, firstNumberInput, secondNumberInput);
        if (result == int.MinValue)
            Console.WriteLine("Incorrect input");
        else
            Console.WriteLine(result);
    }
}
