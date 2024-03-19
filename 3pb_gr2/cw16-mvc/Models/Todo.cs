
namespace cw16_mvc.Models;

public class Todo{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public bool IsFinished { get; set; }
}