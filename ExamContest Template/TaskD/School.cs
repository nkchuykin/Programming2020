using System;
using System.Collections.Generic;
using System.Linq;

public class School
{
    public string SchoolNumber { get; set; }
    public string Address { get; }
    public List<Pupil> Pupils { get; }

    public School(string address, string schoolNumber, List<Pupil> pupils)
    {
        throw new NotImplementedException();
    }
}