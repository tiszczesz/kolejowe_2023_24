using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using cw17_mvc.Models;

namespace cw17_mvc.Controllers;

public class PersonController : Controller {
    public IActionResult Index(){
        var person = new Person{
            Firstname = "Roman",
            Lastname = "Bułecki",
            Age = 23
        };
        return View(person);
    }
}