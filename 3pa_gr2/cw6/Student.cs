namespace cw6;

public class Student
{
    //pola klasy
    private string? firstname;
    public double Avg { get; set; }
    public string? Firstname
    {
        get { return firstname?.ToUpper(); }
    }
    private string? lastname;
    public string? Lastname
    {
        get { return lastname?.ToUpper(); }
    }
   
    private int? age;
    public int? Age
    {
        get { return age; }
        set { age = value >= 0 ? value : -value; }
    }

    //metody klasy
    public Student()
    {
        firstname = "noname";
        lastname = "noname";
        age = 10;
    }
    //przeciazanie
    public Student(string firstname, string lastname, int age)
    {
        this.firstname = firstname;
        this.lastname = lastname;
        this.age = age;
    }
    public override string ToString()
    {
        return $"imie: {Firstname} nazwisko: {Lastname} wiek: {Age}";
    }
}