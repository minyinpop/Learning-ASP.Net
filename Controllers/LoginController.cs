using Learning_ASP.Net.Database.Account;
using Learning_ASP.Net.Models.Login;
using Microsoft.AspNetCore.Mvc;
using Learning_ASP.Net.Models;

namespace Learning_ASP.Net.Controllers;

public sealed class LoginController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult TryLogin([FromBody] LoginRequest login)
    {
        Console.WriteLine(login.Email);
        Console.WriteLine(login.Password);
        
        var result = AccountDatabase.GetData(login.Email);
        var model = result.Model;
        
        bool success;
        string message;

        switch (result.Result)
        {
            case AccountDatabaseResult.Login_Successfully:
            {
                if (login.Password == model.Password)
                {
                    success = true;
                    message = "登入成功！";
                }
                else
                {
                    success = false;
                    message = "帳號或密碼錯誤！";
                }

                break;
            }
            case AccountDatabaseResult.Login_AccountNotExists:
            {
                success = false;
                message = "此帳號不存在！";
                break;
            }
            default:
            {
                Console.WriteLine($"{nameof(TryLogin)} 傳入了沒有被實作的結果：{result}");

                success = false;
                message = "發生了錯誤，請聯絡網站管理者：minyinpop@gmail.com\n錯誤訊息：登入介面的資料庫要求結果沒有被實作。";
                break;
            }
        }

        return Json(new
        {
            success,
            message
        });
    }
}