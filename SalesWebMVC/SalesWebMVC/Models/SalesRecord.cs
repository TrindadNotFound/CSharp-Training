using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Models;

public class SalesRecord
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public double Amount { get; set; }
    public SalesStatus Status { get; set; }
    
    public int SellerId { get; set; }
    public Seller Seller { get; set; }
    

    public SalesRecord(DateOnly date, double amount, SalesStatus status)
    {
        Date = date;
        Amount = amount;
        Status = status;
    }
}