using Learning_ASP.Net.Database.Account;
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
        AccountDatabase.Initialize();
        
        return Json(new
        {
            success = true
        });
    }
}