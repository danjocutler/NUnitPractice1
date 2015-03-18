using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Bank
{
    public class Account
    {
        [STAThread]
        static void Main()
        { 
        }

        private decimal balance;

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }

        public void TransferFunds(Account destination, decimal amount)
        {
            destination.Deposit(amount);
            Withdraw(amount);
        }

        public decimal Balance
        {
            get { return balance;  }
        }
    }
}
