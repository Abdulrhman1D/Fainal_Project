using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.OOP.task2
{
    public abstract class  Vehicle
    {
        public string Brand;
        public string Model;
        public double Price;

        public Vehicle(string brand, string model, double price)
        {
            Brand = brand;
            Model = model;
            Price = price;
        }

        public abstract string DisplayDetails();

        public double GetPrice()
        {
            return Price;
        }

    }
}
