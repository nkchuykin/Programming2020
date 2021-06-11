public class Program
{
    public static void Main(string[] args)
    {
        Task[] tasks = Task.DeserializeFromXml("input.xml");
        Task.FindAnswers(tasks);
        Task.SerializeToJson("output.json", tasks);
    }
}