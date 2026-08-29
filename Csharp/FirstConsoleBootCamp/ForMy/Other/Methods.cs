using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.Other
{
    internal class Methods
    {
        public string Nname (string name)
        {
            Console.WriteLine($"{name}.");
            return name;
        }

        public int sum(int number , int num2 , int num3)
        {
            return number * (number + num2) / num3;
        }

        public string PrintInfo(string name)
        {

            return name;
        }

        public void ChangeNumber(int x)
        {
            x = 100;
        }

        public void ChangeSalary(int salary)
        {
            salary = 10000;
        }
    }
}
