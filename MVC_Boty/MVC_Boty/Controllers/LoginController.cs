using Microsoft.AspNetCore.Mvc;
using MVC_Boty.Database;
using MVC_Boty.Models;
using System.Diagnostics;
using System.Text.Json;

namespace MVC_Boty.Controllers
{
    public class LoginController : Controller
    {
        MyContext context = new();

        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("Login") != null)
            {
                RedirectToAction("Index", "Home");
            }
            return View();
        }

        public IActionResult Login(LoginModel login)
        {
            var acc = context.Accounts.FirstOrDefault(a => a.Username == login.Username);

            if (acc != null)
            {
                HttpContext.Session.SetInt32("Login", acc.Id);
                HttpContext.Session.SetString("Role", acc.AccountType.ToString());
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Login");
            return RedirectToAction("Index");
        }
    }
}
