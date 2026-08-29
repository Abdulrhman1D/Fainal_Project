using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.OOP.Quiz2
{
    public class SavingsAccount : BankAccount
    {
        public int InterestRate;


        public SavingsAccount(int interestRate, int accountNumber, string ownrName, double balance) :base (accountNumber, ownrName, balance)
        {
            
            InterestRate = interestRate;
        }


        public double CalculateInterest(double amount)
        {
            return Balance * amount / 100;
        }

    }

}
