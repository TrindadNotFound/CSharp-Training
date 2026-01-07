
using System.Runtime.InteropServices;using S8_OutsourcedEmployee.entities;

Console.Write("Enter the number of employees : ");
int numberOfEmployees = int.Parse(Console.ReadLine());

Console.WriteLine("");

List<Employee> employeeList = new List<Employee>();

for (int i = 1; i <= numberOfEmployees; i++)
{
    Console.WriteLine($"Employee #{i} data : ");
    Console.Write("Is outsourced (Y/N) ? : ");
    char isOutsourcedChar = char.Parse(Console.ReadLine());
    
    if (isOutsourcedChar == 'N' || isOutsourcedChar == 'n')
    {
        Console.Write("Name : ");
        string name = Console.ReadLine();

        Console.Write("Hours : ");
        int hours = int.Parse(Console.ReadLine());

        Console.Write("Value per hour : ");
        double valuePerHour = double.Parse(Console.ReadLine());

        Employee employee = new Employee(name,  hours, valuePerHour);
        
        employeeList.Add(employee);
    }
    else
    {
        Console.Write("Name : ");
        string name = Console.ReadLine();

        Console.Write("Hours : ");
        int hours = int.Parse(Console.ReadLine());

        Console.Write("Value per hour : ");
        double valuePerHour = double.Parse(Console.ReadLine());

        Console.Write("Additional charge : ");
        double additionalCharge = double.Parse(Console.ReadLine());
        
        OutsourcedEmployee outsourcedEmployee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
        
        employeeList.Add(outsourcedEmployee);
    }
    
    Console.WriteLine("");
} 

Console.WriteLine("PAYMENTS :");
foreach (Employee emp in employeeList)
{
    Console.WriteLine($"{emp.Name} - {emp.Payment()}");
}