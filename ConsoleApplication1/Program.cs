using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program 
    {
        static void Main(string[] args)
        {

        }

        public static char Evaluate(int score)
        {
            if (score > 50)
                return 'f';
            else
                return 'b';

        }

    }

    public class Account
    {
        private float balance;
        public void Deposit(float amount)
        {
            balance += amount;
        }

        public void Withdraw(float amount)
        {
            balance -= amount;
        }

        public void TransferFunds(Account destination, float amount)
        {
            destination.balance = amount;
        }

        public float Balance
        {
            get { return balance; }
        }
    }



}
