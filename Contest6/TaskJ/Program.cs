using System;
using System.Collections.Generic;

class Program
{
    public static List<Folder.Backup> backups = new List<Folder.Backup>();

    static void Main(string[] args)
    {
        string s;
        Folder folder = new Folder();
        while (!String.IsNullOrEmpty(s = Console.ReadLine()))
        {
            string[] comand = s.Split();
            string filename;

            switch (comand[0])
            {
                case "create":
                    filename = comand[1];
                    int size = int.Parse(comand[2]);
                    try
                    {
                        folder.AddFile(filename, size);
                        Console.WriteLine($"Sucsessfully added {filename}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "print_by_name":
                    filename = comand[1];
                    try
                    {
                        Console.WriteLine(folder[filename]);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "print_by_number":
                    int fileNumber = int.Parse(comand[1]);
                    try
                    {
                        Console.WriteLine(folder[fileNumber]);
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "remove":
                    try
                    {
                        filename = comand[1];
                        folder.RemoveFile(folder[filename]);
                        Console.WriteLine($"Sucsessfully removed {filename}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "backup":
                    backups.Add(folder.GetBackup());
                    Console.WriteLine($"Sucsessfully created {backups.Count - 1}");
                    break;
                case "restore":
                    int backupNumber = int.Parse(comand[1]);
                    folder.RestoreBackup(backups[backupNumber]);
                    Console.WriteLine($"Sucsessfully restored");
                    break;
                case "show_all":
                    Console.WriteLine(folder);
                    break;
            }
        }
        Console.Out.Close();
    }
}
