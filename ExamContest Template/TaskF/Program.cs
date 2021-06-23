using System;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            IFigure firstFigure = Figure.Parse(Console.ReadLine());
            IFigure secondFigure = Figure.Parse(Console.ReadLine());
            
            Console.WriteLine($"{firstFigure.GetPerimeter():F3} and {secondFigure.GetPerimeter():F3}");
            Console.WriteLine($"{firstFigure.GetSquare():F3} and {secondFigure.GetSquare():F3}");

            Console.WriteLine($"{firstFigure.CompareByPerimeter(secondFigure) > 0}");
            Console.WriteLine($"{firstFigure.CompareBySquare(secondFigure) > 0}");
        }
        catch (ArgumentException argumentException)
        {
            Console.WriteLine(argumentException.Message);
        }
    }
}