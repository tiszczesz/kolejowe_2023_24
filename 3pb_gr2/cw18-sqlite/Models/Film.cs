using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw18_sqlite.Models;

public class MyFilm
{
    public int Id { get; set; }

    [DisplayName("Tytuł")]
    [Required(ErrorMessage = "Podaj tytuł")]
    public string? Title { get; set; }

    [DisplayName("Reżyser")]
    [Required(ErrorMessage = "Podaj reżsera")]
    public string? Director { get; set; }

    [DisplayName("Język dialogów")]
    [Required(ErrorMessage = "Podaj jaki język")]
    public string? Language { get; set; }

    [DisplayName("Data produkcji")]
    [Required(ErrorMessage = "Podaj datę")]
    public string? Date { get; set; }

    [DisplayName("Cena")]
    [Required(ErrorMessage = "Podaj cenę")]
    public decimal? Price { get; set; }
}
