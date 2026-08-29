using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.OOP.task2
{
    public class Car : Vehicle
    {
        public int NumberOfDoors;


        public Car(string brand, string model, double price, int numberOFdoors):base(brand,model,price)
        {
            NumberOfDoors = numberOFdoors;
        }
        

        public override string DisplayDetails()
        {
            return $"Brand :{Brand}, Modael :{Model}, Price :{Price}, Number Of Doors: {NumberOfDoors}.";
        }
        public string StartEngine()
        {
            return "Car Engine Started";
            // Console.WriteLine($"Brand of Vehicle:{Brand}, Modael Car:{Model}, Price Car:{Price}, Number Of Doors:{NumberOfDoors}.");
        }
    }

}
