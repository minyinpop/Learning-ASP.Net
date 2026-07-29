using Microsoft.AspNetCore.Mvc;

namespace Learning_ASP.Net.Controllers;

public sealed class RegisterController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}