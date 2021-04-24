using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.ch7.DeepCopy
{
    class DoDeepCopy
    {
        public int MyField1;
        public int MyField2;

        public DoDeepCopy DeepCopyFunction()
        {
            DoDeepCopy newDeepCopy = new DoDeepCopy();
            newDeepCopy.MyField1 = this.MyField1;
            newDeepCopy.MyField2 = this.MyField2;

            return newDeepCopy;
        }
    }
}
