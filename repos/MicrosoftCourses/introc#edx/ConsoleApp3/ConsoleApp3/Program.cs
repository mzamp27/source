using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal ani2 = new Animal();

            ani2.Name = "Bob";
            ani2.Walk();

            Console.ReadLine();



        }
    }
}
