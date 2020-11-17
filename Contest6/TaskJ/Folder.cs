using System;
using System.Collections.Generic;
using System.Text;

partial class Folder
{
    List<File> files = new List<File>();
    
    public Backup GetBackup()
    {
        return new Backup(this);
    }

    public void RestoreBackup(Backup backup)
    {
        Backup.Restore(this, backup);
    }
}

