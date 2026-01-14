using Microsoft.AspNetCore.Mvc;
using MVC_Boty.Database;
using MVC_Boty.Models;
using System.Text.Json;

namespace MVC_Boty.Controllers
{
    public class RegisterController : Controller
    {
        MyContext context = new();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register(RegisterModel register)
        {
            Accounts acc = new()
            {
                Name = register.Name,
                Surname = register.Surname,
                Email = register.Email,
                Phone = register.Phone,
                Username = register.Username,
                Password = register.Password
            };

            context.Accounts.Add(acc);
            context.SaveChanges();

            if (acc != null)
            {
                HttpContext.Session.SetInt32("Login", acc.Id);
                HttpContext.Session.SetString("Role", acc.AccountType.ToString());
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index");
        }
    }
}
