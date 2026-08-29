using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.OOP.quiz
{
    public class EmployeeBase : Employee 
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

        public EmployeeBase(string name, int age, double salary, double bons):base ( name,  age,  salary)
        {
            Bons = bons;
        }

    }
}
