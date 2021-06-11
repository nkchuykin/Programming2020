using System;

public class Task
{
    public int groupNumber;
    private int hardLvl;
    public string creator;

    public Task()
    {
        
    }

    public int GroupNumber => throw new NotImplementedException();

    public int HardLvl
    {
        set => throw new NotImplementedException();
    }

    public string Creator => creator;

    public static Task[] DeserializeFromXml(string xmlFile)
    {
        throw new NotImplementedException();
    }

    public static void SerializeToJson(string fileName, Task[] tasks)
    {
        throw new NotImplementedException();
    }

    public static void FindAnswers(Task[] tasks)
    {
        throw new NotImplementedException();
    }
}