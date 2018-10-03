using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Models.Domein
{
    class Transaction
    {
        #region Properties
        public decimal Amount { get; }

        public TransactionType TransactionType { get; }

        public DateTime DateOfTransaction { get; }

        public bool isWithdraw { get
            {
                return TransactionType == TransactionType.Withdraw;
            } }

        public bool isDeposit { get
            {
                return TransactionType == TransactionType.Deposit;
            } }

        #endregion

        #region Constructors
        public Transaction(decimal amount, TransactionType transactionType)
        {
            Amount = amount;
            TransactionType = transactionType;
            DateOfTransaction = DateTime.Now;
        }
        #endregion
    }
}
