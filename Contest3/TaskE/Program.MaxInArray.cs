using System;

partial class Program
{
    private static int[] ParseInput(string input)
    {
        string[] parsedInput = input.Split(new char[] { ' ' });
        int[] output = new int[parsedInput.Length];
        for (int i=0; i < output.Length; i++)
        {
            output[i] = int.Parse(parsedInput[i]);
        }
        return output;
    }

    private static int GetMaxInArray(int[] numberArray)
    {
        int maxTemp = numberArray[0];
        foreach (int temp in numberArray)
        {
            if (temp > maxTemp)
            {
                maxTemp = temp;
            }
        }
        return maxTemp;
    }
}