using Microsoft.AspNetCore.Mvc;
using MVC_Boty.Database;

namespace MVC_Boty.ViewComponents
{
    public class CategoryMenuViewComponent : ViewComponent
    {
        public MyContext context = new();

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = context.Categories
                .ToList();

            return View(categories);
        }
    }
}
