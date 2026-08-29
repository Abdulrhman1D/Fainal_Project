using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.OOP.quiz
{
    public class Employee
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
                _name = value;
            }
        }

        private int _age;
        public int Age 
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 1)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("The Age cannot be as entered.");
                }
            }
        }

        private double _salary;
        public double Salary 
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value >= 1)
                {
                    _salary = value;
                }
                else
                {
                    Console.WriteLine("The Salary cannot be as entered.");
                }
            }
        }

        public Employee(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }


        public String DisplayEmployeeDetails()
        {

            return $"Name: {Name}, Age: {Age}, Salary: {Salary}";
        }

        public double CalculateAnnaulSalary()
        {
            double bmi = Salary * 12;
            return bmi;
        }


    }
}
