using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Models.Domein
{
    public class SavingsAccount : BankAccount
    {
        private const decimal WithdrawCost = 0.10M;

        public decimal InterestRate { get; private set; }

        public SavingsAccount(string accountNumber, decimal interestRate) : base(accountNumber)
        {
            InterestRate = interestRate;
        }

        public override void Withdraw(decimal amount)
        {
            base.Withdraw(amount + WithdrawCost);
        }

        public void addIntrest()
        {
            Deposit(Balance * InterestRate);
        }
    }
}
