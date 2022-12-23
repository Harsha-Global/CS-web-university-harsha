using System;

namespace InnerExceptionExample
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
            catch (NullReferenceException ex) //it catches NullReferenceException
            {
                throw new ArgumentNullException("You have supplied null value to 'sourceAccount' parameter", ex); //it throws the same object of ArgumentNullException
            }

            try
            {
                destinationAccount.CurrentBalance += amount; //it throws a new object of NullReferenceException
            }
            catch (NullReferenceException ex) //it catches NullReferenceException
            {
                throw new ArgumentNullException("You have supplied null value to 'destinationAccount' parameter", ex); //it throws the same object of ArgumentNullException
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
                Console.WriteLine(ex.InnerException.Message);
            }
            Console.ReadKey();
        }
    }
}
