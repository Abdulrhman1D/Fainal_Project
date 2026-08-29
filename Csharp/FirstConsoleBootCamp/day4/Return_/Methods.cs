using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.Return_
{
    internal class Methods
    {

        //---------------Void Functions-------------- 

        public void Hello()
        {
            Console.WriteLine("Abdulrhman Aldossry");
        }

        public void Compute_Pct2(string name, double mark, double fullMark)
        {
            double percentage = (mark / fullMark) * 100;
            Console.Write($" Student Name:  {name} \nyour  mark is: {mark} \nYour Percentage is:{percentage} %");
        }
        public void Compute_BMI2(string name, double weight, double height)
        {
            double BMI = weight / Math.Pow((height / 100), 2);

            Console.WriteLine($"Patient Name: {name} ");
            Console.WriteLine($"Patient Weight:{weight} ");
            Console.WriteLine($"Patient Height: {height}");
            Console.WriteLine($"Patient BMI: {BMI} ");
        }

        //--------------------------------------------



        //---------------Return Functions--------------

        public double Compute_Pct3(string name, double mark, double fullMark)
        {
            double percentage = (mark / fullMark) * 100;
            return percentage;
        }


        public double Compute_BMI3(string name, double weight, double height)
        {
            double BMI = weight / Math.Pow((height / 100), 2);
            return BMI;
        }



        public List<object> Compute_Pct4(string name, double mark, double fullMark)
        {
            double percentage = (mark / fullMark) * 100;


            List<object> inro_PTC = new List<object>();
            inro_PTC.Add(name);
            inro_PTC.Add(mark);
            inro_PTC.Add(fullMark);

            return (inro_PTC);
        }

        //--------------------------------------------------------------------

        public List<object> Compute_BMI4(string name, double weight, double height)
        {

            double BMI = weight / Math.Pow((height / 100), 2);

            List<object> inro_BMI = new List<object>();
            inro_BMI.Add(name);
            inro_BMI.Add(weight);
            inro_BMI.Add(height);


            return (inro_BMI);
        }
    }
}
