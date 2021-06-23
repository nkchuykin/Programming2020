using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Program
{
    private static Pupil GetPupil(string[] pupilData) =>
        new Pupil(
            firstName: pupilData[0],
            middleName: pupilData[1],
            lastName: pupilData[2],
            year: int.Parse(pupilData[3]),
            schoolNumber: pupilData[4]
        );

    private static School GetSchool(string[] schoolData, List<Pupil> pupils) =>
        new School(
            address: schoolData[0],
            schoolNumber: schoolData[1],
            pupils: pupils
        );

    public static void Main(string[] args)
    {
        var pupils = new List<Pupil>();
        var schools = new List<School>();

        using (var sr = new StreamReader("schools.txt"))
        {
            int pupilsNumber = int.Parse(sr.ReadLine());
            while (pupilsNumber-- > 0)
            {
                pupils.Add(GetPupil(sr.ReadLine().Split()));
            }

            int schoolsNumber = int.Parse(sr.ReadLine());
            while (schoolsNumber-- > 0)
            {
                schools.Add(GetSchool(sr.ReadLine().Split("; "), pupils));
            }

            int commandsNumber = int.Parse(sr.ReadLine());
            while (commandsNumber-- > 0)
            {
                string[] command = sr.ReadLine().Split();
                switch (command[0])
                {
                    case "mv":
                        SchoolManager.TransferPupil(pupils, schools, pupilId: int.Parse(command[1]), newSchoolNumber: command[2]);
                        break;
                    case "union":
                        var schoolsNumbers = command.Skip(1).ToList();
                        SchoolManager.UniteSchools(schools, schoolsNumbers);
                        break;
                    case "close":
                        SchoolManager.CloseSchool(schools, schoolNumber: command[1], newSchoolNumber: command[2]);
                        break;
                }
            }
        }

        using (var sw = new StreamWriter("schools_after_reform.txt"))
        {
            schools.ForEach(sw.WriteLine);
        }
    }
}