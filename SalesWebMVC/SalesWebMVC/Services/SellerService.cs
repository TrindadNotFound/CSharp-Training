using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Model;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services;

public class SellerService
{
    private readonly SalesWebMVCContext _context;
    
    public SellerService(SalesWebMVCContext context)
    {
        _context = context;
    }

    public List<Seller> FindAll()
    {
        return _context.Seller.ToList();
    }

    public Seller FindById(int sellerId)
    {
        return _context.Seller.FirstOrDefault(x => x.Id == sellerId);
    }

    public void Remove(int id)
    {
        var removeSellerObject = _context.Seller.Find(id);
        _context.Seller.Remove(removeSellerObject);
        _context.SaveChanges();
    }
    
    public void Insert(Seller seller)
    {
        _context.Add(seller);
        _context.SaveChanges();
    }
}