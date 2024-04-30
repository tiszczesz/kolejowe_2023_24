using cw18_sqlite.Models;
using Microsoft.AspNetCore.Mvc;


namespace cw18_sqlite.Controllers;

public class FilmController : Controller
{
    private FilmsRepo _repo;
    public FilmController(IConfiguration configuration)
    {
        _repo = new FilmsRepo(configuration);
    }
    public ActionResult List()
    {
        var films = _repo.GetAllFilms();
        return View(films);
    }
    [HttpGet]
    public IActionResult Insert()
    {

        return View();
    }
    [HttpPost]
    public IActionResult Insert(MyFilm film)
    {
        if (ModelState.IsValid)
        {
            _repo.InsertFilm(film);
            return RedirectToAction(nameof(List));
        }
        return View(film);
    }
    public IActionResult Delete(int? id)
    {
        if (id != null) {
            _repo.Delete(id);
        }
        return RedirectToAction(nameof(List));
    }
    [HttpGet]
    public IActionResult Update(int? id)
    {
        if (id != null) {
            var film = _repo.GetById(id);
            if (film != null) {
                return View(film);
            }
        }
        return RedirectToAction(nameof(List));
    }
    [HttpPost]
    public IActionResult Update(MyFilm film)
    {
        if(ModelState.IsValid){
            //update filmu
            return RedirectToAction(nameof(List));
        }
        return View(film);
    }
}
