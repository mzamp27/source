using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructorTest
{
    class Dog : Animal
    {
        public bool Needswalk = true;

        public void Bark()
        {
            Console.WriteLine(this.Name + "goes WOOF");
        }

        public void DoINeedWalk()
        {
            Console.WriteLine("Does this dog need a walk?" + Needswalk.ToString());
        }
    }
}
