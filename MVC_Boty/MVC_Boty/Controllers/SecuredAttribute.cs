using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MVC_Boty.Controllers
{
    public class SecuredAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Controller controller = context.Controller as Controller;

            if (controller.HttpContext.Session.GetInt32("Login") == null)
            {
                context.Result = controller.RedirectToAction("Index", "Login");
            }
        }
    }
}
