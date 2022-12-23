using System;

namespace NullReferenceExample
{
    class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public double CurrentBalance { get; set; }
    }

    class FundsTransfer
    {
        public void Transfer(BankAccount sourceAccount, BankAccount destinationAccount, double amount)
        {
            try
            {
                sourceAccount.CurrentBalance -= amount;
                destinationAccount.CurrentBalance += amount; //it throws a new object of NullReferenceException
            }
            catch (NullReferenceException ex) //it catches NullReferenceException
            {
                Console.WriteLine("The value of 'destinationAccount' is null");
                throw; //it throws the same object of NullReferenceException
            }
        }
    }
    class Program
    {
        static void Main()
        {
            try
            {
                BankAccount bobBankAccount = new BankAccount() { AccountNumber = 101, AccountHolderName = "Bob", CurrentBalance = 10000 };
                BankAccount aliceBankAccount = new BankAccount() { AccountNumber = 102, AccountHolderName = "Alice", CurrentBalance = 5000 };
                BankAccount stevenBankAccount = null;

                FundsTransfer fundsTransfer = new FundsTransfer();
                fundsTransfer.Transfer(bobBankAccount, stevenBankAccount, 1000);
                Console.WriteLine("Funds Transferred");
            }
            catch (NullReferenceException ex) //it catches the same object of NullReferenceException which was re-thrown in the catch block of 'Transfer' method
            {
                Console.WriteLine("The destination account is null");
            }
            Console.ReadKey();
        }
    }
}
