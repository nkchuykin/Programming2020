using System;

public class Methods
{
    internal static Student GetBestInMath(Student[] students)
    {
        Student max = students[0];
        foreach (Student item in students)
        {
            if (item.CompareTo(max) > 0)
                max = item;
        }
        return max;
    }

    internal static Student GetBestInPE(Student[] students)
    {
        Student max = students[0];
        foreach (IComparable<Student> item in students)
        {
            if (item.CompareTo(max) > 0)
                max = (Student)item;
        }
        return max;
    }

}