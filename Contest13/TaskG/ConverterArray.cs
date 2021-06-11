using System;

public class ConverterArray<TV, TU> 
{
    private readonly TV[] originArr;
    private readonly IConverter<TV, TU> converter;

    public ConverterArray(int length, IConverter<TV, TU> converter)
    {
        throw new NotImplementedException();
    }

    public TU GetAt(int index)
    {
        throw new NotImplementedException();
    }

    public void SetAt(int index, TV element)
    {
        throw new NotImplementedException();
    }
}