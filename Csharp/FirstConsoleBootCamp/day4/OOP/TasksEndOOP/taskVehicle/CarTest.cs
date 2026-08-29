using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.OOP.TasksEndOOP.taskVehicle
{
    internal class CarTest
    {
         static void Mainn()
         {
            

             IList<IVehicle> vehicle = new List<IVehicle>
                {
               // new Vehicle("Camry","2010",98000),
                new Car("Camry","2010",121000,4),
                new Motorcycle("Camry","2010",19000,false),
                new Drone("droony")
            };

            foreach (var ve in vehicle)
            {
                if (ve is Car car)
                {
                    Console.WriteLine(car.DisplayDetails());
                    Console.WriteLine(car.StartEngine());
                    Console.WriteLine(car.GetPrice());
                }
                else if (ve is Motorcycle motorcycle)
                {
                    Console.WriteLine(motorcycle.DisplayDetails());
                    Console.WriteLine(motorcycle.DoWheeli());
                }
                else if (ve is Drone drone)
                {
                    Console.WriteLine(drone.DisplayDetails());
                }
                Console.WriteLine("===================================");
            }
            Console.ReadKey();
        }
    }
}
