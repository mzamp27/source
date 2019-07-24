using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            int first = 10;
            string sValue;

            ReturnMultiOut(out first, out sValue);
            Console.WriteLine(value: $"{first.ToString()}");
            Console.WriteLine($"{sValue}");

            void ReturnMultiOut(out int i, out string s)
            {
                i = 25;
                s = "Using Out";
            }



            // using named parameters
            Area(length: 30, width: 50);

           


        }

        static void Area(int length, int width)
        {
            Console.WriteLine("The area is {0}", length * width);
        }
    }
}
