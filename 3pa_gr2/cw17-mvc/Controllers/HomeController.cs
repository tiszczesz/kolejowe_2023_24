using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using cw17_mvc.Models;

namespace cw17_mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["ff"] = "Dane z akcji";
        return View();
    }
    public IActionResult List(){
        List<string> colors = new(){"white","green","blue","yellow","red","pink"};
        return View(colors);
    }
    public IActionResult Poniedzialek(){
        var text = "fajna akcja poniedziałek";
        return View("Poniedzialek",text);
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
