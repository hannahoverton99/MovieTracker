using Microsoft.AspNetCore.Mvc;

namespace MovieTracker.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            return View();
        }

    }
}
