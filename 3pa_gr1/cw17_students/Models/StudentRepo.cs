using System.Text.Json;
namespace cw17_students.Models;

public class StudentRepo
{
    public List<Student>? Students { get; set; }
    private string _filename;
    public StudentRepo(string filename="students.json")
    {
        _filename = filename;
        string students = File.ReadAllText(_filename);
        Students = JsonSerializer.Deserialize<List<Student>>(students);
    }
}
