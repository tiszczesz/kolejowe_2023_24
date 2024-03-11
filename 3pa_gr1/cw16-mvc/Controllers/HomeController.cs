using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using cw16_mvc.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace cw16_mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.controller = ControllerContext.ActionDescriptor.ControllerName;
        ViewBag.action = ControllerContext.ActionDescriptor.ActionName;
        return View();
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
