using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day3
{
    internal class Methods
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

        public void Program()   
        {

            Console.WriteLine("Welcome to System Program");

            int num01 = 10;
            int num02 = 20;

            Console.WriteLine("Num1 + Num2 = " + (num01 + num02));
            Console.WriteLine("Num1 - Num2 = " + (num01 - num02));
            Console.WriteLine("Num1 / Num2 = " + (num01 / num02));
            Console.WriteLine("Num1 * Num2 = " + (num01 * num02) + "\n");

            Console.Write("Enter First Number:");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter Second Number:");
            double num2 = double.Parse(Console.ReadLine());


            Console.Write("Enter Operator(+,-,*,/)");
            string oper = Console.ReadLine();


            if (oper == "+")
            {
                Console.WriteLine("Total = " + (num1 + num2));
            }
            else if (oper == "-")
            {
                Console.WriteLine("Total = " + (num1 - num2));
            }
            else if (oper == "*")
            {
                Console.WriteLine("Total = " + (num1 * num2));
            }
            else if (oper == "/")
            {
                if (num2 != 0)
                {
                    Console.WriteLine("Total = " + (num1 / num2));
                }
                else
                {
                    Console.WriteLine("Division br zero is not allowed.");
                }
            }
            else
            {
                Console.WriteLine("Sorry!! Wrong Entry.");
            }

        }

        public void RandomQuestion()
        {
            Console.WriteLine("Welcome to System Random");

            Random rnd = new Random();

            int num1 = rnd.Next(1, 11);
            int num2 = rnd.Next(1, 11);

            Console.WriteLine($"What is {num1} * {num2}?");
            Console.Write("Enter Answer:");
            int an = int.Parse(Console.ReadLine());

            if (an == num1 * num2)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
        }

        public void Loops()
        {

            Console.WriteLine("Welcome to System Loops");
            /*for (int i = 100; i >= 10; i -= 10)
            {
                Console.WriteLine(i);
            }*/

            Random rnd = new Random();
            int correctCount = 0;
            int wrongCount = 0;
            for (int i = 1; i <= 10; i++)
            {
                int num1 = rnd.Next(1, 11);
                int num2 = rnd.Next(1, 11);

                Console.WriteLine($"{i} - What is {num1} * {num2}?");
                Console.Write("Enter Answer:");

                int answer = int.Parse(Console.ReadLine());
                int mult = num1 * num2;
                if (answer == mult)
                {
                    Console.WriteLine("Correct!\n");
                    correctCount++;
                }
                else
                {
                    Console.WriteLine($"Wrong!! The Correct Answer is ={mult}. \n");
                    wrongCount++;
                }
            }
            if (correctCount > wrongCount)
            {
                Console.WriteLine("Well Done!");
            }
            else
            {
                Console.WriteLine("Keep practicing your math skills.");
            }
            Console.WriteLine($"-The Number of Corrects Answers is:({correctCount}).\n-The Number of Wrong Answers is:({wrongCount}).");
            Console.WriteLine("End Task ~ Thank You");
        }

        public void Check_day()
        {
            Console.WriteLine("Welcome to System Check_day");
            Console.WriteLine("Check Day");
            //Console.WriteLine("Sunday. \nMonday. \nTuesday. \nWednesday. \nThurday. \nFriday. \nSaturday.");

            Console.Write("Enter Your Day:");
            int day = int.Parse(Console.ReadLine());

            string today = "";

            if (day == 1)      { today = ("Sunday.");}
            else if (day == 2) { today = ("Monday.");}
            else if (day == 3) { today = ("Tuesday.");}
            else if (day == 4) { today = ("Wednesday.");}
            else if (day == 5) { today = ("Thursday.");}
            else if (day == 6) { today = ("Friday.");}
            else if (day == 7) { today = ("Saturday.");}
            else { Console.WriteLine("Invalid day.");}

            /* Console.WriteLine("Check Day");
             Console.Write("Enter Your Day:");
             int day = int.Parse(Console.ReadLine());
             string today = "";

             switch (day)
             {
                 case 1: today = ("WorkDay"); break;
                 case 2: today = ("WorkDay"); break;
                 case 3: today = ("WorkDay"); break;
                 case 4: today = ("WorkDay"); break;
                 case 5: today = ("WorkDay"); break;
                 case 6: today = ("OffDay"); break;
                 case 7: today = ("OffDay"); break;
                 default:
                     Console.WriteLine("Invalid day"); break;
             }*/

            Console.WriteLine(today);
        }

        public void StudentList()
        {
            Console.WriteLine("Welcome to System Student List");
            List<string> list = new List<string>();

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Enter Your Name:");
                string name = Console.ReadLine();

                Console.Write("Enter Your Mark:");
                double mark = double.Parse(Console.ReadLine());

                Console.Write("Enter Your FullMArk:");
                double fullMark = double.Parse(Console.ReadLine());
                double percentage = (mark / fullMark) * 100;

                string stu = "";
                if (percentage >= 85)
                {
                    stu=("Excellent");
                }
                else if (percentage >= 75)
                {
                    stu = ("Very Good");
                }
                else if (percentage >= 65)
                {
                    stu = ("Good");
                }
                else if (percentage >= 50)
                {
                    stu = ("Pass");
                }

                else
                {
                    stu = ("Faill");
                }

                list.Add($"Studint Name is:{name}. Mark of studint {mark}. Your Percentage is:{percentage}%. ({stu}).");

            }

            foreach (string nn in list)
            {
                Console.WriteLine(nn);

            }
        }


    }
}
