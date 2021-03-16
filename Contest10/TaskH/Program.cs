using System;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        string type = Console.ReadLine();
        if (type == "int_array")
        {
            TestIntArray();
        }
        else
        {
            TestString();
        }
    }

    private static void TestString()
    {
        MyList<string> obj = CreateMyList<string>();
        string line;
        // Для завершения программы в Windows необходимо нажать комбинацию Ctrl+Z(символ конца потока), а затем нажать Enter
        while ((line = Console.ReadLine()) != null)
        {
            string[] comand = line.Split();
            switch (comand[0])
            {

                case "add":
                    obj.Add(string.Join(' ', comand[1..]));
                    break;
                case "get":
                    try
                    {
                        Console.WriteLine(obj[int.Parse(comand[1])]);
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "count":
                    Console.WriteLine(obj.Count);
                    break;
                case "capacity":
                    Console.WriteLine(obj.Capacity);
                    break;
                case "clear":
                    obj.Clear();
                    break;
                case "remove_last":
                    try
                    {
                        obj.RemoveLast();
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "remove_at":
                    try
                    {
                        obj.RemoveAt(int.Parse(comand[1]));
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case "max":
                    try
                    {
                        Console.WriteLine(obj.Max());
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "print":
                    Console.WriteLine(obj);
                    break;
            }
        }
    }


    private static void TestIntArray()
    {
        MyList<int[]> obj = CreateMyList<int[]>();
        string line;
        // Для завершения программы в Windows необходимо нажать комбинацию Ctrl+Z(символ конца потока), а затем нажать Enter
        while ((line = Console.ReadLine()) != null)
        {
            string[] comand = line.Split();
            switch (comand[0])
            {

                case "add":
                    obj.Add(Array.ConvertAll(comand[1..], int.Parse));
                    break;
                case "get":
                    try
                    {
                        Console.WriteLine(obj[int.Parse(comand[1])]);
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "count":
                    Console.WriteLine(obj.Count);
                    break;
                case "capacity":
                    Console.WriteLine(obj.Capacity);
                    break;
                case "clear":
                    obj.Clear();
                    break;
                case "remove_last":
                    try
                    {
                        obj.RemoveLast();
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "remove_at":
                    try
                    {
                        obj.RemoveAt(int.Parse(comand[1]));
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case "max":
                    try
                    {
                        Console.WriteLine(obj.Max());
                    }
                    catch (NotSupportedException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "print":
                    Console.WriteLine(obj);
                    break;
            }

        }
    }

    private static MyList<T> CreateMyList<T>()
    {
        MyList<T> obj;
        string construct = Console.ReadLine();
        if (construct == "empty")
            obj = new MyList<T>();
        else
        {
            int capacity = int.Parse(construct.Split()[1]);
            obj = new MyList<T>(capacity);
        }
        return obj;
    }


}