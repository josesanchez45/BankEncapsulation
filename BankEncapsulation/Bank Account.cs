using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class Bank_Account
    {
        private double Balance = 0;

        public double Deposit(double amount)
        {
            return Balance += amount;
        }

        public void GetBalance()
        {
            Console.WriteLine(Balance);
        }

       
    }
}
