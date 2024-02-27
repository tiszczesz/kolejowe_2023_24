
namespace cw16_form2.Models
{
    public class FileRepo
    {
        public static void AddToFile(Person person,string fileName="data.txt") {
            File.AppendAllText(fileName,person.ToString());
        }
        public static List<Person> GetAll(string fileName = "data.txt"){
            List<Person> persons = new();
            if(File.Exists(fileName)){
                 var lines = File.ReadAllLines(fileName);
                 foreach(var line in lines){
                    var person = Person.GetPerson(line);
                    if(person!=null){
                        persons.Add(person);
                    }
                 }
            }
            return persons;           
        }

        public static void SaveAll(List<Person> persons,string fileName="data.txt")
        {
            List<string> lines = new();
            foreach(var p in persons){
                lines.Add(p.ToString());
            }
            File.WriteAllLines(fileName,lines);
        } 
    }
}
