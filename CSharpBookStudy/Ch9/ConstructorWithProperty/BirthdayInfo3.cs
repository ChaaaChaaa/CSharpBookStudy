using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.Ch9.ConstructorWithProperty
{
    class BirthdayInfo3
    {
        public string Name
        {
            get;
            set;
        }

        public DateTime Birthday
        {
            get;
            set;
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
}
