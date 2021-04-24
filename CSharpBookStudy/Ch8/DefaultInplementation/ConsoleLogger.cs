using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.Ch8.DefaultInplementation
{
    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()},{message}");
        }
    }
}
