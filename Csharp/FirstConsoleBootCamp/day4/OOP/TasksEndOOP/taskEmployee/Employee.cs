using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.OOP.TasksEndOOP.taskEmployee
{
    public abstract class Employee : IEmployee
    {
        private string _name;
        public string Name 
        { 
            get 
            { 
                return _name;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _name = value;
                else
                    Console.WriteLine("Invalid input..");
            }
        }
        private double _projectprice;
        public double ProjectPrice 
        {
            get
            {
                return _projectprice;
            }
            set
            {
                if (value > 0)
                    _projectprice = value;
                else
                    Console.WriteLine("Invalid Project Price.");
            }
        }

        public Employee(string name, double projectPrice) 
        {
            Name = name;
            ProjectPrice = projectPrice;
        }

        public virtual string DisplayEmployeeDetails()
        {

            return $"Name: {Name}, Project Price:{ProjectPrice}.";
        }

        public abstract double CalculateAnnualSalary();


        public virtual string Hello()
        {
            return "Hello";
        }

    }
}
