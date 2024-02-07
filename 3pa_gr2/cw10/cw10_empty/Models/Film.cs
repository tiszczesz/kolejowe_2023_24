namespace cw10_empty;

public class Film
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Length { get; set; }
    public DateTime CreateDate { get; set; } = DateTime.Now;
}
