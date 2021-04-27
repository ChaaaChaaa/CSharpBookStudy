using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.Ch13.DelegateChains
{
    public delegate void Notify(string message);
    class Notifier
    {
        public Notify EventOccured;
    }
}
