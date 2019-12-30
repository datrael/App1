using System;
using System.Collections.Generic;
using System.Text;

namespace App1
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
