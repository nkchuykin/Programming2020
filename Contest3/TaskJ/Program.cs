using System;
using System.Collections.Generic;
using System.IO;

partial class Program
{
    public static void Main(string[] args)
    {
        if (!ValidateQuery(File.ReadAllLines("query.txt")[0], out string[] queryParameters))
        {
            File.WriteAllLines("queryResult.txt", new List<string> {"Incorrect input"});
            return;
        }
        
        File.WriteAllLines("queryResult.txt", ProcessQuery(queryParameters, "db.txt"));
    }
}
