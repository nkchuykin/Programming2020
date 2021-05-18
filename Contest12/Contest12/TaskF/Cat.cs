public class Cat
{
    public int TailLength { get; }
    public int Age { get; }
    public bool IsBlack { get; }

    public Cat(int tailLength, int age, bool isBlack)
    {
        TailLength = tailLength;
        Age = age;
        IsBlack = isBlack;
    }

    public override string ToString()
    {
        string color = IsBlack ? "Black" : "Not black";
        return $"{color} cat with tail {TailLength} and {Age} years old";
    }
}