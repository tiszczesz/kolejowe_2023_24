using System.ComponentModel.DataAnnotations;

namespace cw15_form2.Models
{
    public class Welcome
    {
        [Display(Name = "Twoja nazwa")]
        [Required(ErrorMessage = "Musisz się przedstawić")]
        public string? Name { get; set; }

        [Display(Name = "Co przyniesiesz")]
        public string? Content { get; set; }

        [Display(Name = "Do kiedy potwirdzenie")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Podaj datę")]
        public DateTime? DateGo { get; set; }
        public override string ToString()
        {
            return $"{Name}|{Content}|{DateGo?.ToShortDateString()}" + Environment.NewLine;
        }
    }
}
