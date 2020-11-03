using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{

    static void Main(string[] args)
    {
        string exp = Console.ReadLine();
        Console.WriteLine(Calculate(exp));
    }


    private static bool isCorrectSequence(string exp)
    {
        int counter = 0;
        foreach (var ch in exp)
        {
            if (ch == '(')
                counter++;
            if (ch == ')')
            {
                if (counter == 0)
                    return false;
                counter--;
            }
        }
        return counter == 0;
    }


    private static int Calculate(string exp)
    {
        if (exp.Length == 0)
            return 0;
        if (exp.All(c => char.IsDigit(c)))
            return int.Parse(exp);
        if (exp.StartsWith("(") && exp.EndsWith(")") &&
            isCorrectSequence(exp.Substring(1, exp.Length - 2)))
            return Calculate(exp.Substring(1, exp.Length - 2));
        int ind = FindIndexOfOperation(exp);
        char oper = exp[ind];
        string first = exp.Substring(0, ind),
            second = exp.Substring(ind + 1);
        switch (oper)
        {
            case '+':
                return Calculate(first) + Calculate(second);
            case '-':
                return Calculate(first) - Calculate(second);
            case '*':
                return Calculate(first) * Calculate(second);
            case '/':
                return Calculate(first) / Calculate(second);
            default:
                throw new ArgumentOutOfRangeException("Incorrect operation");
        }
    }

    private static int FindIndexOfOperation(string exp)
    {
        int ind = exp.Length - 1;
        int counter = 0;
        for (; ind >= 0; ind--)
        {
            if (counter == 0 && (exp[ind] == '+' || exp[ind] == '-'))
                if (ind == 0 || exp[ind - 1] != '*' && exp[ind - 1] != '/')
                    return ind;
            if (exp[ind] == ')')
                counter++;
            if (exp[ind] == '(')
                counter--;
        }
        ind = exp.Length - 1;
        for (; ind >= 0; ind--)
        {
            if (counter == 0 && (exp[ind] == '*' || exp[ind] == '/'))
                return ind;
            if (exp[ind] == ')')
                counter++;
            if (exp[ind] == '(')
                counter--;
        }
        return ind;
    }
}