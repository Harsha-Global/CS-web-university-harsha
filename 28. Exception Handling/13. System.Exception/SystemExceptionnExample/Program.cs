using System;
using System.IO;

namespace SystemExceptionExample
{
    class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }

        private double _currentBalance;
        public double CurrentBalance
        {
            get => _currentBalance;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"The value of 'CurrentBalance' should be a positive number. You have supplied {value}", "CurrentBalance");
                }
                _currentBalance = value;
            }
        }
    }


    //custom exception
    class InsufficientFundsException : InvalidOperationException
    {
        public InsufficientFundsException()
        {
        }

        public InsufficientFundsException(string message) : base(message)
        {
        }

        public InsufficientFundsException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    class ExceptionLogger
    {
        public static void AddException(Exception ex)
        {
            string filePath = @"c:\practice\ErrorLog.txt";
            StreamWriter streamWriter = File.AppendText(filePath);
            streamWriter.WriteLine("\n\nException on " + DateTime.Now);
            streamWriter.WriteLine(ex.GetType().ToString());
            streamWriter.WriteLine("\nStack Trace:");
            streamWriter.WriteLine(ex.StackTrace);
            streamWriter.WriteLine("\nMessage:");
            streamWriter.WriteLine(ex.Message);
            streamWriter.Close();
        }
    }

    class FundsTransfer
    {
        public void Transfer(BankAccount sourceAccount, BankAccount destinationAccount, double amount)
        {
            try
            {
                if (amount < 0 || amount > 10000)
                    throw new ArgumentOutOfRangeException("amount", 10000, "For funds transfer, the value of 'amount' should be between 1 to 10000");

                if (amount > sourceAccount.CurrentBalance)
                    throw new InsufficientFundsException($"Insufficient balance in the source account. The current balance is {sourceAccount.CurrentBalance}. But the amount to transfer is {amount}");
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
                fundsTransfer.Transfer(bobBankAccount, stevenBankAccount, 3000);
                Console.WriteLine("Funds Transferred");
            }
            catch (ArgumentNullException ex) //it catches the object of ArgumentNullException which was thrown in either of the catch blocks of 'Transfer' method
            {
                Console.WriteLine(ex.Message);
                if (ex.InnerException != null)
                    Console.WriteLine(ex.InnerException.Message);
                ExceptionLogger.AddException(ex);
            }
            catch (ArgumentOutOfRangeException ex) //it catches the object of ArgumentOutOfRangeException which was thrown in the 'Transfer' method
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ActualValue);
                Console.WriteLine(ex.ParamName);
                ExceptionLogger.AddException(ex);
            }
            catch (ArgumentException ex) //it catches the object of ArgumentException which was thrown in 'Transfer' method
            {
                Console.WriteLine(ex.Message);
                ExceptionLogger.AddException(ex);
            }
            catch (InsufficientFundsException ex) //it catches the object of InsufficientFundsException which was thrown in 'Transfer' method
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                ExceptionLogger.AddException(ex);
            }
            catch (InvalidOperationException ex) //it catches the object of InvalidOperationException which was thrown in 'Transfer' method
            {
                Console.WriteLine(ex.Message);
                ExceptionLogger.AddException(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ExceptionLogger.AddException(ex);
            }

            Console.ReadKey();
        }
    }
}
