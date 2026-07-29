using Microsoft.AspNetCore.Mvc;

namespace Learning_ASP.Net.Controllers;

public sealed class RegisterController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}