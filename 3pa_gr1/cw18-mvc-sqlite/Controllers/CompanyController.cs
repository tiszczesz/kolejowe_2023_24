using cw18_mvc_sqlite.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw18_mvc_sqlite.Controllers;

public class CompanyController: Controller
{
    private readonly CompanyRepo _repo;
    public CompanyController(IConfiguration configuration)
    {
        _repo = new CompanyRepo(configuration);
    }
    public IActionResult List(){
        var companies = _repo.GetAll();
        return View(companies);
    }
}
