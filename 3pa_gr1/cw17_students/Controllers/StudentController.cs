using cw17_students.Models;
using Microsoft.AspNetCore.Mvc;
namespace cw17_students.Controllers;

public class StudentController : Controller
{
    private StudentRepo _repo;
    public StudentController()
    {
        _repo = new StudentRepo();

    }
    public IActionResult Index()
    {
        var students = _repo.Students;
        return View(students);
    }
    [HttpGet]
    public IActionResult AddStudent()
    {
        return View();
    }
    [HttpPost]
    public IActionResult AddStudent(Student student)
    {
        return View();
    }
}
