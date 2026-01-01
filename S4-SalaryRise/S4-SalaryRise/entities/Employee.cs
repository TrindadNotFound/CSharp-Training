namespace S4_SalaryRise.entities;

public class Employee
{
    private string name;
    private double grossSalary;
    private double taxes;

    public Employee(string name, double grossSalary, double taxes)
    {
        this.name = name;
        this.grossSalary = grossSalary;
        this.taxes = taxes;
    }
    
    public string Name
    {
        get => name;
        set => name = value;
    }
    
    public double Taxes
    {
        get => taxes;
        set => taxes = value;
    }
    
    public double GrossSalary
    {
        get => grossSalary;
        set => grossSalary = value;
    }
    
    public void RiseSalary(double percentage)
    {
        grossSalary += grossSalary * (percentage / 100);
    }
    
    public double SalaryFreeOfTaxes()
    {
        return grossSalary - taxes;
    }

    public override string ToString()
    {
        return $"Updated employee data : {Name}, {SalaryFreeOfTaxes()}";
    }
}