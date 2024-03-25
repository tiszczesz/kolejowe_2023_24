using Microsoft.AspNetCore.Mvc;

namespace cw16_mvc;

public class RybaController: Controller
{
    public IActionResult Index(){
        
        return View();
    }
}
