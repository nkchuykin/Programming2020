using System;

public class Track : Content
{
    private string artist;
    private string album;
    private short duration;

    public Track(int size, string name, string artist, string album,
        short duration) : base(size, name)
    {
        throw new NotImplementedException();
    }
}