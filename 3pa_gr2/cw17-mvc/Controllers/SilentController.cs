using cw17_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw17_mvc.Controllers;


public class SilentController : Controller{
    public IActionResult AllStudents(){
        List<Student> students = new List<Student>();
        return View(students);
    }
}