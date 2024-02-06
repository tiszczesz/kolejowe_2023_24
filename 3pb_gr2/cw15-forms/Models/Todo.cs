using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw15_forms.Models
{
    public class Todo
    {
        [Display(Name = "Nagłówek zadania")]
        [Required(ErrorMessage = "Podaj nazwę zadania")]
        public string? Title { get; set; }

        [Display(Name = "Treść zadania")]
        public string? Content { get; set; }

        [DisplayName("Podaj datę wykonania")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Podaj datę")]
        public DateOnly? DateOf { get; set; }
        public override string ToString()
        {
            return $"{Title};{Content};{DateOf?.ToShortDateString()}"
                + Environment.NewLine;
        }
    }
}
