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

    public async Task<List<Seller>> FindAllAsync()
    {
        return await _context.Seller.ToListAsync();
    }
    
    public async Task InsertAsync(Seller seller)
    {
        _context.Add(seller);
        await _context.SaveChangesAsync();
    }

    public async Task<Seller?> FindByIdAsync(int sellerId)
    {
        return await _context.Seller
            .Include(obj => obj.Department)
            .FirstOrDefaultAsync(x => x.Id == sellerId);
    }

    public async Task RemoveAsync(int id)
    {
        try
        {
            var removeSellerObject = await _context.Seller.FindAsync(id);
            _context.Seller.Remove(removeSellerObject);
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateException e)
        {
            throw new IntegrityException(e.Message);
        }

    }
    
    public async Task UpdateAsync(Seller seller)
    {
        var hasAny = await _context.Seller.AnyAsync(x => x.Id == seller.Id);
        if (!hasAny)
        {
            throw new NotFoundException("Id not found");
        }

        try
        {
            _context.Update(seller);
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException ex)
        {
            throw new DbConcurrencyException(ex.Message);
        }
        
    }
}