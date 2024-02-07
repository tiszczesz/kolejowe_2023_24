using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw16_form.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Musisz się przedstawić")]
        [DisplayName("Podaj kto Ty")]
        public string? Pseudo { get; set; }

        [DisplayName("Co przyniesiesz")]
        public string? Content { get; set; }

        [Required(ErrorMessage = "Kiedy potwierdzisz")]
        [Display(Name = "Data potwierdzenia")]
        [DataType(DataType.Date)]
        public DateOnly? DateOf { get; set; }
        public override string ToString()

        {
            return $"{Pseudo};{Content};{DateOf?.ToShortDateString()}"+Environment.NewLine;
        }
    }
}
