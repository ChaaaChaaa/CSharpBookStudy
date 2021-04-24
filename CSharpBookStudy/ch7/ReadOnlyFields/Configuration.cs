using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.ch7.ReadOnlyFields
{
    class Configuration
    {
        const int testValue = 999;
        private readonly int min;
        private readonly int max;

        public Configuration(int v1, int v2)
        {
            min = v1;
            min = v2;
        }

        //public void ChangeMax(int newMax)
        //{
        //    max = newMax;
        //}
    }
}
