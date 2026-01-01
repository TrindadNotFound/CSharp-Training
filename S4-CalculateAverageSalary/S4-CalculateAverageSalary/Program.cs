// See https://aka.ms/new-console-template for more information

using S4_CalculateAverageSalary.entities;

Console.WriteLine("Data from the first employee : ");
Console.Write("Name -> ");
string firstEmployeename = Console.ReadLine();
Console.Write("Salary -> ");
double firstEmployeeSalary = double.Parse(Console.ReadLine());

Employees firstEmployeeData = new Employees(firstEmployeename, firstEmployeeSalary);

Console.WriteLine();

Console.WriteLine("Data from the second employee : ");
Console.Write("Name -> ");
string secondEmployeeName = Console.ReadLine();
Console.Write("Salary -> ");
double secondEmployeeSalary = double.Parse(Console.ReadLine());

Employees secondEmployeeData = new Employees(secondEmployeeName, secondEmployeeSalary);

Console.WriteLine();

Console.WriteLine($"The avarage salary is {(firstEmployeeData.Salary + secondEmployeeData.Salary)/2}");



