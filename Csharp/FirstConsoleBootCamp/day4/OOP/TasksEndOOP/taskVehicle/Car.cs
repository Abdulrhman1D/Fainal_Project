using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.OOP.TasksEndOOP.taskVehicle
{
    public class Car : Vehicle , IVehicle
    {
        public int NumberOfDoors;
        
        public Car(string brand, string model, double price, int numberOFdoors) : base(brand, model, price)
        {
            NumberOfDoors = numberOFdoors;
        }

        public override string DisplayDetails()
        {
            return $"Brand :{Brand}, Model :{Model}, Price :{Price}, Number Of Doors: {NumberOfDoors}.";
        }
        public string StartEngine()
        {
            return "Car Engine Started";
        }
        
        public double GetPrice()
        {
            return (double)this.Price;
        }
    }
}
