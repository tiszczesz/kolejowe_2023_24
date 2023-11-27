namespace cw9_empty;

public class StudentsRepo
{
    public static List<Student> GetStudents(){
        return new List<Student>{
            new Student{Id=1,Firstname="Adam",Lastname="Nowak",Age=23},
            new Student{Id=2,Firstname="Anna",Lastname="Nowak",Age=11},
            new Student{Id=3,Firstname="Mateusz",Lastname="Łowicki",Age=44},
            new Student{Id=4,Firstname="Franciszek",Lastname="Kowalski",Age=54}
        };
    }
}
