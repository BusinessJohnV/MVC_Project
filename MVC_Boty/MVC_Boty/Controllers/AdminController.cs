using Microsoft.AspNetCore.Mvc;
using MVC_Boty.Database;
using MVC_Boty.Models;

namespace MVC_Boty.Controllers
{
    [Secured]
    public class AdminController : Controller
    {
        MyContext context = new MyContext();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Categories()
        {
            var cats = context.Categories
                .Select(c => new CategoriesModel
                {
                    Id = c.Id,
                    ParentId = c.ParentId,
                    Name = c.Name,
                    Description = c.Description,
                })
                .ToList();

            return View(cats);
        }

        public IActionResult Accounts()
        {
            var accs = context.Accounts
                .Select(a => new AccountsModel
                {
                    Id = a.Id,
                    Username = a.Username,
                    Password = a.Password,
                    Name = a.Name,
                    Surname = a.Surname,
                    Email = a.Email,
                    Phone = a.Phone,
                    Country = a.Country,
                })
                .ToList();

            return View(accs);
        }

        public IActionResult Orders()
        {
            var orders = context.Orders
                .Join(context.OrderDetails, o => o.Id, od => od.OrderId,
                (o, od) => new OrdersModel
                {
                    Id = o.Id,
                    AccountId = o.AccountId,
                    OrderDate = o.OrderDate,
                    ShippingDate = o.ShippingDate,
                    CustomerName = o.CustomerName,
                    CustomerAddress = o.CustomerAddress,
                    CustomerCity = o.CustomerCity,
                    CustomerRegion = o.CustomerRegion,
                    CustomerPostcode = o.CustomerPostcode,
                    Country = o.Country,
                    OrderId = od.OrderId,
                    ProductId = od.ProductId,
                    Quantity = od.Quantity,
                    Price = od.Price,
                    Discount = od.Discount
                })
                .ToList();

            return View(orders);
        }

        public IActionResult Products()
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
                        ProductName = p.ProductName,
                        Description = p.Description
                    })
                .ToList();

            return View(prods);
        }
    }
}
