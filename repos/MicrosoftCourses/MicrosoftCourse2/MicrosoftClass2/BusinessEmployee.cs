using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftClass2
{
    public class BusinessEmployee : LabEmployee
    {
        //add any new fields here
        public double bonusBudget = 1000;

        public BusinessEmployee(string name) : base(name, 50000)
        {
        }

        // constructor 


        public override string employeeStatus()
        {
            return toString() + " with a budget of " + bonusBudget;
        }

    }
}
