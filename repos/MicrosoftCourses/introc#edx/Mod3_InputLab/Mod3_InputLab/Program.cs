using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_InputLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";
            string lastName = "";
            string birthday = "";

            GetStudentInformation(out firstName, out lastName, out birthday);


            PrintStudentDetails(firstName, lastName, birthday);

            try
            {
                ValidateBirthday(birthday);
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("You forgot a method");
            }
        }   

        static void GetStudentInformation(out string f, out string l, out string b)
        {
            Console.WriteLine("Enter the student's first name: ");
            f = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            l = Console.ReadLine();
            Console.WriteLine("Enter the student's birthday");
            b = Console.ReadLine();


        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        static void ValidateBirthday(string birthday)
        {
            if (birthday != null)
            {
                var ex = new NotImplementedException("Not done yet1111");
                throw ex;
            }
            else
            {
                var ex = new NotImplementedException("Not done yet2222");
                throw ex;
            }
        }

        
    }
}
