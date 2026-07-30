using Learning_ASP.Net.Models;
using Microsoft.AspNetCore.Mvc;

namespace Learning_ASP.Net.Controllers;

public sealed class RegisterController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult TryRegister(RegisterRequestModel model)
    {
        Console.WriteLine($"Username: {model.Username}");
        
        return Json(new
        {
            success = true
        });
    }
}