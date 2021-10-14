using System;
using System.Collections.Generic;
using System.Text;
using Validator;
namespace Car_Lot_Group_Lab
{
    class CarLot
    {
        public List<Car> CarList()
        {
            List<Car> list = new List<Car>
            {
                new Car("Toyota", "Camry", 2021, 26999),
                new Car("Ford", "Focus", 2021, 29990),
                new Car("Cadillac", "Escalade", 2021, 76000),
                new UsedCar("Chevy", "Blazer", 2013, 14500, 90000),
                new UsedCar("Toyota", "Prius", 2016, 28000, 49000),
                new UsedCar("Dodge", "Ram", 2019, 26000, 40000),
            };
            foreach (Car c in list)
            {
                Console.WriteLine(c.ToString());
            }

            return list;
        }

        public List<Car> PurchaseCar(List<Car> list, Car car)
        {

        }


        public List<Car> AddCar(List<Car> c)
        {
            bool add = Validator.Validator.GetContinue("Would you like to add a car? Y/N?");
            Car result = new Car();
            while (add == true)
            {
                Console.WriteLine("New or used car?");
                string newUsed = Console.ReadLine().ToLower();
                if (newUsed == "new")
                {
                    result = AddNew();
                    c.Add(result);
                    break;
                }
                else if (newUsed == "used")
                {
                    result = AddUsed();
                    c.Add(result);
                    break;
                }
                else
                {
                    Console.WriteLine("That was not an option.");
                    continue;
                }
            }
            return c;
        }
        public Car AddNew()
        {
            Console.WriteLine("What is the make of the car?");
            string make = Console.ReadLine();
            Console.WriteLine("What is the model of the car?");
            string model = Console.ReadLine();
            Console.WriteLine("What is the year of the car?");
            int year = (int)(Validator.Validator.GetNumber());
            Console.WriteLine("What is the price of the car?");
            decimal price = (decimal)(Validator.Validator.GetNumber());

            Car result = new Car(make, model, year, price);
            return result;
        }
        public Car AddUsed()
        {
            Console.WriteLine("What is the make of the car?");
            string make = Console.ReadLine();
            Console.WriteLine("What is the model of the car?");
            string model = Console.ReadLine();
            Console.WriteLine("What is the year of the car?");
            int year = (int)(Validator.Validator.GetNumber());
            Console.WriteLine("What is the price of the car?");
            decimal price = (decimal)(Validator.Validator.GetNumber());
            Console.WriteLine("What is the mileage of the car?");
            double mileage = Validator.Validator.GetNumber();

            Car result = new UsedCar(make, model, year, price, mileage);
            return result;
        }







    }
}
