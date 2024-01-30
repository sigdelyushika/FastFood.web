using Microsoft.AspNetCore.Mvc;

namespace FastFood.web.Areas.Admin.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
