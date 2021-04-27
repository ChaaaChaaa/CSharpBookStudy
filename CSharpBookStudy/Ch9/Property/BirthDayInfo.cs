using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.Ch9
{
    class BirthDayInfo
    {
        private string name;
        private DateTime birthDay;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public DateTime BirthDay
        {
            get
            {
                return birthDay;
            }
            set
            {
                birthDay = value;
            }
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthDay).Ticks).Year;
            }
        }
    }
}
