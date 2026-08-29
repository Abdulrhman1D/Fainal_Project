using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.OOP.TasksEndOOP.taskEmployee
{
    internal class EmployeeTest
    {
        static void Mainn(string[] args)
        {
            FreeLancer fre ;
            IList<IEmployee> empl = new List<IEmployee>
            {
                new FreeLancer("Abdulrhman",1200),
            };

            foreach (IEmployee employee in empl)
            {
                if(employee is FreeLancer)
                {
                    Console.WriteLine(employee.Hello());
                    Console.WriteLine(employee.CalculateAnnualSalary());
                    Console.WriteLine();
                }
                Console.WriteLine("Done");
                
            }
            Console.ReadKey(true);
        }
    }
}
