using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp12
{
    public abstract class Logger
    {
        public virtual void Log(string message)
        { 
            Console.WriteLine("Log: " + message); 
        }
        public abstract void ReadLogs();
    }
}
