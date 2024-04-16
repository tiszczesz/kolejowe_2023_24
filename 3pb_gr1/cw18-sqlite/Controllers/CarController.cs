﻿using cw18_sqlite.Models;
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
}