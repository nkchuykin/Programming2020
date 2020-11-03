using System;

public class Program
{
    public static void Main(string[] args)
    {
	    string s = Console.ReadLine();
		string initialSubstring = Console.ReadLine();
		string finalSubstring = Console.ReadLine();

	    var replacedString = new ReplacedString(s, initialSubstring, finalSubstring);

	    Console.WriteLine(replacedString);
    }
}

