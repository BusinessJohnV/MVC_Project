using Microsoft.AspNetCore.Mvc;
using MVC_Boty.Database;
using MVC_Boty.Models;
using System.Text.Json;

namespace MVC_Boty.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(RegisterModel register)
        {
            MyContext context = new();
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

            var loginList = new List<string>() { register.Username, register.Password };

            HttpContext.Session.SetString("Login", JsonSerializer.Serialize(loginList));
            return RedirectToAction("Index", "Home");
        }
    }
}
