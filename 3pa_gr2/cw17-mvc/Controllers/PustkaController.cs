using cw17_mvc.Models;
using Microsoft.AspNetCore.Mvc;
namespace cw17_mvc.Controllers;

public class PustkaController : Controller {
    public string Hello(){
        return "Hello from action Hello in Controller Pustka";
    }
    public IActionResult GetListStrings(){
        List<string> list = new(){"gggg","jjj","kkkk"};
        return Json(list);
    }
    public IActionResult AllBooks(){
        return Json(GetBooks());
    }
    public IActionResult ToTable(){
        return View(GetBooks());
    }
    private List<Book> GetBooks(){
        return new List<Book>{
            new Book{
                Id = 1,
                Title = "Fajna książka",
                Pages = 200
            },
             new Book{
                Id = 2,
                Title = "Fajna książka 2",
                Pages = 350
            }, new Book{
                Id = 3,
                Title = "Fajna książka 3",
                Pages = 123
            }, new Book{
                Id = 4,
                Title = "Fajna książka 4",
                Pages = 19
            }
        };
    }
}