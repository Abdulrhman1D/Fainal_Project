using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.OOP.TasksEndOOP.taskVehicle
{
    public class Drone : IVehicle
    {
        public string Model;
        //ctor
        public Drone(string model)
        {
            Model = model;
        }
        public string DisplayDetails()
        {
            return $"Model:{Model}.";
        }
        public double GetPrice() { return 1; }
    }
}
