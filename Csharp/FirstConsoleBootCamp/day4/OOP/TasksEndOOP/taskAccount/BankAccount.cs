using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstConsoleBootCamp.day4.OOP.TasksEndOOP.taskAccount
{
    public class BankAccount : IAccount
    {
        private string _accountNumber;
        public string AccountNumber
        {
            get 
            {
                return _accountNumber;
            }
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _accountNumber = value;
                else
                    Console.WriteLine("Invalid input Account Number..");
            }
        }

        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
        }

        public string DisplayAccount()
        {
            return $"Account Number:{AccountNumber}";
        }

    }
}
