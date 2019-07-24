using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delpractice1
{
    public class Car
    {
        //create properties
        public string Make { get; set; }
        public int Model { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }

        //create constructor
        public Car(string make, int model, string color, int mileage)
        {
            Make = make;
            Model = model;
            Color = color;
            Mileage = mileage;
        }


        //this method takes in a list of cars and another method
        public static void PutOnSale(List<Car> cars)
        {
            foreach(Car car in cars)
            {
                if(Program.MileageSale(car))
                {
                    Console.WriteLine(car.Make + " is on Sale!");
                }
                else
                {
                    Console.WriteLine(car.Make + " is not on Sale.");
                }
            }
        }

    }
}
