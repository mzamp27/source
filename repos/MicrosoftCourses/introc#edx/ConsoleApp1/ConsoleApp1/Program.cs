using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create variables to learn new data types
            //initialize them with an "default" value
            string firstName = "";
            string lastName = "";
            int age = 0;
            string street = "";
            string city = "";
            string country = "";
            DateTime birthDate;


            //Now assign some values
            firstName = "Tom";
            lastName = "Thumb";
            age = 18;
            street = "123 Fourth Street";
            city = "Anytown";
            country = "MyCountry";
            birthDate = new DateTime(1985, 7, 27);

            //output to the console window

            //use simple output with just variable name
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            //use placeholder style
            Console.WriteLine("{0} years old", age);

            //use string concatenation
            Console.WriteLine(street + ", " + city + ", " + country);

            //use string interpolation
            Console.WriteLine($"Born on {birthDate}");
        }
    }
}
