using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.Ch9.PropertiesInAbstractClass
{
    class MyProduct : Product
    {
        public override DateTime ProductDate
        {
            get;
            set;
        }
    }
}
