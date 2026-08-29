using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstConsoleBootCamp.day4.OOP.TasksEndOOP.taskAccount
{
    public class Wallet : IAccount
    {
        private string _phone;
        public string Phone 
        {
            get
            {
                return _phone; 
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _phone = value;
                else
                    Console.WriteLine("Invalid input Phone Number..");
            }
        } 


        public Wallet(string phone)
        {
            Phone = phone;
        }

        public string DisplayAccount()
        {
            return $"Phone:{Phone}";
        }
    }
}
