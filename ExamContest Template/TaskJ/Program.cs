using System;
using System.Collections.Generic;

partial class Program
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        List<Work> marks = new List<Work>();

        IEnumerable<StudentMark> results = GetStudentMarks(students, marks);

        int students_count = int.Parse(Console.ReadLine());
        int works_count = int.Parse(Console.ReadLine());

        for (int i = 0; i < students_count; i++)
        {
            students.Add(Student.Parse(Console.ReadLine()));
        }

        for (int i = 0; i < works_count; i++)
        {
            marks.Add(Work.Parse(Console.ReadLine()));
        }


        foreach (var st in results)
        {
            Console.WriteLine($"{st.FIO} {st.Mark}");
        }
    }
}