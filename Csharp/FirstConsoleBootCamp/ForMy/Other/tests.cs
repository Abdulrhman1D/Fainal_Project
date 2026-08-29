using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp
{
    internal class tests
    {
        /*static void Main(string[] args)
        {
            
            Console.WriteLine("WELCOME TO WE WEB");
            Console.Write("Enter Employy Name:");
            string name = Console.ReadLine();

            Console.Write("Enter Employee Age:");
            int age = int.Parse(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine("Welcome:" + name);
            }
            else if (age < 18)
            {
                Console.WriteLine("Soryy Your CK your Parents");
            }
            */

            /*
            Console.Write("Enter Username:");
            string name = Console.ReadLine();

            Console.Write("Enter Password:");
            int pass = int.Parse(Console.ReadLine());
            if (name == "admin")
            {
                if (pass == 1234)
                {
                    Console.WriteLine("\nLogin Successful");
                    Console.WriteLine("Welcome Admin");
                }
                else
                {
                    Console.WriteLine("\n !!Wrong Password!!");
                }
            }
            else
            {
                Console.WriteLine("\n!!Wrong Username!!");
            }
            */

            /*
            Console.WriteLine("Welcome to we page");


            Console.Write("Enter Your Name:");
            string name = Console.ReadLine();

            Console.Write("Enter Employee Age:");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Experience:");
            int ex = int.Parse(Console.ReadLine());

            Console.Write("Do you have Diploma?");
            string diploma = Console.ReadLine();

            if (age >= 18 && (ex >= 2 || diploma == "yes"))
            {
                Console.WriteLine("Welcome " + name+ "\n  Status: Accepted");
            }
            
            else
            {
                Console.WriteLine("Welcome " + name + "\n Status: Rejected");
            }
            */
            /*
            Console.Write("Enter Your Name:");
            string name = Console.ReadLine();

            Console.Write("Do you have Diploma? (yes/no):");
            string diploma = Console.ReadLine();

            bool hasdiploma = diploma == "yes";

            Console.Write("Enter Order Amount:");
            double amount = double.Parse(Console.ReadLine());

            if(hasdiploma && amount >= 100)
            {
                Console.WriteLine("Welcome " + name + "\n  Order: Accepted.");
            }
            else
            {
                Console.WriteLine("Welcome " + name + "\n Status: Rejected.");
            }
            */

            /*
            Console.Write("Enter Your Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Choose Department");
            Console.WriteLine("1- IT");
            Console.WriteLine("2- Finance");
            Console.WriteLine("3- HR");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Welcome~" + name);
                    Console.WriteLine("Department: IT");
                    break;

                case 2:
                    Console.WriteLine("Welcome~" + name);
                    Console.WriteLine("Department: Fainenc");
                    break;

                case 3:
                    Console.WriteLine("Welcome~" + name);
                    Console.WriteLine("Department: HR");
                    break;

                default: 
                Console.WriteLine("Invalid Department");
                break;
            }
            */

            /*
             * Employee Login & Department Access System
             *
             * فكرة البرنامج:
             * - يطلب من المستخدم إدخال اسم الموظف وكلمة المرور.
             * - يتحقق من صحة كلمة المرور باستخدام if.
             * - إذا كانت كلمة المرور صحيحة، يعرض قائمة الأقسام.
             * - يختار المستخدم رقم القسم.
             * - يستخدم switch لتحديد القسم المختار وتنفيذ الكود الخاص به.
             * - يعرض اسم القسم ومستوى الصلاحية (Access Level) حسب اختيار المستخدم.
             * - إذا أدخل المستخدم رقم قسم غير موجود، تظهر رسالة تفيد بأن الاختيار غير صحيح.
             * - في النهاية يطبع رسالة ختامية للمستخدم.
             *
             * الهدف من التمرين:
             * - التدريب على استخدام Console.ReadLine().
             * - التدريب على استخدام if / else.
             * - التدريب على استخدام switch / case / default.
             * - فهم كيفية توجيه مسار البرنامج بناءً على مدخلات المستخدم.

            Console.Write("Hello \nEnter Employee Name:");
            string name = Console.ReadLine();

            Console.Write("Enter Password:");
            int pass = int.Parse(Console.ReadLine());

            if (pass == 1234)
            {
                Console.WriteLine("Welcome:'" + name+"'");

                Console.WriteLine("Choose Department");
                Console.WriteLine("1- IT");
                Console.WriteLine("2- Finance");
                Console.WriteLine("3- HR");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Welcome '" + name + "'\nDepartment: IT\n \nAccess Level : Full");
                        break;
                    case 2:
                        Console.WriteLine("Welcome '" + name + "'\nDepartment: Finance\n \nAccess Level : High");
                        break;
                    case 3:
                        Console.WriteLine("Welcome '" + name + "'\nDepartment: HR\n \nAccess Level : Limited");
                        break;
                    default:
                        Console.WriteLine("A wrong choice!!! Invalid Department.");
                        break;
                }
            }
            else
                Console.WriteLine("\nWrong Password!!");
            */


            /*

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " -> Even");
                }
                else 
                {
                    Console.WriteLine(i + " -> Odd");
                }
            }
            */

            /*
             * int i = 1;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }
            */

            /*
            Console.Write("Enter Your Name:");
            string name = Console.ReadLine();

            Console.Write("Enter Password:");
            int pass = int.Parse(Console.ReadLine());
            int attempts = 0;
            while (pass != 1234)
            {
                attempts++;

                if (attempts == 3)
                {
                    Console.WriteLine("Account Locked");
                    break;
                }
                Console.Write("Wrong Password!!\nEnter PASSWORD:");
                pass = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Welcome:" + name + " " + "in We page");
            // * /


            
            Console.Write("Enter Usarname:");
            string name = Console.ReadLine();
            Console.Write("Enter Password:");
            int pass = int.Parse(Console.ReadLine());

            int attempts = 0;
            while (pass != 2026) 
            {
                 
                attempts++;
                if (attempts >= 4)
                {
                    Console.WriteLine("Account Locked!");
                    break;
                }
                Console.Write("\nWrong Password\n"+ attempts +" of 3 Enter PASSWORD:");
                pass = int.Parse(Console.ReadLine());
                
            }
            if (pass == 2026)
            {
                Console.WriteLine("\nWelcome:" + name);
            }
            else
            {
                Console.WriteLine("Sorry");
            }
            




            Console.WriteLine("\n\n\nSEE YOU THANKS~'"+name+"'");
            Console.ReadKey(true);           
        }*/
    }
}
