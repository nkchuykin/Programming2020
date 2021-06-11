using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        var products = new List<Product>(n);
        for (int i = 0; i < n; i++)
        {
            try
            {
                products.Add(Product.Parse(Console.ReadLine()));
            }
            catch (ArgumentException argumentException)
            {
                Console.WriteLine(argumentException.Message);
            }
        }

        var shop = new Shop(products);

        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine(shop[i]);
        }
    }
}