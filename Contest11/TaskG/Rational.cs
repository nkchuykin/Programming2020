using System;

public class Rational
{
    int numerator;
    int denomenator;
    
    public static Rational Parse(string input)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        if (denomenator == 1)
            return numerator.ToString();
        return numerator + "/" + denomenator;
    }
}