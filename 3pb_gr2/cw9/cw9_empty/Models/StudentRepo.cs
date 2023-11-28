namespace cw9_empty;

public class StudentRepo
{
    public static List<Student> GetStudents(){
        return new List<Student>{
            new Student{Id=1,Firstname="Roman",Lastname="Nowak",Age=23},
            new Student{Id=2,Firstname="Monki",Lastname="Nowak",Age=11},
            new Student{Id=3,Firstname="Grażyna",Lastname="fff",Age=23},
            new Student{Id=4,Firstname="Edyta",Lastname="Nogggwak",Age=23},
            new Student{Id=5,Firstname="Tomasz",Lastname="Nowak",Age=56}
        };
    }
}
