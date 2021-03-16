using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

class Program
{
    public static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        string company = Console.ReadLine();
        List<string> persons = new List<string>();

        for (int i = 0; i < count; i++)
        {
            persons.Add(Console.ReadLine());
        }

        XmlDocument doc = Methods.GetDocument(company, persons);

        using (var fs = new FileStream("company.xml", FileMode.Create))
        {
            using (var sr = new StreamWriter(fs, Encoding.UTF8))
            {
                doc.Save(sr);
            }
        }
    }
}