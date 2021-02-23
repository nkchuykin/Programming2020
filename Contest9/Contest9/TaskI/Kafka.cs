using System;
using System.Collections.Generic;

public class Kafka
{
    private MessageQueue queue;
    private HashSet<User> allowed = new HashSet<User>();
    private bool isActive = false;

    public Kafka(int queueSize)
    {
        throw new NotImplementedException();
    }

    public void Subscribe(User user)
    {
        throw new NotImplementedException();
    }

    public void Unsubscribe(User user)
    {
        throw new NotImplementedException();
    }

    public void Push(Message message)
    {
        throw new NotImplementedException();
    }

    public List<Message> PopMessages(User user, int count)
    {
        throw new NotImplementedException();
    }

    public void Activate()
    {
        throw new NotImplementedException();
    }

    public void Deactivate()
    {
        throw new NotImplementedException();
    }
}