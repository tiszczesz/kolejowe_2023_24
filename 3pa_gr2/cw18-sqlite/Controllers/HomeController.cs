using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using cw18_sqlite.Models;

namespace cw18_sqlite.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private  BookRepo _repo;

    public HomeController(ILogger<HomeController> logger,IConfiguration configuration)
    {
        _logger = logger;
        _repo = new BookRepo(configuration);

    }

    public IActionResult Index()
    {
        var books = _repo.GetBooks();
        return View(books);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
