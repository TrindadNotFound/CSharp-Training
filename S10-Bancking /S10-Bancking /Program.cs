using S10_Bancking.entities;
using S10_Bancking.entities.exceptions;

Console.WriteLine("Account data : ");
Console.Write("Number: ");
int accountNumber  = int.Parse(Console.ReadLine());

Console.Write("Holder: ");
string accountHolder  = Console.ReadLine();

Console.Write("Initial balance: ");
double balance  = double.Parse(Console.ReadLine());

Console.Write("Withdraw limit: ");
double withdrawLimit = double.Parse(Console.ReadLine());

try
{
    Account acc = new Account(accountNumber, accountHolder, balance, withdrawLimit);

    Console.WriteLine();

    Console.Write("Enter amount to withdraw: ");
    double withdrawAmount = double.Parse(Console.ReadLine());

    acc.Withdraw(withdrawAmount);

    Console.WriteLine();
    Console.Write(acc);
}
catch (DomainException e)
{
    Console.WriteLine(e.Message);
}