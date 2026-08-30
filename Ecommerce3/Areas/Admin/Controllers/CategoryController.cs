using Ecommerce3.Data;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce3.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        ApplicationDbContext Cotext = new ApplicationDbContext();
        public IActionResult Index()

        {
            var items = Cotext.categories.ToList();
            return View(items);
        }
    }
}