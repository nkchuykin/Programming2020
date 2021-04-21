using System;
using System.Collections.Generic;

public class Map<TKey, TValue>
{
    private List<(TKey, TValue)> map;

    public Map()
    {
        throw new NotImplementedException();
    }

    public void Add(TKey key, TValue value)
    {
        throw new NotImplementedException();
    }

    public TValue this[TKey key] => throw new NotImplementedException();

    public bool Remove(TKey key)
    {
        throw new NotImplementedException();
    }

    public int Count => throw new NotImplementedException();

    public bool ContainsKey(TKey key)
    {
        throw new NotImplementedException();
    }
}