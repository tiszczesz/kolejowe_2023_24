using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw18_sqlite.Models;

public class Book
{
    public int Id { get; set; }
   
    [DisplayName("Podaj tytuł")]
    [Required(ErrorMessage = "Podaj tytuł")]
    public string? Title { get; set; }
    
    [DisplayName("Podaj autora")]
    [Required(ErrorMessage = "Podaj autora")]
    public string? Author { get; set; }
    
     [DisplayName("Podaj cenę")]
    [Required(ErrorMessage = "Podaj cenę")]
    public decimal? Price { get; set; }
}
