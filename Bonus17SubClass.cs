using System;
namespace Bonus17
{
    class UsedCars : Cars
    {
        public double Mileage;

        public UsedCars(string make, string model, int year, double price, double mileage)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            Mileage = mileage;
        }

        public UsedCars()
        {

        }

        public override string ToString()
        {
            return $"\t{Make}\t{Model}\t{Year}\t{Price}\t (Used) {Mileage}";
        }


    }
}
