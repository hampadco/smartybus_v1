using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using smartybus.Models;

namespace smartybus.Controllers;

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

    public IActionResult login()
    {
      //TODO: Implement Realistic Implementation
      return View();
    }

    public IActionResult Register()
    {
      //TODO: Implement Realistic Implementation
      return View();
    }

    public IActionResult about()
    {
      //TODO: Implement Realistic Implementation
      return View();
    }

     public IActionResult Howwork()
    {
      //TODO: Implement Realistic Implementation
      return View();
    }

    public IActionResult services()
    {
      //TODO: Implement Realistic Implementation
      return View();
    }

    public IActionResult contact()
    {
      //TODO: Implement Realistic Implementation
      return View();
    }

    public IActionResult blog()
    {
      //TODO: Implement Realistic Implementation
      return View();
    }

    public IActionResult faq()
    {
      //TODO: Implement Realistic Implementation
      return View();
    }
}
