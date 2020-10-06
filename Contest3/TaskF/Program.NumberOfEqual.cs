using System;

partial class Program
{
    private static int[] ParseInput(string input)
    {
        string[] parsedInput = input.Split(new char[] { ' ' });
        int[] output = new int[parsedInput.Length];
        for (int i = 0; i < output.Length; i++)
        {
            output[i] = int.Parse(parsedInput[i]);
        }
        Array.Sort(output);
        return output;
    }

    private static int GetNumberOfEqualElements(int[] first, int[] second)
    {
        int firstIndex = 0;
        int secondIndex = 0;
        int equalElements = 0;
        while (firstIndex < first.Length && secondIndex < second.Length)
        {
            if (first[firstIndex] == second[secondIndex])
            {
                equalElements++;
                firstIndex++;
            }
            else if (first[firstIndex] > second[secondIndex])
            {
                secondIndex++;
            }
            else
            {
                firstIndex++;
            }
        }
        return equalElements;
    }
}