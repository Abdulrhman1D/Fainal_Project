using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.OOP.Quiz2
{
    public class BankAccount
    {
        public int AccountNumber;
        public string OwnrName;
        public double Balance;


        public BankAccount(int accountNumber, string ownrName, double balance)
        {
            AccountNumber = accountNumber;
            OwnrName = ownrName;
            Balance = balance;
        }

        public String DisplayAccount()
        {
            return $"Account Number:{AccountNumber}, Ownr Name:{OwnrName}, Balance:{Balance}.";
        }
        
        public double Deposit(double amount)
        {
            return Balance += amount ;
        }
    }
}
