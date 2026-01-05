// See https://aka.ms/new-console-template for more information

using S8_WorkerContracts.entities;
using S8_WorkerContracts.entities.enums;

Console.Write("Enter department's name : ");
Department departmentName = new Department(Console.ReadLine()) ;

Console.WriteLine("--------------------");
Console.WriteLine("Worker data : ");
Console.Write("Name : ");
string workerName = Console.ReadLine();

Console.Write("Experience level (Junior/MidLevel/Senior) : ");
WorkerLevel experienceLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());

Console.Write("Base salary : ");
double baseSalary = double.Parse(Console.ReadLine());

Worker worker = new Worker(workerName, experienceLevel, baseSalary, departmentName);

Console.Write("How many contracts this worker have ? ");
int numberOfContracts = int.Parse(Console.ReadLine());

Console.WriteLine();

for (int i = 1; i <= numberOfContracts; i++)
{
    Console.WriteLine($"Contract #{i} data : ");
    
    Console.Write("Date (dd/MM/yyyy) : ");
    DateTime date = DateTime.Parse(Console.ReadLine());

    Console.Write("Value per hour : ");
    double valuePerHour = double.Parse(Console.ReadLine());
    
    Console.Write("Duration (hours) : ");
    int duration = int.Parse(Console.ReadLine());

    HourContract contract = new HourContract(date, valuePerHour, duration);
    
    worker.Contract.Add(contract);
    Console.WriteLine();
}

Console.WriteLine("--------------------");
Console.Write("Enter month and year to calculate respective income : ");
string monthAndYear = Console.ReadLine();

int month = int.Parse(monthAndYear.Split('/')[0]);
int year = int.Parse(monthAndYear.Split('/')[1]);

Console.WriteLine();
Console.WriteLine($"name : {worker.Name}");
Console.WriteLine($"Department : {worker.Department.Name}");
Console.WriteLine($"Income for {monthAndYear} : {worker.Income(year, month)}");