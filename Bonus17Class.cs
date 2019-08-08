using System;

namespace Bonus17
{
    class Cars
    {
        public string Make;
        public string Model;
        public int Year;
        public double Price;

        public Cars(string make, string model, int year, double price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        public Cars()
        {

        }

        public override string ToString()
        {
            return $"\t{Make}\t{Model}\t{Year}\t{Price}";
        }
    }
}