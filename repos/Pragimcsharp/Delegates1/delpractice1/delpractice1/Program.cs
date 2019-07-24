using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delpractice1
{
    //this delegate will return a bool after a method that takes a car object and tests it
    public delegate bool IsOnSale(Car car);


    class Program
    {
        //this sale method will check for mileage
        public static bool MileageSale(List<Car> lc)
        {
            if (car.Mileage >= 30000)
            {
                return true;
            }
            return false;
        }
        public static void Main()
        {
            //create the list
            List<Car> cars = new List<Car>();

            //add some cars
            cars.Add(new Car("Honda", 3, "Red", 10000));
            cars.Add(new Car("Toyota", 12, "Green", 60000));
            cars.Add(new Car("Ford", 2, "Black", 40000));

            foreach (Car car in cars) { Console.WriteLine(car.Make + " " + cars.IndexOf(car)); };

            List<Car> carsonsale = new List<Car>();

            





            ////instance of a delegate IsOn and it references the MileageSale Method
            //IsOnSale miles = new IsOnSale(MileageSale);

            ////call method of Car putonsale() and passes it the list of cars first
            ////the second parameter is expecting a delegate of type IsOnSale
            //Car.PutOnSale(cars, miles);


            ////this delegate points to red sale
            //IsOnSale red = new IsOnSale(RedSale);


            //Car.PutOnSale(cars, RedSale);

            

        }       

        

        public static bool RedSale(Car car)
        {
            if (car.Color.ToLower() == "red")
            {
                return true;
            }
            return false;
        }
    }

    
}


