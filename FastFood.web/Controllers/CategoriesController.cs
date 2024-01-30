 using FastFood.Repository;
using FastFood.web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FastFood.web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public  IActionResult Index()
        {
            var listFromDb = _context.Categories.ToList().Select(x => new CategoryViewModel()
            {

                Id = x.Id,
                Title = x.Title

            }).ToList();
            
           
            
            return View();
        }
    }
}
