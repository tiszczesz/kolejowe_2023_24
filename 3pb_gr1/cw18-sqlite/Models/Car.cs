using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw18_sqlite.Models;

public class Car
{

    public int Id { get; set; }
    
    [DisplayName("Model samochodu")]
    [Required(ErrorMessage = "Podaj model samochodu")]
    public string? Model { get; set; }
    
    [DisplayName("Rok produkcji")]
    [Required(ErrorMessage = "Podaj rok produkcji")]
    public int? Year { get; set; }
    
    [DisplayName("Cena samochodu")]
    [Required(ErrorMessage = "Podaj cenę samochodu")]
    public int? Price { get; set; }
}
