using System;
using System.Collections.Generic;
using System.Linq;

public class Files
{
    Dictionary<string, Permissions> database = new Dictionary<string, Permissions>();

    public void CreateFile(string filename)
    {
        throw new NotImplementedException();
    }

    public void AddPermission(string filename, string permissionName)
    {
        throw new NotImplementedException();
    }

    public void RemovePermission(string filename, string permissionName)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        throw new NotImplementedException();
    }
}