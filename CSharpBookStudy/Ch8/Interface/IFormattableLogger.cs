using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.Ch8.Interface
{
    interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params Object[] args);
    }
}
