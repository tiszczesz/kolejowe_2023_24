namespace cw16_form2.Models
{
    public class FileRepo
    {
        public static void AddToFile(Person person,string fileName="data.txt") {
            File.AppendAllText(fileName,person.ToString());
        }
    }
}
