using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace web1;

public class Todo
{
    
    public int Id { get; set; }

    [DisplayName("Zawartość")]
    [Required(ErrorMessage = "Podaj zawartość")]
    public string? Content { get; set; }

    [DisplayName("Data")]
    [Required(ErrorMessage = "Podaj Datę")]
    public DateOnly? Date { get; set; }
}
