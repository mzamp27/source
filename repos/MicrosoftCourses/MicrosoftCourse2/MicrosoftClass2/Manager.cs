using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftClass2
{
    class Manager : Employee
    {
        private char payRateIndicator;
        private Employee[] emps;

        public char PayRateIndicator { get => payRateIndicator; set => payRateIndicator = value; }
        internal Employee[] Emps { get => emps; set => emps = value; }
    }
}
