﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.Ch9.PropertiesInAbstractClass
{
    abstract class Product
    {
        private static int serial = 0;
        public string SerialID
        {
            get
            {
                return String.Format("{0:d5}", serial++);
            }
        }

        abstract public DateTime ProductDate
        {
            get;
            set;
        }
    }
}
