
namespace SalesWebMVC.Models;
using System.Linq;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public ICollection<Seller> Sellers { get; set; }  = new List<Seller>();

    public Department()
    {
    }

    public Department(string name)
    {
        Name = name;
    }

    public void AddSeller(Seller seller)
    {
        Sellers.Add(seller);
    }

    public void RemoveSeller(Seller seller)
    {
        Sellers.Remove(seller);
    }

    public double TotalSales(DateOnly initial, DateOnly final)
    {
        return Sellers
            .Sum(s=>s.TotalSales(initial, final));
    }
}