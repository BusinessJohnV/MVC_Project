using Microsoft.AspNetCore.Mvc;
using MVC_Boty.Database;
using MVC_Boty.Models;
using Mysqlx.Crud;
using System.Diagnostics;

namespace MVC_Boty.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        MyContext context = new();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var products = context.Products
                .Join(context.ProductDetails,
                p => p.Id,
                pd => pd.ProductId,
                (p, pd) => new ProductsModel
                {
                    Id = p.Id,
                    ProductId = pd.ProductId,
                    Quantity = pd.Quantity,
                    Color = pd.Color,
                    Size = pd.Size,
                    Price = pd.Price,
                    Discount = pd.Discount,
                    ProductName = p.ProductName,
                    Description = p.Description,
                    ImagePath = pd.ImagePath
                })
                .Take(4)
                .ToList();

            return View(products);
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
    }
}
