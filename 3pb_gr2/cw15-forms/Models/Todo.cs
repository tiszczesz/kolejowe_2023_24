using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace cw15_forms.Models
{
    public class Todo
    {
        public Todo()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
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
            return $"{Id};{Title};{Content};{DateOf?.ToShortDateString()}";
        }
        public static Todo? GetTodo(string line){
            var items = line.Split(';');
            if(items.Length==4){
                var toDate = items[3].Split('.');
                DateOnly date = new DateOnly(
                    Convert.ToInt32(toDate[2]),
                    Convert.ToInt32(toDate[1]),
                    Convert.ToInt32(toDate[0])
                    );
                return new Todo{Id=items[0],Title=items[1],Content=items[2],DateOf=date};
            }
            return null;
        }
    }
}
