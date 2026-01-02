// See https://aka.ms/new-console-template for more information

using System.Security.Principal;
using S4_BankAccounts.entities;

Account account1;
Console.Write("Enter the account number: ");
int accountNumber = int.Parse(Console.ReadLine());

Console.Write("Holder account name : ");
string holderName = Console.ReadLine();

Account account = new Account(accountNumber, holderName);

Console.WriteLine();

Console.Write("Do you have an initial deposit? Y/N: ");
char haveInitialDeposit = char.Parse(Console.ReadLine());

if (haveInitialDeposit is 'Y' or 'y')
{
    Console.Write("Initial deposit amount: ");
    double initialDepositAmount = double.Parse(Console.ReadLine());
    
    account.AccountBalance = initialDepositAmount;
    Console.WriteLine(account);

} else if (haveInitialDeposit is 'N' or 'n')
{
    account.AccountBalance = 0;
    Console.WriteLine(account);
}

Console.WriteLine();

Console.Write("Enter the amount for the deposit: ");
double depositAmount = double.Parse(Console.ReadLine());
account.Deposit(depositAmount);

Console.WriteLine();
Console.WriteLine("Updated account data ");
Console.WriteLine(account);
Console.WriteLine();

Console.Write("Enter the amount to withdraw: ");
double withdrawAmount = double.Parse(Console.ReadLine());
account.Withdraw(withdrawAmount);
Console.WriteLine();

Console.WriteLine("Updated account data ");
Console.Write(account);
Console.WriteLine();