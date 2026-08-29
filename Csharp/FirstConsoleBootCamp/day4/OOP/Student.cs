using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.OOP
{
    public class Student
    {
        public string Name;
        private double Mark;
        private double FullMark;

        public Student(string name, double mark, double fullmar)
        {
            Name = name;
            Mark = mark;
            FullMark = fullmar;
        }


        public double Get_Pct()
        {
            double percentage = (Mark / FullMark) * 100;
            return percentage;
        }

        public double Get_Mark()
        {
            return Mark;
        }
        public void Set_Mark(double mark)
        {
           if(mark > 0)
            {
                Mark = mark;
            }
           else
            {
                Console.WriteLine("Invalid input");
            }  
        }

        public double Get_FullMark()
        {
            return FullMark;
        }
        public void Set_FullMark(double fullmark)
        {
            if (fullmark > 0)
            {
                FullMark = fullmark;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        public string Get_grade(double Mark)
        {
            if (Mark >= 85)
            {
                return ("Excellent");
            }
            else if (Mark >= 75)
            {
                return ("Very Good");
            }
            else if (Mark >= 65)
            {
                return ("Good");
            }
            else if (Mark >= 50)
            {
                return ("Pass");
            }

            else
            {
                return ("Faill");
            }
        }

    }
}
