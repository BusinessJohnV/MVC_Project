using Microsoft.AspNetCore.Mvc;
using MVC_Boty.Database;
using MVC_Boty.Models;
using System.Text.Json;

namespace MVC_Boty.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginModel login)
        {
            MyContext context = new();
            Accounts acc = new();
            acc = context.Accounts.Find(login.Username);

            if (acc != null && login.Password == acc.Password)
            {
                var loginList = new List<string>() { login.Username, login.Password };

                HttpContext.Session.SetString("Login", JsonSerializer.Serialize(loginList));
                return RedirectToAction("Index", "Home");
            }

            return View(login);
        }
    }
}
