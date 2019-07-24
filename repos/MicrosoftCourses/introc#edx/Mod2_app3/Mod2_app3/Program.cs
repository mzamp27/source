using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_app3
{
    class Program
    {
        static void Main(string[] args)
        {

            // simple for loop, however notice the string formatting that includes a placeholder and a $ sign to be able to reference an earlier variable
            for (int counter = 0; counter < 10; counter++)
                Console.WriteLine($"Counter is at {counter}");

            // nested loop example

            int outer;
            int inner;

            for (outer = 2; outer < 100; outer++)
            {
                for (inner = 2; inner <= (outer / inner); inner++)
                    if ((outer % inner) == 0) break; //if factor found, not prime
                if (inner > (outer / inner))
                    Console.WriteLine("{0} is prime", outer);
            }

        }
    }
}
