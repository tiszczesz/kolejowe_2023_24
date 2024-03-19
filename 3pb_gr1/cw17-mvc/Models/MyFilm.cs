namespace cw17_mvc.Models;
public class MyFilm{
    public int Id { get; set; }
    public string? Title { get; set; }
    public DateOnly? Date { get; set; }
    public int? Length { get; set; }
}