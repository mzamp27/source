using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftClass2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region drinkmachine
            //DrinkMachine myMachine = new DrinkMachine("Kitchen", "Brand", "DM1000");
            ////myMachine.Location = "Kitchen";
            ////myMachine.Model = "DM1000";

            //Console.WriteLine(myMachine.Location);
            //Console.WriteLine(myMachine.Model);
            //Console.WriteLine(myMachine.Make);



            //myMachine.MakeCappuccino();
            #endregion

            #region cars
            //// Instantiating an object of Car() Class by using Type Inference called Car1
            //var Car1 = new Car();
            //// Using dot notation to call members on Car1
            //Car1.Color = "White";
            //Car1.Year = 2010;
            //Car1.Mileage = 11000;

            //var Car2 = new Car("red", 2008);
            //var Car3 = new Car("red", 2008);
            //var Car4 = new Car("red", 2008);

            //Console.WriteLine(Car.CountCars());
            #endregion

            #region employees
            //Employee EMP1 = new Employee();
            //EMP1.FirstName = "mary";
            //EMP1.EmpNumber = "101";
            //Console.WriteLine(EMP1.FirstName + " " + EMP1.EmpNumber);


            ////Abstract classes cannot be instantiated, which means we are not able to instantiate a new LabEmployee object.
            ////LabEmployee L1 = new LabEmployee("Mary", 50500);
            ////Console.WriteLine(L1.getName());
            ////Console.WriteLine(L1.getBaseSalary());
            ////Console.WriteLine(L1.getEmployeeID());
            ////Console.WriteLine(L1.toString());

            ////LabEmployee L2 = new LabEmployee("Jim", 42000);
            ////Console.WriteLine(L2.getName());
            ////Console.WriteLine(L2.getBaseSalary());
            ////Console.WriteLine(L2.getEmployeeID());
            ////Console.WriteLine(L2.employeeStatus());

            //var employee1 = new Technician("Libby");
            //Console.WriteLine(employee1.employeeStatus());


            //Technician T1 = new Technician("Larry");
            //Console.WriteLine(T1.getName());
            //Console.WriteLine(T1.getBaseSalary());
            //Console.WriteLine(T1.getEmployeeID());
            //Console.WriteLine(T1.employeeStatus());

            //BusinessEmployee B1 = new BusinessEmployee("Todd");
            //Console.WriteLine(B1.getName());
            //Console.WriteLine(B1.getBaseSalary());
            //Console.WriteLine(B1.getEmployeeID());
            //Console.WriteLine(B1.employeeStatus());

            //Technician N1 = new Technician("Mark");

            //LabEmployee N2 = N1;

            //Console.WriteLine(N1.employeeStatus());
            #endregion

        }
    }

    

}
