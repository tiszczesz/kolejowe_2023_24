
using Microsoft.AspNetCore.Mvc;
using cw17_mvc.Models;
namespace cw17_mvc.Controllers;
public class Film : Controller
{
    public string Hello()
    {
        return "Hello from controller: Film action Hello";
    }
    public IActionResult GetFilm()
    {
        string title = "ala ma kota";
        return Json(title);
    }
    public IActionResult AllFilms(){
        return Json(generFilms());
    }
    private List<MyFilm> generFilms()
    {
        return new List<MyFilm>{
            new MyFilm{
                Id = 1,
                Title = "Asssssss",
                Date = new DateOnly(),
                Length = 210
            },
             new MyFilm{
                Id = 2,
                Title = "Dffff",
                Date = new DateOnly(),
                Length = 180
            },
             new MyFilm{
                Id = 3,
                Title = "reeeeee",
                Date = new DateOnly(),
                Length = 240
            }
        };
    }
}