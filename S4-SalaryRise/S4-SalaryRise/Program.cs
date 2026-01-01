// See https://aka.ms/new-console-template for more information

using S4_SalaryRise.entities;

Console.Write("Name : ");
string name = Console.ReadLine();
Console.Write("Gross salary : ");
double grossSalary = double.Parse(Console.ReadLine());
Console.Write("Taxes : ");
double taxes = double.Parse(Console.ReadLine());

Employee employee = new Employee(name, grossSalary, taxes);

Console.WriteLine();

Console.Write("Rising percentage : ");
double risingPercentage = double.Parse(Console.ReadLine());
employee.RiseSalary(risingPercentage);

Console.Write($"Salary free of taxes : {employee.SalaryFreeOfTaxes()}");

Console.WriteLine();

Console.Write(employee);