using System;

public class Programmer
{
    private readonly int id;
    private readonly int linesOfCode;

    private int GetAlmostRandomNumber()
    {
        return (int) Math.Abs(Math.Sin(GetIdDigitsSum() % 11 + 1) * 12345);
    }

    public Programmer(int id)
    {
        throw new NotImplementedException();
    }

    private int GetIdDigitsSum()
    {
        var sum = 0;
        var idCopy = id;
        while (idCopy != 0)
        {
            sum += idCopy % 10;
            idCopy /= 10;
        }

        return sum;
    }

    public int Id
    {
        get { throw new NotImplementedException(); }
    }

    public int LinesOfCode
    {
        get { throw new NotImplementedException(); }
    }

    public override string ToString()
    {
        return String.Format("Id: {0}\nLines of code: {1}", id, linesOfCode);
    }
}