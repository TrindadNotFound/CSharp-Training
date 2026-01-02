namespace S4_BankAccounts.entities;

public class Account
{
    public string AccountHolderName { get; set; }
    public int AccountNumber { get; private set; }
    public double AccountBalance { get; set; }

    public Account(int accountNumber, string accountHolderName)
    {   
        AccountNumber = accountNumber;
        AccountHolderName = accountHolderName;
    }

    public void Deposit(double amount)
    {
        AccountBalance += amount;
    }

    public void Withdraw(double amount)
    {
        AccountBalance -= amount;
    }

    public override string ToString()
    {
        return
            $"Account details --> Account holder name: {AccountHolderName}, Account number: {AccountNumber}, Account balance: {AccountBalance}";
    }
}