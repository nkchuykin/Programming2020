public abstract class BaseArray
{
    protected int[] array;

    public BaseArray(int[] array)
    {
        this.array = array;
    }
    
    public abstract int this[int number] { get; }

    public abstract double GetMetric();
}