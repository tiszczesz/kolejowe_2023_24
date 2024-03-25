namespace cw10_razor_empty;

public class Students
{
    public static List<Student> GetAll(){
        return new List<Student>{
            new Student{Id=1,Firstname="Jan",Lastname="Nowak"},
            new Student{Id=2,Firstname="Roman",Lastname="Małecki"},
        };  
    }
}
public class Student{
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
}
