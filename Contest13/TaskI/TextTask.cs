using System;

public class TextTask : Task
{
    public AnswerType type;
    public string question;
    private string answer;

    public TextTask()
    {
        
    }

    public AnswerType Type => throw new NotImplementedException();

    public string Question => throw new NotImplementedException();

    public string Answer
    {
        set => throw new NotImplementedException();
    }
    
    public enum AnswerType : int
    {
        Text = 0,
        Multiple = 1,
        Single = 2
    }
}