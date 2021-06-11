using System;

public class Virus 
{
    private int infectedCount;
    private double dangerIndex;
    private int typeNumber;

    public Virus(int infectedCount, double dangerIndex, int typeNumber)
    {
        throw new NotImplementedException();
    }

    private Virus(Virus virus)
    {
        throw new NotImplementedException();
    }

    public static Virus GetSum(Virus[] arr, int firstN)
    {
        throw new NotImplementedException();
    }
    
    public static Virus GetDifference(Virus[] arr, int lastN)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"{infectedCount} {dangerIndex:F2} {typeNumber}";
    }
}