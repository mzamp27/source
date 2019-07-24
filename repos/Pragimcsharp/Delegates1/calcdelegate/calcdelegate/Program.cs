using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcdelegate
{

    //A delegate must have the same return type and same parameter types as the function it is pointing to 
    //THIS DELEGATE WILL ENCAPSULATE ANY METHOD THAT TAKES 2 int PARAMETERS AND RETURNS A SINGLE int
    delegate int MyDel(int x, int y);



    delegate void MyDel2(int x, int y);
    class Program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Divide(int n, int d)
        {
            return n / d;
        }
        public static void PrintXY(int x, int y)
        {
            Console.WriteLine("X is {0} and Y is {1}", x, y);
        }
        




        static void Main(string[] args)
        {
            //Tell delegate to point to any function that takes 2 ints as parameters and returns a single int
            MyDel delneedreturnint = new MyDel(Add);
            //Since the method we are pointing to returns an int you need to store it somewhere
            int result = delneedreturnint(10, 30);
            Console.WriteLine(result);

            
            //Multicasting overrides the delneedreturnint object and makes it point to Multiply method but it does first point to Add.
            delneedreturnint += Multiply;
            result = delneedreturnint(20, 50);
            Console.WriteLine(result);

            //If you don't have the method as a static method the you need to create an instance of the class first
            Program p1 = new Program();
            //Then point the delegate to the class method that isnt static (divide)
            MyDel deldiv = new MyDel(p1.Divide);
            int dresult = deldiv(30, 10);
            Console.WriteLine(dresult);
            
        }
    }
}
