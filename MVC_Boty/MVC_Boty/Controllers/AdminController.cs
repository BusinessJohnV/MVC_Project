using Microsoft.AspNetCore.Mvc;
using MVC_Boty.Database;
using MVC_Boty.Models;

namespace MVC_Boty.Controllers
{
    [Secured]
    public class AdminController : Controller
    {
        ViewModel model = new ViewModel();
        MyContext context = new MyContext();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Categories()
        {
            foreach (var category in context.Categories)
            {
                model.categories.Add(category);
            }

            return View(model);
        }

        public IActionResult Colors()
        {
            foreach (var proddets in context.ProductDetails)
            {
                model.productDetails.Add(proddets);
            }

            return View(model);
        }

        public IActionResult Sizes()
        {
            foreach (var proddets in context.ProductDetails)
            {
                model.productDetails.Add(proddets);
            }

            return View(model);
        }
    }
}
