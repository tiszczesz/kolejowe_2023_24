namespace cw15_forms.Models
{
    public class FileRepo
    {
        public static  void SaveToFile(Todo todo, string path="data.txt")
        {
            File.AppendAllText(path, todo.ToString());
        }
    }
}
