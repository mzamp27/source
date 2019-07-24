using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftClass2
{

    // any method declared in an abstract class that will contain some implementation in the abstract class,
    //but can be overridden in the sub class, you decorate with the virtual keyword.
    public class LabEmployee
    {
        //Make static field for instance counter
        private static int instances = 1;

        //Define fields
        private string _name;
        private double _baseSalary;
        private int _empID;

        public string Name { get => _name; set => _name = value; }
        public double BaseSalary { get => _baseSalary; set => _baseSalary = value; }
        public int EmpID { get => _empID; set => _empID = value; }

        //Constructor
        public LabEmployee(string name, double baseSalary)
        {
            _name = name;
            _baseSalary = baseSalary;
            _empID = instances;
            instances++;
        }



        //Create methods
        public string getName()
        {
            return _name;
        }

        public double getBaseSalary()
        {
            return _baseSalary;
        }

        public int getEmployeeID()
        {
            return _empID;
        }

        public string toString()
        {
            return (_empID + " " + _name);
        }

        //virtual employee status for inherited classes to allow overriding
        public virtual string employeeStatus()
        {
            return (toString() + " is in the company's system");
        }

        //Now that we have created our abstract class, we are going to force our sub classes to implement the employeeStatus() method.
        //To do so, we need to add the abstract keyword to the method in our Employee() Class.

        //public abstract string employeeStatus();

        //This means that all subclasses of our Employeee() Class are required to implement the employeeStatus() method.
    }
}
