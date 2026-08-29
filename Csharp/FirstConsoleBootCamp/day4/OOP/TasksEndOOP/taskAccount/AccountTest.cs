using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.OOP.TasksEndOOP.taskAccount
{
    internal class AccountTest
    {
        static void Main()
        {
            IAccount[] accounts = {
                new BankAccount("300001252320145"),
                new Wallet("0504970139"),
                new BankAccount("300001252412520"),
                new Wallet("0564467866")
            };

            string newAccountNumber = "";
            BankAccount bankAccount = (BankAccount)accounts[0];
            bankAccount.AccountNumber = newAccountNumber;


            foreach (var account in accounts)
            {
                Console.WriteLine(account.DisplayAccount());
            }

            Console.ReadKey();
        }
    }
}
