using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBookStudy.Ch9
{
    class BirthdayInfo2
    {
        public string Name { get; set; } = "Unknown";
        public DateTime Birthday { get; set; } = new DateTime(1, 1, 1);
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
}
