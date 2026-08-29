using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.OOP.quiz
{
    public class EmployeeHour : Employee
    {

        private double _bons;
        public double Bons
        {
            get
            {
                return _bons;
            }
            set
            {
                if (value >= 1)
                {
                    _bons = value;
                }
                else
                {
                    Console.WriteLine("The Bons cannot be as entered.");
                }
            }
        }

        private int _hours;
        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if (value >= 1)
                {
                    _hours = value;
                }
                else
                {
                    Console.WriteLine("Invaled.");
                }
            }
        }

        private double _hourlyRate;
        public double HourlyRate
        {
            get
            {
                return _hourlyRate;
            }
            set
            {
                if (value >= 1)
                {
                    _hourlyRate = value;
                }
                else
                {
                    Console.WriteLine("Invaled.");
                }
            }
        }

        public EmployeeHour(string name, int age, double salary, int hours, double hourlyRate):base (name,age,salary)
        {
            Hours = hours;
            HourlyRate = hourlyRate;
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
