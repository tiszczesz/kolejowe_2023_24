using cw18_sqlite.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw18_sqlite.Controllers;

public class FilmController:Controller
{
    private FilmsRepo _repo;
    public FilmController(IConfiguration configuration)
    {
        _repo = new FilmsRepo(configuration);
    }
    public ActionResult List(){
        var films = _repo.GetAllFilms();
        return View(films);
    }
}
