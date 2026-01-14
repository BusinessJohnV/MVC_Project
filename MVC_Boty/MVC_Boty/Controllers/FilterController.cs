using Microsoft.AspNetCore.Mvc;
using MVC_Boty.Database;
using MVC_Boty.Models;

namespace MVC_Boty.Controllers
{
    public class FilterController : Controller
    {
        MyContext context = new();
        public IActionResult Index()
        {
            var prods = context.Products
                .Join(context.ProductDetails,
                    p => p.Id,
                    pd => pd.ProductId,
                    (p, pd) => new ProductsModel
                    {
                        Id = pd.Id,
                        ProductId = pd.ProductId,
                        Quantity = pd.Quantity,
                        Color = pd.Color,
                        Size = pd.Size,
                        Price = pd.Price,
                        Discount = pd.Discount,
                        ProductName = p.ProductName,
                        Description = p.Description
                    })
                .ToList();

            return View(prods);
        }
    }
}
