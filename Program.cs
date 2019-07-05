using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Onescu Oana Florentina", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);
            
            Console.WriteLine(account.CloseAccount());

            Console.WriteLine(account.GetAccountHistory());
            

        }

    }
}
