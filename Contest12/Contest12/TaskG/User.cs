using System;

public class User
{
    private long id;
    private string name;
    private ushort age;

    public long Id
    {
        get => throw new NotImplementedException();
        private set
        {
            throw new NotImplementedException();
        }
    }
    
    public string Name
    {
        get => throw new NotImplementedException();
        private set
        {
            throw new NotImplementedException();
        }
    }
    
    public ushort Age
    {
        get => throw new NotImplementedException();
        private set
        {
            throw new NotImplementedException();
        }
    }

    private User(long id, string name, ushort age)
    {
        throw new NotImplementedException();
    }

    public static User Parse(string str)
    {
        throw new NotImplementedException();
    }
}