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
            if(!File.Exists(filename)) return null;
            List<string> lines = File.ReadAllLines(filename).ToList<string>();
            
            foreach (var line in lines)
            {
                string[] parts = line.Split(';');
                if(parts.Length == 4) {
                    var date = parts[3].Split('.');
                    list.Add(new Person {Id=parts[0],Pseudo = parts[1],Content = parts[2],DateOf = new DateOnly(
                        Convert.ToInt32(date[2]), 
                        Convert.ToInt32(date[1]), 
                        Convert.ToInt32(date[0]))
                    });
                }
            }
            return list;
        }

        public static void SaveAll(List<Person> persons,string filename="data.txt")
        {
            List<string> lines = new List<string>();
            foreach(var p in persons){
                lines.Add(p.ToString());
            }
            File.WriteAllLines(filename,lines);
        }
    }
}
