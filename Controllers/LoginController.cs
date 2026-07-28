using Microsoft.AspNetCore.Mvc;

namespace Learning_ASP.Net.Controllers;

public class LoginController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(string username, string password)
    {
        Console.WriteLine(username);
        Console.WriteLine(password);
        
        return View();
    }
}