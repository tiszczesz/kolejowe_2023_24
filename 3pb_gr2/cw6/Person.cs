namespace cw6;

public class Person
{
    //pola
    private string? firstname;
    public string? PESEL { get; set; } //auto property
    public string? Firstname
    {
        get { return firstname?.ToUpper(); }
        set { firstname = value; }
    }
    private string? lastname;
    public string? Lastname
    {
        get { return lastname?.ToUpper(); }
        set { lastname = value; }
    }
    private DateTime birthDay;
    //metody
    public Person()
    {
        firstname = "noname";
        lastname = "noname";
        birthDay = new DateTime(2000, 1, 1);
    }
    //preciazanie metod
    public Person(string firstname, string lastname, DateTime birthDay)
    {
        this.firstname = firstname;
        this.lastname = lastname;
        this.birthDay = birthDay;
    }
    public override string ToString()
    {
        return $"Imie: {Firstname} Nazwisko: {Lastname} data urodzenia: {birthDay.ToShortDateString()}";
    }
}