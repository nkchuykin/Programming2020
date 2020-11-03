public class Task
{
    public int Id { get; }
    private string Text { get; }
    public bool IsResolved { get; internal set; }
    public string Answer { get; internal set; }
    
    public Task(int id, string text)
    {
        Id = id;
        IsResolved = false;
        Text = text;
    }

    public override string ToString() => $"id: {Id}; text: {Text}; status: {(IsResolved ? "resolved" : "unresolved")}; answer: {Answer}";
}