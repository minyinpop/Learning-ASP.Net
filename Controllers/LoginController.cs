using Microsoft.AspNetCore.Mvc;

namespace Learning_ASP.Net.Controllers;

public class LoginController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}