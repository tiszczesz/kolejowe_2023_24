namespace cw5;

public class Person{

    //pola klasy
    private string? firstname;
    private string? lastname;
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
        return $"Imie: {firstname} nazwisko: {lastname} data urodzenia: {birthDay.ToShortDateString()}";
    }
}