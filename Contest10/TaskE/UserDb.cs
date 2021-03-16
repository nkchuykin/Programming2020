using System.Collections.Generic;
using System.IO;

public class UserDb
{
    public static Dictionary<string, string> Users = new Dictionary<string, string>();

    public static void ReadData(string path)
    {
        using (var sr = new StreamReader(path))
        {
            while (sr.Peek() != -1)
            {
                var userInfo = sr.ReadLine().Split(' ');
                Users.Add(userInfo[0], userInfo[1]);
            }
        }
    }
}