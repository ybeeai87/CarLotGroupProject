using System;
using System.Collections.Generic;
using System.Text;
using Validator;
using System.Linq;

namespace Car_Lot_Group_Lab
{
    class CarLot
    {
        public static void CarList()
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
            bool run = true;
            while (run == true)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {list[i]}");
                }

                Console.WriteLine($"{list.Count + 1}. Add a car");
                Console.WriteLine($"{list.Count + 2}. Quit");

                PurchaseCar(list);
                //foreach (Car c in list)
                //{
                //    Console.WriteLine(c.ToString());
                //}
                Console.WriteLine("Have a great day!");
                break;
            }

        }

        public static List<Car> PurchaseCar(List<Car> list)
        {
            while (true)
            {
                Console.WriteLine("Which option would you like?");
                int choice = (int)Validator.Validator.GetNumber();
                if (choice == list.Count + 1)
                {
                    AddCar(list);
                }
                else if (choice == list.Count + 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"{list[choice - 1]}");
                    bool buy = Validator.Validator.GetContinue("Would you like to buy this car?");
                    if (buy == true)
                    {
                        list.Remove(list[choice - 1]);
                        Console.WriteLine("Excellent. Our finance dept. will be in touch with you shortly.");
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return list;
        }
        public static List<Car> AddCar(List<Car> c)
        {
            bool add = Validator.Validator.GetContinue("Would you like to add a car?");
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
            for (int i = 0; i < c.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {c[i]}");
            }
            Console.WriteLine($"{c.Count + 1}. Add a car");
            Console.WriteLine($"{c.Count + 2}. Quit");

            return c;
        }
        public static Car AddNew()
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
        public static Car AddUsed()
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
