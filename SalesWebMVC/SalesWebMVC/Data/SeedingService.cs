using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Model;
using SalesWebMVC.Model;
public class SeedingService
{
    private SalesWebMVCContext _context;
    
    public SeedingService(SalesWebMVCContext context)
    { 
        _context = context;
    }

    public void Seed()
    {
        if (_context.Department.Any() ||
            _context.Seller.Any() ||
            _context.SalesRecord.Any())
        {
            return; //If DB isn't empty
        }

        Department department_0 = new Department("No department");
        Department department_1 = new Department("Sales");
        Department department_2 = new Department("Marketing");
        Department department_3 = new Department("IT");
        Department department_4 = new Department("Finance");
        
        _context.Department.AddRange(department_0, department_1, department_2, department_3, department_4);
        _context.SaveChanges();
        

        Seller seller_1 = new Seller("John Doe", "john@mail.com", new DateOnly(1990, 01, 01),1000.0);
        seller_1.DepartmentId = department_1.Id;

        Seller seller_2 = new Seller("Jane Doe", "jane@mail.com", new DateOnly(1990, 01, 01), 1000.0);
        seller_2.DepartmentId = department_2.Id;
        
        Seller seller_3 = new Seller("Tommy Doe", "tommy@mail.com", new DateOnly(1990, 12, 02), 1000.0);
        seller_3.DepartmentId = department_3.Id;
        
        Seller seller_4 = new Seller("Kin Doe", "kin@mail.com", new DateOnly(1990, 11, 02), 1000.0);
        seller_4.DepartmentId = department_4.Id;
        
        _context.Seller.AddRange(seller_1, seller_2, seller_3, seller_4);
        _context.SaveChanges();
        
        
        SalesRecord salesRecord_1 = new SalesRecord(new DateOnly(2018, 09, 01), 12000.0, SalesStatus.Billed);
        salesRecord_1.SellerId = seller_1.Id;

        SalesRecord salesRecord_2 = new SalesRecord(new DateOnly(2019, 09, 01), 32000.0, SalesStatus.Pending);
        salesRecord_2.SellerId = seller_2.Id;

        SalesRecord salesRecord_3 = new SalesRecord(new DateOnly(2008, 09, 01), 102000.0, SalesStatus.Billed);
        salesRecord_3.SellerId = seller_3.Id;
        
        _context.SalesRecord.AddRange(salesRecord_1, salesRecord_2, salesRecord_3);
        _context.SaveChanges();
    }
}