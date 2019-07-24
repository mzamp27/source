using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructorTest
{
    class Cat : Animal
    {
        public bool Needswalk = true;

        public void Meow()
        {
            Console.WriteLine(this.Name + "goes MEOW");
        }

        public void DoINeedWalk()
        {
            Console.WriteLine("Does this cat need a walk?" + Needswalk.ToString());
        }
    }
}
