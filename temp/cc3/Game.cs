namespace cc3;

public class Game
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public decimal Price { get; set; }
    public DateTime Edition { get; set; }
    public override string ToString()
    {
        return $"Id: {Id} Title: {Title} Price: {Price} Edition: {Edition}";
    }
}
