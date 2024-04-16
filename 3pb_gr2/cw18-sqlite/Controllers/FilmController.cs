using Microsoft.AspNetCore.Mvc;

namespace cw18_sqlite.Controllers;

public class FilmController:Controller
{
    public FilmController(IConfiguration configuration)
    {
        
    }
    public ActionResult List(){
        return View();
    }
}
