using Microsoft.AspNetCore.Mvc;

namespace MVC_Boty.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
