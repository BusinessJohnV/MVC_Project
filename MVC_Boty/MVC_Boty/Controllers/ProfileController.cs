using Microsoft.AspNetCore.Mvc;
using MVC_Boty.Database;
using MVC_Boty.Models;
using System.Text.Json;

namespace MVC_Boty.Controllers
{
    [Secured]
    public class ProfileController : Controller
    {
        private MyContext context = new();

        public IActionResult Index()
        {
            var login = HttpContext.Session.GetInt32("Login");
            var acc = context.Accounts.Find(login.Value);
            var vm = new AccountModel
            {
                Username = acc.Username,
                Password = acc.Password,
                Name = acc.Name,
                Surname = acc.Surname,
                Email = acc.Email,
                Phone = acc.Phone,
                Country = acc.Country,
            };

            return View(vm);
        }
    }
}
