Console.Write("How many employees will be registered ? ");
int numberOfEmployee = int.Parse(Console.ReadLine());

List<Employee> employeesList = new List<Employee>();

for (int i = 1; i <= numberOfEmployee; i++)
{
    Console.WriteLine($"Employee #{i}");

    Console.Write("ID : ");
    int id = int.Parse(Console.ReadLine());

    Console.Write("Name : ");
    string name = Console.ReadLine();

    Console.Write("Salary : ");
    double salary = double.Parse(Console.ReadLine());

    employeesList.Add(new Employee(id, name, salary));
    Console.WriteLine();
}

Console.WriteLine();

Console.Write("Enter the employee ID that will have salary increase : ");
int employeeIdToIncrease = int.Parse(Console.ReadLine());

Employee employee = employeesList.Find(x => x.Id == employeeIdToIncrease);

if (employee != null)
{
    Console.Write("Enter the percentage : ");
    double increasePercentage = double.Parse(Console.ReadLine());

    employee.IncreaseSalary(increasePercentage);
}
else
{
    Console.WriteLine("Employee ID doesn't exist");
}

Console.WriteLine();
Console.WriteLine("Updated employee list :");
foreach (Employee item in employeesList)
{
    Console.WriteLine(item);
}