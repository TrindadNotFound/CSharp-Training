using S8_WorkerContracts.entities.enums;

namespace S8_WorkerContracts.entities;

public class Worker
{
    public string Name { get; set; }
    public WorkerLevel Level { get; set; }
    public double BaseSalary { get; set; }
    public Department Department { get; set; }
    public List<HourContract> Contract { get; set; } = new List<HourContract>();

    public Worker() {}
    public Worker(string name, WorkerLevel workerLevel, double baseSalary,  Department department)
    {
        Name = name;
        Level = workerLevel;
        BaseSalary = baseSalary;
        Department = department;
    }

    public void AddContract(HourContract contract)
    {
        Contract.Add(contract);
    }

    public void RemoveContract(HourContract contract)
    {
        Contract.Remove(contract);
    }

    public double Income(int year, int month)
    {
        double sum = BaseSalary;

        foreach (HourContract i in Contract)
        {
            if (i.Date.Year == year && i.Date.Month == month)
            {
                sum += i.totalValue();
            }
        }

        return sum;
    }
    public override string ToString()
    {
        return "xpto";
    }
}