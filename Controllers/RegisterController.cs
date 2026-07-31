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
    public IActionResult TryRegister([FromBody] RegisterRequestModel register)
    {
        AccountDatabase.Initialize();
        AccountDatabase.CreateData(new AccountInformationModel(
            email: register.Email,
            username: register.Username,
            password: register.Password));
        
        return Json(new
        {
            success = true
        });
    }
}