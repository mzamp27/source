using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftClass2
{
    public class Technician : LabEmployee
    {
        public int successfulCheckIns = 5;

        //this constructor calls the base and passes in the argument Technician(name) for name and 75000 auto value
        public Technician(string name) : base(name, 75000)
        {
        }

        // This method returns the toString() method - which is the employee's ID number and name
        //and prints the number of successful check ins the employee has had 
        public override string employeeStatus()
        {
            return toString() + " has " + successfulCheckIns + " successful check ins";
        }
    }
}
