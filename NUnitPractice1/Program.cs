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
        private decimal minimumBalance = 10m;

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

            if (balance - amount < minimumBalance)
                throw new InsufficientFundsException();

            Withdraw(amount);
        }

        public decimal Balance
        {
            get { return balance;  }
        }

        public decimal MinimumBalance
        {
            get { return minimumBalance; }
        }
    }

    public class InsufficientFundsException : ApplicationException
    { 
    }
}
