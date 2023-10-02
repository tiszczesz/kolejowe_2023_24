namespace cw5;

public class Game{
    //pola
    private string title;
    private string genre;
    private DateTime edition;
    private decimal price;
    //metody
    public Game()
    {
        title = "noname";
        genre = "noname";
        edition = new DateTime();
        price = 0M;
    }
    public Game(string title,string genre,DateTime edition = new DateTime(),decimal price = 0)
    {
        this.title = title;
        this.genre = genre;
        this.edition = edition;
        this.price = price;
    }
}