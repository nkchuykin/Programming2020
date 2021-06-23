using System;

public class Pupil
{
    public int Id { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public string MiddleName { get; }
    public int Year { get; }
    public string SchoolNumber { get; set; }

    public Pupil(string firstName, string middleName, string lastName, int year, string schoolNumber)
    {
        throw new NotImplementedException();
    }
}