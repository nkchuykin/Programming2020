public class Program
{
    public static void Main(string[] args)
    {
        Serializer.ReadStudents("input.txt");
        Serializer.SerializeStudents("output.bin");
    }
}