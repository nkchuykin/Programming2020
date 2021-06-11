using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int seed = int.Parse(Console.ReadLine());
        
        var generator = new MessageNetworkGenerator(seed);

        var converter = new Converter();
        var converterArray = new ConverterArray<MessageNetwork, MessageDb>(n, converter);

        for (int i = 0; i < n; i++)
        {
            converterArray.SetAt(i, generator.GenerateMessageNetwork());
        }
        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(converterArray.GetAt(i));
        }

        foreach (var messageDb in converterArray)
        {
            Console.WriteLine(messageDb);
        }
    }
}