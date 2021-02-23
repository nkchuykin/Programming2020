using System;

public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Student[] students = new Student[n];
        for (int i = 0; i < n; i++)
        {
            students[i] = Student.Parse(Console.ReadLine());
        }
        Console.WriteLine(Methods.GetBestInMath(students));
        Console.WriteLine(Methods.GetBestInPE(students));
    }
}