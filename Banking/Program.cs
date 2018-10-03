using Banking.Models.Domein;
using System;
using System.Collections.Generic;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myBA = new BankAccount("123-12312312-999" , 50);
            Console.WriteLine($"Accountnummer is  {myBA.AccountNumber}");
            Console.WriteLine($"Balance is {myBA.Balance} Euro");
            myBA.Deposit(200);
            Console.WriteLine($"Balance is {myBA.Balance} Euro");
            myBA.Withdraw(50);
            Console.WriteLine($"Balance is {myBA.Balance} Euro");

            foreach (var item in myBA.Transactions)
            {
                Console.WriteLine($"{item.Amount} -- {item.DateOfTransaction} -- {item.TransactionType}");
            }
            Console.ReadKey();
        }
    }
}
