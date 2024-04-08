using System.Text.Json;
using cw17_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace cw17_mvc.Controllers;


public class SilentController : Controller
{
    public IActionResult AllStudents()
    {
        List<Student> students = GetStudents() ?? new List<Student>();
        return View("Index",students);
    }
    private List<Student>? GetStudents()
    {
        string dane = System.IO.File.ReadAllText("dane.json");
        List<Student>? students = JsonSerializer.Deserialize<List<Student>>(dane);
        return students;
    }
}