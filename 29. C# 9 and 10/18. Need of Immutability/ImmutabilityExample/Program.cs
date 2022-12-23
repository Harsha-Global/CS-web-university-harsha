class BankAccount
{
    public int AccountNumber { get; set; }
    public double CurrentBalance { get; set; }
}

class DataStorage
{
    //developer 1 (you)
    public static List<BankAccount> GetBankAccounts()
    {
        return new List<BankAccount>() {
            new BankAccount() { AccountNumber = 1, CurrentBalance = 1000 },
            new BankAccount() { AccountNumber = 2, CurrentBalance = 2000 }
        };
    }

    //developer 2
    public static double GetCurrentBalance(BankAccount bankAccount)
    {
        bankAccount.AccountNumber = 100; //unexpectedly it changes the value of Account Number
        return bankAccount.CurrentBalance;
    }
}

class Program
{
    static void Main()
    {
        List<BankAccount> bankAccounts = DataStorage.GetBankAccounts();
        BankAccount firstBankAccount = bankAccounts[0];
        double bal = DataStorage.GetCurrentBalance(firstBankAccount);
        
        Console.WriteLine(firstBankAccount.AccountNumber + ", " + bal);
        Console.ReadKey();
    }
}