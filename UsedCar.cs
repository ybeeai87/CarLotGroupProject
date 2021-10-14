using System;
using System.Collections.Generic;
using System.Text;
using Validator;
namespace Car_Lot_Group_Lab
{
    class UsedCar : Car
    {
        //properties
        private double Mileage { get; set; }

        //constructor
        public UsedCar(string make, string model, int year, decimal price, double mileage):base(make, model, year, price)
        {
            Mileage = mileage;
        }
        public UsedCar():base()
        {
            Mileage = 0;
        }

        //methods
        public override string ToString()
        {
            return $"{base.ToString()} (Used) {Mileage} miles";
        }
    }
}
