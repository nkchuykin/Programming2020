using System;
using System.Collections.Generic;

public class Support
{
    private readonly List<Task> tasks = new List<Task>();

    public IEnumerable<Task> Tasks => tasks;

    public int OpenTask(string text)
    {
        throw new NotImplementedException();
    }

    public void CloseTask(int id, string answer)
    {
        throw new NotImplementedException();
    }

    public List<Task> GetAllUnresolvedTasks()
    {
        throw new NotImplementedException();
    }

    public void CloseAllUnresolvedTasksWithDefaultAnswer(string answer)
    {
        throw new NotImplementedException();

    }

    public string GetTaskInfo(int id)
    {
        throw new NotImplementedException();
    }
}