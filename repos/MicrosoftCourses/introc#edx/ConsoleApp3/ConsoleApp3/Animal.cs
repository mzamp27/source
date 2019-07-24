using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructorTest
{
    class Animal
    {
        public string Name;

        public void Walk()
        {
            Console.WriteLine("My name is " + this.Name + " and I'm walkin");
            
        }
    }
}
