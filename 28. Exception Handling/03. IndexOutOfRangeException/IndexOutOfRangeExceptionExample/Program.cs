using System;

namespace IndexOutOfRangeExceptionExample
{
    class BankAccount
    {
        public string AccountHolderName { get; set; }
        public int AccountNumber { get; set; }
        public double CurrentBalance { get; set; }
    }
    class Program
    {
        static void Main()
        {
            try
            {
                BankAccount[] bankAccounts = new BankAccount[]
                {
                new BankAccount() { AccountNumber = 101, AccountHolderName = "Steven", CurrentBalance = 1000 },
                new BankAccount() { AccountNumber = 102, AccountHolderName = "Sara", CurrentBalance = 950 },
                new BankAccount() { AccountNumber = 103, AccountHolderName = "Mary", CurrentBalance = 456 }
                };

                for (int i = 0; i < bankAccounts.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {bankAccounts[i].AccountNumber}, {bankAccounts[i].AccountHolderName}, {bankAccounts[i].CurrentBalance}");
                }
                int serialNumber;
                Console.Write("Enter account serial number to print: ");
                serialNumber = int.Parse(Console.ReadLine());
                serialNumber--;
                if (serialNumber < 0 || serialNumber >= bankAccounts.Length)
                {
                    Console.WriteLine("Invalid serial number");
                }
                else
                {
                    BankAccount selectedBankAccount = bankAccounts[serialNumber]; //throws IndexOutOfRangeException
                    Console.WriteLine("Selected Bank Account Details:");
                    Console.WriteLine("Account Number: " + selectedBankAccount.AccountNumber);
                    Console.WriteLine("Account Holder Name: " + selectedBankAccount.AccountHolderName);
                    Console.WriteLine("Current Balance: " + selectedBankAccount.CurrentBalance);
                }
            }
            catch (IndexOutOfRangeException ex) //catches IndexOutOfRangeException
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadKey();
        }
    }
}
