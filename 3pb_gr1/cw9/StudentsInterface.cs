
namespace cw9;

public class StudentsInterface
{
    public static void ShowAllStudents(List<Student> students){
        Console.WriteLine($" ==== Lista Studentow ilosc:  {students.Count}  =======");
        foreach(var student in students){
            ShowStudent(student);
        }
    }

    public static void ShowStudent(Student student)
    {
        Console.WriteLine("Imie:\t "+student.Firstname);
        Console.WriteLine("Nazwisko:\t "+student.Lastname);
        Console.WriteLine("Data urodzenia:\t "+student.BirthDay.ToShortDateString());
        Console.WriteLine("Srednia ocen:\t "+student.AvgRange);
        Console.WriteLine(" ================================  \n");
    }
   
}
