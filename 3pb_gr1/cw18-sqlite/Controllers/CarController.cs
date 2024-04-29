using cw18_sqlite.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw18_sqlite.Controllers;

public class CarController:Controller
{
    private CarsRepo _repo;
    public CarController(IConfiguration configuration){
        _repo = new CarsRepo(configuration);
    }
    public ActionResult List(){
        var cars = _repo.GetCars();
        return View(cars);  
    }
    [HttpGet]
    public IActionResult Insert(){
        return View();
    }
     [HttpPost]
    public IActionResult Insert(Car car){
        if(ModelState.IsValid){
            //do bazy danych wstawienie
            _repo.InsertCar(car);
            return RedirectToAction("List");
        }
        return View();
    }

    public IActionResult Delete(int? id) {
        //usuwanie rekordu
        return RedirectToAction(nameof(List));
    }

    [HttpGet]
    public IActionResult Update(int? id) {
        Car? car = _repo.GetCarById(id);
        return View();
    }
    [HttpPost]
    public IActionResult Update(Car car)
    {
        if (ModelState.IsValid) {
            //zmiana danych
            return RedirectToAction(nameof(List));
        }
        return View();
    }
}
