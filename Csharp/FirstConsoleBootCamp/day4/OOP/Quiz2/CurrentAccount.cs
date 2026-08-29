using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.OOP.Quiz2
{
    public class CurrentAccount : BankAccount
    {
        public double OverdarftLimit;


        //ctor
        public CurrentAccount(double OverdarftLimit, int accountNumber, string ownrName, double balance) : base(accountNumber, ownrName, balance)
        {
            OverdarftLimit = OverdarftLimit;
        }

        public double Withdraw(double amount)
        {
            return Balance -= amount;
        }

    }
}
