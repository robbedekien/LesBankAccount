using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Models.Domein
{
    class BankAccount
    {
        private string _accountNumber;
        private decimal _balance;

        public string AccountNumber { get; private set; }

        //public decimal GetBalance()
        //{
        //    return _balance;
        //}

        //public void SetBalance(decimal value)
        //{
        //    _balance = value;
        //}

        public decimal Balance
        {
            get
            {
                return _balance;
            }
            private set
            {
                if (value < 0)
                    throw new ArgumentException("No negative balance allowed");
                _balance = value;
            }
        }
        #region Constructors
        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
        }

        public BankAccount(string accountNumber, decimal balance) : this(accountNumber)
        {
            Balance = balance;
        }
        #endregion

        #region Methodes
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        #endregion

    }
}


