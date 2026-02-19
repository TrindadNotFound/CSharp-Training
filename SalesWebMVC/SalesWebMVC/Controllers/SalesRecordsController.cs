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
        var result = await _salesRecordService.FindByDateAsync(minDate, maxDate);
        return View();
    }
    
    public IActionResult GroupingSearch()
    {
        return View();
    }
}