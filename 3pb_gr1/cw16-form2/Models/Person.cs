using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw16_form2.Models
{
    public class Person
    {
        [DisplayName("Podaj kto Ty")]
        [Required(ErrorMessage = "Przedstaw się")]
        public string? Name { get; set; }

        [DisplayName("Co przyniesiesz")]
        public string? Content { get; set; }

        [Display(Name = "Kiedy potwierdzisz")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "podaj datę")]
        public DateOnly? ConfirmDate { get; set; }
        public override string ToString()
        {
            return $"{Name};{Content};{ConfirmDate?.ToShortDateString()}" + Environment.NewLine;
        }
    }
}
