using System;
using System.Collections.Generic;
using System.Text;

class File
{
    string name;
    int size;

    public File(string name, int size)
    {
        Name = name;
        Size = size;
    }

    public File(File file): this(file.name,file.size)
    {
      
    }
    public string Name
    {
        get {
            return name;
        }
        set {
            if (value.Length <= 0 || value.Length >= 15)
            {
                throw new ArgumentException("Incorrect file name");
            }
            name = value;
        }
    }

    public int Size
    {
        get {
            return size;
        }
        set {
            if (value <= 0)
            {
                throw new ArgumentException("Incorrect file size");
            }
            size = value;
        }
    }

    public override string ToString()
    {
        return $"{name,-15} {size,5}";
    }
}
