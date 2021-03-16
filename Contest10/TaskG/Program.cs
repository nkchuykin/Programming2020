using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {

        string s;
        // Для заверщения программы в Windows необходимо нажать комбинацию Ctrl+Z(символ конца потока), а затем нажать Enter
        while ((s = Console.ReadLine()) != null)
        {
            string[] comand = s.Split();
            switch (comand[0])
            {
                case "add":
                    Add(comand[1], comand[2]);
                    break;
                case "print":
                    Print(comand[1]);
                    break;
                case "assign":
                    Assign(comand[1]);
                    break;
            }

        }
    }

    private static void Assign(string type)
    {
        try
        {
            if (type == "int")
            {
                Singleton<List<int>>.Instance = new List<int>();
            }
            else
            {
                Singleton<List<string>>.Instance = new List<string>();
            }
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void Print(string type)
    {
        if (type == "int")
        {
            Singleton<List<int>>.Instance.ForEach(x => Console.Write($"{x} "));
        }
        else
        {
            Singleton<List<string>>.Instance.ForEach(x => Console.Write($"{x} "));
        }
        Console.WriteLine();
    }

    private static void Add(string type, string val)
    {
        if (type == "int")
        {
            Singleton<List<int>>.Instance.Add(int.Parse(val));
            return;
        }
        Singleton<List<string>>.Instance.Add(val);
    }
}