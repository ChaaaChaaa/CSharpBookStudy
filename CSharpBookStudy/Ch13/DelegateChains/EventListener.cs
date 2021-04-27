using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.Ch13.DelegateChains
{
    class EventListener
    {
        private string name;
        public EventListener(string name)
        {
            this.name = name;
        }

        public void SomethingHappend(string message)
        {
            Console.WriteLine($"{name}.SomethingHappened : {message}");
        }
    }
}
