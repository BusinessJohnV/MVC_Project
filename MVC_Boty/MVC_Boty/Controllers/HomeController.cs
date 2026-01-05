using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Boty.Database;
using MVC_Boty.Models;

namespace MVC_Boty.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ViewModel model = new();
        MyContext context = new();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            foreach (var item in context.Products)
            {
                model.products.Add(item);
            }
            foreach (var item in context.ProductDetails)
            {
                model.productDetails.Add(item);
            }
            foreach (var item in context.Categories)
            {
                model.categories.Add(item); 
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Login");
            return View();
        }
    }
}
