using Microsoft.AspNetCore.Mvc;
using MovieTracker.Classes;
using System.Linq;

namespace MovieTracker.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MovieTrackerDbContext _context;

        public MoviesController(MovieTrackerDbContext context)
        {
            _context = context;
        }

        // GET: Movies
        public IActionResult Index()
        {
            var movies = _context.Films.ToList();
            return View(movies);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,Genre,Rating")] Films film)
        {
            if (ModelState.IsValid)
            {
                _context.Add(film);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(film);
        }

        // Implement the Edit, Details, and Delete actions similarly
    }
}

