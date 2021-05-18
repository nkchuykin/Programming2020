using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    private string Surname { get; }
    private List<int> Marks { get; }

    public Student(string surname, List<int> marks)
    {
        Surname = surname;
        Marks = marks;
    }

    public static (string, List<int>) PreprocessStudentData(string data)
    {
        var input = data.Split().ToList();
        string surname = input.First();
        var marks = new List<int>(Array.ConvertAll(input.GetRange(1, input.Count - 1).ToArray(), int.Parse));
        return (surname, marks);
    }

    public double Gpa
    {
        get { return Marks.Average(); }
    }

    public override string ToString()
    {
        return $"{Surname} {string.Join(" ", Marks)}";
    }
}