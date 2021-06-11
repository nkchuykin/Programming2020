public interface IConverterArray<in TV, out TU>
{
    public TU GetAt(int index);
    public void SetAt(int index, TV tv);
}