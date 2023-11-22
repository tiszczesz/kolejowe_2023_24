namespace WebApplication2.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public DateTime? RealizeDate { get; set; }
    }
}
