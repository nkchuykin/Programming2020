using System;
using System.Collections.Generic;

public class MessageQueue
{
    private List<Message> queue = new List<Message>();
    private int size;

    public MessageQueue(int size)
    {
        throw new NotImplementedException();
    }

    public void Push(Message message)
    {
        throw new NotImplementedException();
    }

    public int Size
    {
        get { throw new NotImplementedException(); }
    }

    public List<Message> this[int from, int to]
    {
        get { throw new NotImplementedException(); }
    }
}