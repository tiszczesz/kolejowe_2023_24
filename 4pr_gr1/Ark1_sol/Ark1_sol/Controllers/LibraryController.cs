using Microsoft.AspNetCore.Mvc;

namespace Ark1_sol.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
