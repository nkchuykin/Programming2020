using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public partial class Program
{
    public static void Main(string[] args)
    {
        using var sr = new StreamReader("input.txt");
        
        int customerAge = int.Parse(sr.ReadLine());
        int topItems = int.Parse(sr.ReadLine());
        var items = JsonSerializer.Deserialize<List<Item>>(sr.ReadLine());
        var customers = JsonSerializer.Deserialize<List<Customer>>(sr.ReadLine());
        var customersItems = JsonSerializer.Deserialize<List<CustomerItem>>(sr.ReadLine());
            
        var topCategories = GetTopCategories(items, customersItems, customers, customerAge, topItems);
        topCategories.ForEach(Console.WriteLine);
    }
}