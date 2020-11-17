using System;
using System.Collections.Generic;

public abstract class Gift
{
    public int ID { get; set; }

    public Gift(int id)
    {
        ID = id;
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Gift[] gifts = new Gift[n];
        for (int i = 0; i < n; i++)
            gifts[i] = GiftCreator.CreateGift(Console.ReadLine());
        for (int i = 0; i < n; i++)
            Console.WriteLine(gifts[i].ID);
    }
}

