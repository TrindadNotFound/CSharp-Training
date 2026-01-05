using S8_WorkerContracts.entities.enums;

namespace S8_WorkerContracts.entities;

public class Worker
{
    public string Name { get; set; }
    public WorkerLevel Level { get; set; }
    public double BaseSalary { get; set; }

    public Worker(string name, WorkerLevel workerLevel, double baseSalary)
    {
        Name = name;
        Level = workerLevel;
        BaseSalary = baseSalary;
    }
    
    public override string ToString()
    {
        return "xpto";
    }
}