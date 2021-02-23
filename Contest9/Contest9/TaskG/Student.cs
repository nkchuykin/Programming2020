using System;

internal struct Student : IComparable<Student>
{
    private int id;
    private int height;
    private int math;
    private int english;
    private int PE;
    private bool isMath;

    public Student(int id, int height, int math, int english, int PE)
    {
        throw new NotImplementedException();
    }

    internal static Student Parse(string v)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        throw new NotImplementedException();
    }
}