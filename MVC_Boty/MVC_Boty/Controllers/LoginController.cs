using Microsoft.AspNetCore.Mvc;

namespace MVC_Boty.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
