using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var viruses = new Virus[n];
        for (int i = 0; i < n; i++)
        {
            string[] inputArgs = Console.ReadLine().Split(' ');
            viruses[i] = new Virus(
                int.Parse(inputArgs[0]),
                double.Parse(inputArgs[1]),
                int.Parse(inputArgs[2])
            );
        }

        viruses = bool.Parse(Console.ReadLine())
            ? (from virus in viruses orderby virus select virus).ToArray()
            : (from virus in viruses orderby virus descending select virus).ToArray();

        int firstN = int.Parse(Console.ReadLine());
        int lastN = int.Parse(Console.ReadLine());
        try
        {
            Virus first = Virus.GetSum(viruses, firstN);
            Virus second = Virus.GetDifference(viruses, lastN);
            Console.WriteLine(first + second);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}