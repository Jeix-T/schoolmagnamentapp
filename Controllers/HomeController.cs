using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SchoolMagnamentApp.Models;

namespace SchoolMagnamentApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // :] Muestra la vista Home
    public IActionResult Index()
    {
        return View();
    }

    // :] Muestra la vista Politicas
    public IActionResult Privacy()
    {
        return View();
    }

    // :] Muestra la vista A cerca de
    public IActionResult About(){
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    } 
}
