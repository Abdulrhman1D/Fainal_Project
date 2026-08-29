using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.OOP.tasks
{
    public class Patient
    {
        private String _name;
        public String Name
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Invalid Name.");
                }
            }
            get
            {
                   return _name;
            }
        }

        private double _weight;
        public double Weight 
        { set 
            {
                if( value >= 1)
                {
                    _weight = value;
                }
                else
                {
                    Console.WriteLine("The Weight cannot be as entered.");    
                }
            } 
            get
                {
                return _weight;
                }
        }

        private double _height;
        public double Height 
        {
            set 
            {
                if (value >= 1)
                {
                    _height = value;
                }
                else
                {
                    Console.WriteLine("The Height cannot be as entered.");
                }
            }
            get 
            {
                return _height;
            }
        }

        //stor
        public Patient (String name, double weight, double height)
        {
            Name = name;
            Weight = weight;
            Height = height;    
        }
        public double Get_bmi()
        {
            double bmi = Weight / Math.Pow((Height / 100), 2);
            return bmi;
        }
        public String GetBmiStatus(double bmi)
        {
            if (bmi >= 30)
            {
                return "Your Body Mass Index is [obese].";
            }
            else if (bmi >= 25)
            {
                return "Your Body Mass Index is [OverWeight].";
            }
            else if (bmi >= 18.5)
            {
                return "Your Body Mass Index is [Normal].";
            }
            else
            {
                return "[UnderWeight].";
            }
        }
    }
}
