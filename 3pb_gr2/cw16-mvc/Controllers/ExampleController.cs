
using cw16_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw16_mvc.Controllers;

public class Example : Controller
{
    public string Hello()
    {
        return "Witamy w kontrolerze Example i akcji Hello";
    }
    public IActionResult GetById(int id){
        var result =  getTodos().FirstOrDefault(t=>t.Id==id);
        return Json(result);
    }
    public IActionResult GetAll(){
        return Json(getTodos());
    }
    private List<Todo> getTodos()
    {
        return new List<Todo>{
            new Todo{Id=1,Title="Zadanie 1",
            Content = "trudne zadame",
            IsFinished = false},
             new Todo{Id=2,Title="Zadanie 2",
            Content = "trudne zadame",
            IsFinished = true},
             new Todo{Id=3,Title="Zadanie 3",
            Content = "trudne zadame",
            IsFinished = false},
        };
    }
}