namespace cw8;

public class Game
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Genre { get; set; }
    public int? Year { get; set; }
    public decimal? Price { get; set; }

    public override string ToString()
    {
        return $"{Title} {Genre} {Year} {Price}";
    }
}
