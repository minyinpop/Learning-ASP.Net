using Microsoft.AspNetCore.Mvc;

namespace Learning_ASP.Net.Controllers;

public sealed class LoginController : Controller
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

    [HttpPost]
    public IActionResult Test()
    {
        Console.WriteLine("收到 JS 的 Request。");
    
        return Json(new
        {
            success = true,
            message = "Hello JavaScript!"
        });
    }
}