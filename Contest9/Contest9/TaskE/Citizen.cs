using System;

public class Citizen : IOptimist, IPessimist
{
    int predictedValue;

    public Citizen(int predictedValue)
    {
        throw new NotImplementedException();
    }

    public double GetForecast()
    {
        throw new NotImplementedException();
    }

    double IPessimist.GetForecast()
    {
        throw new NotImplementedException();
    }

    double IOptimist.GetForecast()
    {
        throw new NotImplementedException();
    }

    internal static Citizen Parse(string input)
    {
        throw new NotImplementedException();
    }
}