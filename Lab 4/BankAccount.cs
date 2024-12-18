using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class BankAccount
    {
        public double initialBalance;
        public string accountHolderName;

        public BankAccount(string accountHolderName,double initialBalance)
        {
            this.accountHolderName = accountHolderName;
            this.initialBalance = initialBalance;
        }

        public  void Deposite(double ammount)
        {
            Console.WriteLine("This deposite using cheque" );
            Console.WriteLine("your name is:" + accountHolderName);
            Console.WriteLine("Your current balance is:"+(initialBalance + ammount));
        }
        public void Withdraw(double ammount)
        {
            Console.WriteLine("This Withdraw using cash");
            try
            {
                initialBalance -= ammount;
            }
            catch (Exception) 
            { 
                Console.WriteLine("amount is empty");
            }
            Console.WriteLine("your name is:" + accountHolderName);
            Console.WriteLine("Your current balance is:" + initialBalance);
        }

        public void Deposite(double ammount,int chequeNumber)
        {
            Console.WriteLine("This Deposite using cheque"+chequeNumber);
            Console.WriteLine("your name is:" + accountHolderName);
            Console.WriteLine("Your current balance is:" + (initialBalance + ammount));
        }
        public void Withdraw(double ammount, int chequeNumber)
        {
            Console.WriteLine("This Withdraw using cheque" + chequeNumber);
            try
            {
                initialBalance -= ammount;
            }
            catch (Exception)
            {
                Console.WriteLine("amount is empty");
            }
            Console.WriteLine("your name is:" + accountHolderName);
            Console.WriteLine("Your current balance is:" + initialBalance);
        }
    }
}
