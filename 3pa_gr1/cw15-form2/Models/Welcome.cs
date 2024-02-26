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
        public static Welcome? GetWelocme(string line)
        {
            //zamienic string z pliku na obiekt Welcome
            var data = line.Split('|');
            if (data.Length != 3) return null;
            var dateOnly = data[2].Split('.');
            DateTime date = new DateTime(
                Convert.ToInt32(dateOnly[2]),
                Convert.ToInt32(dateOnly[1]),
                Convert.ToInt32(dateOnly[0])
                );
            return new Welcome { Name = data[0], Content = data[1], DateGo = date };
        }
    }
}
