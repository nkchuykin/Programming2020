using System;

public class ProgramingTask : Task
{
    public string language;
    public int maxLinesOfCode;
    private string answer;
    
    public ProgramingTask()
    {
        
    }

    public string Language => throw new NotImplementedException();

    public int MaxLinesOfCode => throw new NotImplementedException();

    public string Answer
    {
        set => throw new NotImplementedException();
    }
}