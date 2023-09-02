using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace SmartYBus.Controllers;
[Area("admin")]
public class HomeController : Controller
{
   
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }
    public IActionResult Create_account()
    {
        return View();
    }
    public IActionResult Forgot_password()
    {
        return View();
    }

    
    public IActionResult gps()
    {
      //TODO: Implement Realistic Implementation
      return View();
    }
}
