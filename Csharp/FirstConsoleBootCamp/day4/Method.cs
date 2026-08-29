using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4
{
    internal class Method
    {

        public void Compute_BMI()
        {

            Console.WriteLine("WELCOME TO Compute BMI System..");
            Console.Write("Enter Your Name:");
            String name = Console.ReadLine();

            Console.Write("Enter your weight:?");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Enter your height?:");
            double height = double.Parse(Console.ReadLine());

            double bmi = weight / Math.Pow((height / 100), 2);

            //Console.WriteLine("Welcome:"+name+ "\nYour BMI "+bmi);

            Console.WriteLine($"\nYoure Name:{name}.");
            Console.WriteLine($"Youre weight:{weight}");
            Console.WriteLine($"Youre height:{height}");
            Console.WriteLine($"Youre bmi:{bmi:F2}");

            if (bmi >= 30)
            {
                Console.WriteLine("obese.");
            }
            else if (bmi >= 25)
            {
                Console.WriteLine("OverWeight.");
            }
            else if (bmi >= 18.5)
            {
                Console.WriteLine("Normal.");
            }
            else
            {
                Console.WriteLine("UnderWeight.");
            }
        }

        public void Compute_PCT()
        {
            Console.WriteLine("WELCOME TO Compute PCT System..");
            Console.Write("Enter Your Name:");
            string name = Console.ReadLine();

            Console.Write("Enter Your Mark:");
            double mark = double.Parse(Console.ReadLine());

            Console.Write("Enter Your FullMArk:");
            double fullMark = double.Parse(Console.ReadLine());
            //double fullMark = 100;

            double percentage = (mark / fullMark) * 100;


            //Console.Write("Student Name: ");
            //Console.WriteLine(name);

            //Console.Write($"Student Name: {name} \n");
            Console.WriteLine($"Student Name:{name}. \nStudent Percentage is:{percentage:F2}%.");


            if (percentage >= 85)
            {
                Console.WriteLine("Excellent");
            }
            else if (percentage >= 75)
            {
                Console.WriteLine("Very Good");
            }
            else if (percentage >= 65)
            {
                Console.WriteLine("Good");
            }
            else if (percentage >= 50)
            {
                Console.WriteLine("Pass");
            }

            else
            {
                Console.WriteLine("Faill");
            }

        }


        public void Compute_BMI2(String name, double weight, double height)
        {

            Console.WriteLine("WELCOME TO Compute BMI System..");

            //Console.WriteLine("Welcome:"+name+ "\nYour BMI "+bmi);

            double bmi = weight / Math.Pow((height / 100), 2);
            Console.WriteLine($"\nYoure Name:{name}.");
            Console.WriteLine($"Youre weight:{weight}");
            Console.WriteLine($"Youre height:{height}");
            Console.WriteLine($"Youre bmi:{bmi:F2}");

            if (bmi >= 30)
            {
                Console.WriteLine("obese.");
            }
            else if (bmi >= 25)
            {
                Console.WriteLine("OverWeight.");
            }
            else if (bmi >= 18.5)
            {
                Console.WriteLine("Normal.");
            }
            else
            {
                Console.WriteLine("UnderWeight.");
            }
        }

        public void Compute_PCT2(string name, double mark, double fullMark)
        {
            Console.WriteLine("WELCOME TO Compute PCT System..");
            double percentage = (mark / fullMark) * 100;

            Console.WriteLine($"Student Name:{name}. \nStudent Percentage is:{percentage:F2}%.");


            if (percentage >= 85)
            {
                Console.WriteLine("Excellent");
            }
            else if (percentage >= 75)
            {
                Console.WriteLine("Very Good");
            }
            else if (percentage >= 65)
            {
                Console.WriteLine("Good");
            }
            else if (percentage >= 50)
            {
                Console.WriteLine("Pass");
            }

            else
            {
                Console.WriteLine("Faill");
            }

        }

    }
}
