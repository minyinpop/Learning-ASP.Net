using Learning_ASP.Net.Database.Account;
using Microsoft.AspNetCore.Mvc;
using Learning_ASP.Net.Models;

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
        
        var result = AccountDatabase.CreateData(new AccountInformationModel(
            email: register.Email,
            username: register.Username,
            password: register.Password));

        bool success;
        string message;

        switch (result)
        {
            case AccountDatabaseResult.AccountRegisterSuccessfully:
            {
                success = true;
                message = "帳號創建成功，即將為您導航到登入介面！";
                break;
            }
            case AccountDatabaseResult.AccountIsAlreadyExists:
            {
                success = false;
                message = "帳號創建失敗，此信箱已被註冊過了！";
                break;
            }
            default:
            {
                Console.WriteLine($"{nameof(TryRegister)} 傳入了沒有被實作的結果：{result}");
                
                success = false;
                message = "發生了錯誤，請聯絡網站管理者：minyinpop@gmail.com\n錯誤訊息：註冊介面的資料庫要求結果沒有被實作。";
                break;
            }
        }

        return Json(new
        {
            success,
            message
        });
    }

    [HttpGet]
    public IActionResult GetRegisterRules()
    {
        var json = System.IO.File.ReadAllText("Configs/RegisterRules.json");
        
        return Content(json, "application/json");
    }
}