namespace cw6;

public class Person
{
    //pola
    private string? firstname;
    private string? lastname;

    private DateTime birthDay;
    //metody
    public Person()
    {
        firstname = "noname";
        lastname = "noname";
        birthDay = new DateTime(2000, 1, 1);
    }
    // //preciazanie metod
    public Person(string firstname,string lastname,DateTime birthDay)
    {
        this.firstname = firstname;
        this.lastname = lastname;
        this.birthDay = birthDay;
    }
    public override string ToString()
    {
        return $"Imie: {firstname} Nazwisko: {lastname} data urodzenia: {birthDay}";
    }
}