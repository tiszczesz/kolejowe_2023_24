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
    [HttpGet]
    public IActionResult Insert(){
        //aby wyswietlic formularz
        return View();
    }
    [HttpPost]
     public IActionResult Insert(Book book){
        //aby wystawic ksiazke z formularza do SQLite
        if(ModelState.IsValid){
            //zapisanie do bazy i przekierowanie do tabelki
            _repo.InsertBook(book);
            return RedirectToAction(nameof(Index));
        }
        //powrot do formularza z informacjami o bledach
        return View(book);
    }
    [HttpGet]
    public IActionResult SortByTitle(){
        var books = _repo.GetBooks().OrderBy(b=>b.Title).ToList();
        return View("Index",books);
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
