using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.Ch8.DefaultInplementation
{
    interface ILogger
    {
        void WriteLog(string message);
        void WriteError(string error)
        {
            WriteLog($"Error: {error}");
        }
    }
}
