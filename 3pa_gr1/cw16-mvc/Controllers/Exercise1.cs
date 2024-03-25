

using cw16_mvc.Models;
using Microsoft.AspNetCore.Mvc;


namespace cw16_mvc.Controllers;

public class Exercise1 : Controller {

    public IActionResult GetFromFile(){
        
        // if(!System.IO.File.Exists("dane.txt")) return Json("brak pliku") ;
        // var lines = System.IO.File.ReadAllLines("dane.txt");
        var users = UserRepo.GetUsers();
        return Json(users);
    }
    public IActionResult ToTable(){
         var users = UserRepo.GetUsers();
         Tools();
         return View(users);
    }
    private void Tools(){
        //dodatkowe czynnosci
    }
}