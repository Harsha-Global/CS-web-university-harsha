class BankAccount
{
    //private readonly fields
    private readonly int _accountNumber;
    private readonly double _curentBalance;

    //constructor
    public BankAccount(int accountNumber, double currentBalance)
    {
        _accountNumber = accountNumber;
        _curentBalance = currentBalance;
    }

    //public properties
    public int AccountNumber
    {
        get => _accountNumber;
    }

    public double CurrentBalance
    {
        get => _curentBalance;
    }
}

class DataStorage
{
    //developer 1 (you)
    public static List<BankAccount> GetBankAccounts()
    {
        return new List<BankAccount>() {
            new BankAccount(1, 1000),
            new BankAccount(2, 2000)
        };
    }

    //developer 2
    public static double GetCurrentBalance(BankAccount bankAccount)
    {
        //bankAccount.AccountNumber = 100; //unexpectedly it changes the value of Account Number
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