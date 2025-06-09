using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyStore.WebMVC.Models;
using Microsoft.EntityFrameworkCore;
using MyStore.Business; // Thêm dòng này để sử dụng các lớp trong MyStore.Business như Product, Category, MyStoreDbContext
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering; 
namespace MyStore.WebMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
