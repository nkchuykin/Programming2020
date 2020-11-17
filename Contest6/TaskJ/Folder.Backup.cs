using System;
using System.Collections.Generic;
using System.Text;

partial class Folder
{
    internal class Backup
    {

        public Backup(Folder folder)
        {
            throw new NotImplementedException();
        }


        public static void Restore(Folder folder, Backup backup)
        {
            throw new NotImplementedException();
        }

    }

    public void AddFile(string name, int size)
    {
        throw new NotImplementedException();
    }
    public void RemoveFile(File file)
    {
        throw new NotImplementedException();
    }

    public File this[int i]
    {
        get {
            throw new NotImplementedException();
        }
    }

    public File this[string filename]
    {
        get {
            throw new NotImplementedException();
        }
    }

    public override string ToString()
    {
        throw new NotImplementedException();
    }
}

