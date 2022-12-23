using System;

namespace ArgumentNullExceptionExample
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
            }
            catch (NullReferenceException) //it catches NullReferenceException
            {
                throw new ArgumentNullException("sourceAccount", "You have supplied null value to 'sourceAccount' parameter"); //it throws the same object of ArgumentNullException
            }

            try
            {
                destinationAccount.CurrentBalance += amount; //it throws a new object of NullReferenceException
            }
            catch (NullReferenceException) //it catches NullReferenceException
            {
                throw new ArgumentNullException("destinationAccount", "You have supplied null value to 'destinationAccount' parameter"); //it throws the same object of ArgumentNullException
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
            catch (ArgumentNullException ex) //it catches the same object of ArgumentNullException which was thrown in either of the catch blocks of 'Transfer' method
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
