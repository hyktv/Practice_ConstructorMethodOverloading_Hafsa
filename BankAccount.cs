using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_ConstructorMethodOverloading_Hafsa
{
    internal class BankAccount
    {
        //fields
        public string _accountNumber;
        public string _customerName;
        public double _balance;

        //constructor
        public BankAccount(string accountNumber, string customerName, double initialBalance)
        {
            _accountNumber = accountNumber;
            _customerName = customerName;
            _balance = initialBalance;
        }

        //properties
        //readonly property
        public string AccountNumber
        {
            get { return _accountNumber; }
        }

        //get set
        public string CustomerName 
        { 
            get => _customerName; set => _customerName = value; 
        }

        //readonly property
        public double Balance
        {
            get { return _balance; }
        }

        //methods
        public void Deposit(double amount)
        {
            if (amount >= 0)
            {
                _balance += amount;
            }
            else
            {
                Console.WriteLine("invalid amount");
            }
        }//deposit method

        public void Withdraw(double amount)
        {
            if (amount >= 0 && amount <= _balance)
            {
                _balance -= amount;
            }
            else
            {
                Console.WriteLine("invalid amount");
            }
        }//withdraw method


        //override Tostring()
        public override string ToString()
        {
            return $"{AccountNumber} - {CustomerName} - Current Balance: {_balance.ToString("c")}";
        }



    }//class




}//namespace
