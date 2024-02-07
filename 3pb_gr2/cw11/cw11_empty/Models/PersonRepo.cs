namespace cw11_empty;

public class PersonRepo
{
    public static List<Person> GetPersons(){
       
        List<Person> persons = new List<Person>();
        var lines = File.ReadAllLines("dane.txt");
        foreach(var line in lines){
            var elems = line.Split('|');
            if(elems.Length==3){
                persons.Add(new Person{
                    Firstname = elems[0].Trim(),
                    Lastname = elems[1].Trim(),
                    Gift = elems[2].Trim()
                });
            }
            
        }
        return persons;
    }
}
