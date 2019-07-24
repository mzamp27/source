using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delpractice2
{

    public delegate void MethodPtr(); 

    public class Program
    {
        public static void Main()
        {

            //To invoke a method from another class
            MyClass mc = new MyClass();
            mc.LongRunning();

            //now there are 2 parties involved, class Program and class Myclass



            SomeMethod();

            MethodPtr del = new MethodPtr(SomeMethod);
            del();

        }

        public static void SomeMethod()
        {
            Console.WriteLine("Method called");
        }

    }
}
