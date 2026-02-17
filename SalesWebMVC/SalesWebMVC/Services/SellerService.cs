using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Model;
using SalesWebMVC.Models;
using SalesWebMVC.Services.Exceptions;

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
        return _context.Seller.Include(obj => obj.Department).FirstOrDefault(x => x.Id == sellerId);
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

    public void Update(Seller seller)
    {
        if (!_context.Seller.Any(obj => obj.Id == seller.Id))
        {
            throw new NotFoundException("Id not found");
        }

        try
        {
            _context.Update(seller);
            _context.SaveChanges();
        }
        catch (DbUpdateConcurrencyException ex)
        {
            throw new DbConcurrencyException(ex.Message);
        }
        
    }
}