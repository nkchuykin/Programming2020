using System;

public class User
{
    private ushort age;
    private string city;
    private long id;
    private string name;

    private User(long id, string name, ushort age, string city)
    {
        throw new NotImplementedException();
    }

    private long Id
    {
        get => throw new NotImplementedException();
        set
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

    public string City
    {
        get => throw new NotImplementedException();
        private set
        {
            throw new NotImplementedException();
        }
    }

    public static User Parse(string str)
    {
        throw new NotImplementedException();
    }
}