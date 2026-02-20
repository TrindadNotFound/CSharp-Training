using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Model;
using SalesWebMVC.Services;

namespace SalesWebMVC.Controllers;

public class SalesRecordsController : Controller
{
    private readonly SalesRecordService _salesRecordService;

    public SalesRecordsController(SalesRecordService salesRecordService)
    {
        _salesRecordService = salesRecordService;
    }
    
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    public async Task<IActionResult> SimpleSearch(DateOnly? minDate, DateOnly? maxDate)
    {
        if (!minDate.HasValue)
        {
            minDate = new DateOnly(DateTime.Now.Year, 1, 1);
        }
        
        if (!maxDate.HasValue)
        {
            maxDate = DateOnly.FromDateTime(DateTime.Now);
        }
        
        ViewData["minDate"] = minDate.Value.ToString("dd/MM/yyyy");
        ViewData["maxDate"] = maxDate.Value.ToString("dd/MM/yyyy");
        
        var result = await _salesRecordService.FindByDateAsync(minDate, maxDate);
        return View(result);
    }
    
    public async Task<IActionResult> GroupingSearch(DateOnly? minDate, DateOnly? maxDate)
    {
        if (!minDate.HasValue)
        {
            minDate = new DateOnly(DateTime.Now.Year, 1, 1);
        }
        
        if (!maxDate.HasValue)
        {
            maxDate = DateOnly.FromDateTime(DateTime.Now);
        }
        
        ViewData["minDate"] = minDate.Value.ToString("dd/MM/yyyy");
        ViewData["maxDate"] = maxDate.Value.ToString("dd/MM/yyyy");
        
        var result = await _salesRecordService.FindByDateGroupingAsync(minDate, maxDate);
        return View(result);
    }
}