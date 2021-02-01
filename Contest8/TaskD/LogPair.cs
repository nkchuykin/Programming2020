using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LogPair
{
    public Print Method { get; set; }

    public string Log { get; set; }

    public LogPair(Print message, string log)
    {
        Method = message;
        Log = log;
    }
}

