namespace cw18_sqlite.Models;

public class MyFilm
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Director { get; set; }
    public string? Language { get; set; }
    public string? Date { get; set; }
    public decimal? Price { get; set; }
}
