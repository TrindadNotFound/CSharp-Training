using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace SalesWebMVC.Models;

public class Seller
{
    public int Id { get; set; }
    public String Name { get; set; }
    public string Email { get; set; }
    public DateOnly BirthDate { get; set; }
    public double BaseSalary { get; set; }
    
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
    public ICollection<SalesRecord> Sales { get; set; }  = new List<SalesRecord>();

    public Seller()
    {
    }
    

    public Seller(string name, string email, DateOnly birthDate, double baseSalary)
    {
        Name = name;
        Email = email;
        BirthDate = birthDate;
        BaseSalary = baseSalary;
        DepartmentId = 0;
    }

    public void AddSales(SalesRecord salesRecord)
    {
        Sales.Add(salesRecord);
    }

    public void RemoveSales(SalesRecord salesRecord)
    {
        Sales.Remove(salesRecord);
    }

    public double TotalSales(DateOnly initial, DateOnly final)
    {
        return Sales
            .Where(s => s.Date >= initial && s.Date <= final)
            .Sum(s => s.Amount);
    }
}