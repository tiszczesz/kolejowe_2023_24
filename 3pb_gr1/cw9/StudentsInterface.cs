
namespace cw9;

public class StudentsInterface
{
    public static void ShowAllStudents(List<Student> students)
    {
        Console.WriteLine($" ==== Lista Studentow ilosc:  {students.Count}  =======");
        foreach (var student in students)
        {
            ShowStudent(student);
        }
    }

    public static void ShowStudent(Student student)
    {
        Console.WriteLine("Imie:\t " + student.Firstname);
        Console.WriteLine("Nazwisko:\t " + student.Lastname);
        Console.WriteLine("Data urodzenia:\t " + student.BirthDay.ToShortDateString());
        Console.WriteLine("Srednia ocen:\t " + student.AvgRange);
        Console.WriteLine(" ================================  \n");
    }
    public static Student GetStudent()
    {
        Console.WriteLine(" === Podaj informacje o studencie =====");
        Console.Write("Podaj imie: ");
        string? firstname = Console.ReadLine()?.Trim();
        Console.Write("Podaj nazwisko: ");
        string? lastname = Console.ReadLine()?.Trim();
        Console.Write("Podaj date urodzenia: ");
        DateTime date = GetDate();
        Console.Write("Podaj srednia ocen: ");
        double avg = Convert.ToDouble(Console.ReadLine());
        return new Student{
            Id = -1,
            Firstname = firstname,
            Lastname = lastname,
            BirthDay = date,
            AvgRange = avg
        };
    }
    private static DateTime GetDate()
    {
        Console.Write("Podaj rok urodzenia: ");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.Write("Podaj miesiac urodzenia: ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Podaj dzien urodzenia: ");
        int day = Convert.ToInt32(Console.ReadLine());
        return new DateTime(year,month,day);
    }
}
