namespace S4_CalculateAverageSalary.entities;

public class Employees
{
    private string name;
    private double salary;

    public Employees(string name, double salary)
    {
        this.name = name;
        this.salary = salary;
    }

    public string Name
    {
        get => name;
        set => name = value;
    }
    
    public double Salary
    {
        get => salary;
        set => salary = value;
    }
}