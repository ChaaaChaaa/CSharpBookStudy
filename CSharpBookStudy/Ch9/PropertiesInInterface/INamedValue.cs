using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.Ch9.PropertiesInInterface
{
    interface INamedValue
    {
        string Name
        {
            get;
            set;
        }
        
        string Value
        {
            get;
            set;
        }
    }
}
