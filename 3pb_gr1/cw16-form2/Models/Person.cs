using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw16_form2.Models
{
    public class Person
    {
        public Person()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

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
            return $"{Id};{Name};{Content};{ConfirmDate?.ToShortDateString()}";
        }
        public static Person? GetPerson(string line){
            var elems = line.Split(';');
            if(elems.Length==4){
                var toDate = elems[3].Split('.');
                DateOnly date = new DateOnly(
                    Convert.ToInt32(toDate[2]),
                    Convert.ToInt32(toDate[1]),
                    Convert.ToInt32(toDate[0]));
                return new Person{Id=elems[0],Name=elems[1],Content=elems[2],ConfirmDate = date};
            }
            return null;
        }
    }
}
