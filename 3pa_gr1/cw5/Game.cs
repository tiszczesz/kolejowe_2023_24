namespace cw5;

public class Game
{
    //pola
    private string title;
    private string genre;
    public string Genre{
        get {return genre.ToUpper();}
    }
    private DateTime edition;
    private decimal price;

    public decimal Price
    {
        get { return price; }
        set
        {
            price = value > 0 ? value : -value;
        }
    }

    //metody
    public Game()
    {
        title = "noname";
        genre = "noname";
        edition = new DateTime();
        price = 0M;
    }
    public Game(string title, string genre, DateTime edition = new DateTime(), decimal price = 0)
    {
        this.title = title;
        this.genre = genre;
        this.edition = edition;
        this.price = price;
    }
    public override string ToString()
    {
        return $"title: {title} genre: {Genre} edition: {edition.ToShortDateString()} price: {price} PLN";
    }
}