using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftClass2
{
    class DrinkMachine
    {

        //Constructor
        public DrinkMachine(string loc, string mak, string mod)
        {
            Location = loc;
            Make = mak;
            Model = mod;
        }
        
        //The following statements declare private members
        private string location;
        private string make;
        private string model;

        

        public string Location { get => location; set => location = value; }
        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }

        //Declare public methods
        public void MakeCappuccino()
        {
            Console.WriteLine("The cappuccino is made");

        }

        public void MakeEspresso()
        {
            //Method Logic

        }

    }
}
