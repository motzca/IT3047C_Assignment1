using System.Linq;
using Microsoft.AspNetCore.Mvc;
using motz_chloe_assign_1.doc.Pages.Models;
using Microsoft.EntityFrameworkCore;

namespace motz_chloe_assign_1.doc.Pages.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext context { get; set; }

        public HomeController(MovieContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var movies = context.Movies.Include(m => m.Genre).OrderBy(m => m.Name).ToList();
            return View(movies);
        }
    }
}
