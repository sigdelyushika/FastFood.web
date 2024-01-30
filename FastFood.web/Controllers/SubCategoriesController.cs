using FastFood.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FastFood.web.Controllers
{
    public class SubCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var subCategory = _context.SubCategories.Include(X=>X.category).ToList();
            return View(subCategory);
        }
    }
}
