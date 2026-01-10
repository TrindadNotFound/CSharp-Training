using S10_Bancking.entities.exceptions;

namespace S10_Bancking.entities;

public class Account
{
    public int Number { get; set; }
    public string Holder { get; set; }
    public double Balance { get; set; }
    public double WithdrawLimit { get; set; }

    public Account(int number, string holder, double balance, double withdrawLimit)
    {
        Number = number;
        Holder = holder;
        Balance = balance;
        WithdrawLimit = withdrawLimit;
    }
    
    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (Balance < amount)
        {
            throw new DomainException("Error : Not enough money");
        }

        if (WithdrawLimit < amount)
        {
            throw new DomainException("Error : Withdraw limit exceeded");
        }
        Balance -= amount;
    }

    public override string ToString()
    {
        return $"Account: {Number}, Holder: {Holder}, Balance: {Balance}, WithdrawLimit: {WithdrawLimit}";
    }
}