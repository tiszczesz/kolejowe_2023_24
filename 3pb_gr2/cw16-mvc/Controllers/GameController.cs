using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using cw16_mvc.Models;

namespace cw16_mvc.Controllers;

public class GameController : Controller {
    public IActionResult Colors(){
        var colors = new List<string>{"white","green","blue","red"};
        return View(colors);
    }
}