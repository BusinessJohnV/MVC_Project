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

            if (controller.HttpContext.Session.GetString("Login") == null)
            {
                context.Result = controller.RedirectToAction("Index", "Login");
            }
        }
    }
}
