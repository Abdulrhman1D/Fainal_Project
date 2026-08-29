using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.OOP.TasksEndOOP.taskEmployee
{
    public class FreeLancer : IEmployee , IPrintable
    {

        public string Name;
        public double ProjectPrice;

        public FreeLancer(string name,double projectPrice)
        {
            Name = name;
            ProjectPrice = projectPrice;
        }

        public string Hello()
        {
            return Name;
        }
        public string DisplayEmployeeDetails()
        {
            return $"Name:{Name}, Project Price:{ProjectPrice}.";
        }
        public double CalculateAnnualSalary()
        {
            return ProjectPrice * 12;
        }

        public void Print()
        {
            Console.WriteLine($"Welcome:{Name}..");
        }


    }
}
