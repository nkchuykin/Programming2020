using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void Print(string line);

class Logger
{
    List<LogPair> list = new List<LogPair>();

    public void OutputLogs()
    {
        throw new NotImplementedException();
    }

    public void MakeLog(Print method, string line)
    {
        throw new NotImplementedException();
    }
}

