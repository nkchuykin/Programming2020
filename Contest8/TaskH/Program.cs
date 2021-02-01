using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate double Integral(double a, double b);

class Program
{
    public static Integral func;

    public const double EPSYLON = 10e-2;

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            double[] args = Array.ConvertAll(Console.ReadLine().Split(' '), x => double.Parse(x));
            IntegralCalculator.InsertParameter((int)args[0]);
            Console.WriteLine(func(args[1], args[2]).ToString("f3"));
        }
    }
}

