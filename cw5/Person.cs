namespace cw5;

public class Person{

    //pola klasy
    private string? firstname;
    public string? Firstname{
        get{ return firstname?.ToUpper();}
        set {firstname = value;}
    }
    private string? lastname;
    public string? Lastname{
        get{ return lastname?.ToUpper();}
        set {lastname = value;}
    }
    private DateTime birthDay;
    
    //metody klasy
    public Person()
    {
        firstname = "noname";
        lastname = "noname";
        birthDay = new DateTime(2000,6,12);
    }
    //przeciazanie metod klasy
    public Person(string? firstname,string? lastname,DateTime birthDay)
    {
        this.firstname = firstname;
        this.lastname = lastname;
        this.birthDay = birthDay;
    }
    //nadpisywanie metody ToString z klasy bazowej Object
    public override string ToString()
    {
        return $"Imie: {Firstname} nazwisko: {Lastname} data urodzenia: {birthDay.ToShortDateString()}";
    }
}