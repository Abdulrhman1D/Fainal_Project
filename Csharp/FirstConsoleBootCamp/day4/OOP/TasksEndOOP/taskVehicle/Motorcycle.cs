using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.OOP.TasksEndOOP.taskVehicle
{
    public class Motorcycle : Vehicle
    {
        public bool HasSidCar;
        public Motorcycle(string brand, string model, double price, bool hasSidCar) : base(brand, model, price)
        {
            HasSidCar = hasSidCar;
        }
        public override string DisplayDetails()
        {
            return $"Brand :{Brand}, Modael :{Model}, Price :{Price}, Has Sid Car:{HasSidCar}.";
        }
        public string DoWheeli()
        {
            return "Motorcycle is doing a wheelie!";
        }
    }
}
