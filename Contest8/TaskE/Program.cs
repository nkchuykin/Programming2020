using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int M = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        Hipster[] hipsters = new Hipster[N];
        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            hipsters[i] = new Hipster(int.Parse(input[0]), int.Parse(input[1]));
        }
        try
        {
            Kikstarter kikstarter = new Kikstarter(M, hipsters);
            Console.WriteLine(kikstarter.Run());
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

