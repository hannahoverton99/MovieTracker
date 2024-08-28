using Microsoft.AspNetCore.Mvc;
using MovieTracker.Classes;
using System.Linq;

namespace MovieTracker.Controllers
{
    public class FilmsController : Controller
    {
        private readonly MovieTrackerDbContext _context;

        public FilmsController(MovieTrackerDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var films = _context.Films.ToList();
            return View(films);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Films film)
        {
            if (ModelState.IsValid)
            {
                _context.Films.Add(film);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(film);
        }
    }
}
