using System.ComponentModel.DataAnnotations;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;
using Humanizer;

namespace SalesWebMVC.Models;

public class Seller
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "{0} is required")]
    [StringLength(20, MinimumLength = 3,  ErrorMessage = "{0} must be between {2} and {1} characters")]
    public String Name { get; set; }
    
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "{0} is required")]
    [EmailAddress(ErrorMessage = "{0} is not a valid email address")]
    public string Email { get; set; }
    
    [Display(Name = "Birth Date")]
    public DateOnly BirthDate { get; set; }
        
    [Display(Name = "Base Salary")]
    [DisplayFormat(DataFormatString = "{0:F2}")]
    [Required(ErrorMessage = "{0} is required")]
    [Range(100, 50000, ErrorMessage = "{0} must be between {1} and {2}")]
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