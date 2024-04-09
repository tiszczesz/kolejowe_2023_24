using Microsoft.AspNetCore.Mvc;
using zadanie1.Models;

namespace zadanie1.Controllers;

public class CarAuctionController : Controller
{
    private readonly CarsRepo _repo;
    public CarAuctionController()
    {
        _repo = new CarsRepo();
    }
    public string GetString(){
        string currentDate ="Dzisiaj mamy: "+ DateTime.Now.ToShortDateString();
        return currentDate;
    }
    public IActionResult Index(){
       var cars = _repo.Cars;
        return Json(cars);
    }
    public IActionResult ToTable(){
        var cars = _repo.Cars;
        return View(cars);
    }
}
