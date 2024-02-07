namespace cw16_form.Models
{
    public class FileRepo
    {
        public static void AddToFile(Person person,string filename="data.txt") {
            File.AppendAllText(filename,person.ToString());
        }
        public static List<Person>? GetAll(string filename = "data.txt")
        {
            List<Person> list = new List<Person>();
            List<string> lines = File.ReadAllLines(filename).ToList<string>();
            foreach (var line in lines)
            {
                string[] parts = line.Split(';');
                if(parts.Length == 3) {
                    var date = parts[2].Split('.');
                    list.Add(new Person {Pseudo = parts[0],Content = parts[1],DateOf = new DateOnly(
                        Convert.ToInt32(date[2]), 
                        Convert.ToInt32(date[1]), 
                        Convert.ToInt32(date[0]))
                    });
                }
            }
            return null;
        }
    }
}
