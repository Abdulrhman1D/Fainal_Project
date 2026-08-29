using FirstConsoleBootCamp.day4.OOP.Quiz2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.OOP.task2
{
    internal class VehicleTest
    {
        static void Mainn()
        {
            IList<Vehicle> vehicle = new List<Vehicle>
                {
            //  new Vehicle("Camry","2010",98000),
                new Car("Camry","2010",121000,4),
                new Motorcycle("Camry","2010",21000,false)
            };

            foreach (var ve in vehicle)
            {
                Console.WriteLine(ve.DisplayDetails()) ;
                Console.WriteLine(ve.GetPrice());
                
                if (ve is Car car)
                {
                    Console.WriteLine(car.StartEngine());
                }
                else if (ve is Motorcycle motorcycle)
                {
                    Console.WriteLine(motorcycle.DoWheeli());
                }
                Console.WriteLine("===================================");
            }

            Console.ReadKey();
        }
    }
}
