using Banking.Models.Domein;
using System;

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
            Console.ReadKey();
        }
    }
}
